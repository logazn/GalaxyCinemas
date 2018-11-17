﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Common;

namespace GalaxyCinemas
{
    public partial class BookingForm : Form
    {
        const decimal BASETICKETPRICE = 14.0m;

        // Base ticket price used for calculations
        List<ISpecialPlugin> specialPlugins;
        Booking booking = new Booking();




        public BookingForm(List<ISpecialPlugin> plugins)
        {
            Booking Book = new Booking();
            specialPlugins = plugins;
            InitializeComponent();
           
            // Create a Booking object. We will set the properties of this as we progress through the form, and save when the form is submitted.
           
            // We are provided the loaded plugins from the main application because loading plugins using reflection is very expensive and should not be done often.
           

           
            
            // Populate the movies dropdown with a list of movies.
            PopulateMovies();
            // Ensure the user can't select a date in the past.
            dtpSessionDate.MinDate = DateTime.Today;
            this.FormClosing += BookingForm_FormClosing;
        }

        /// <summary>
        /// Populate the movies dropdown with a list of Movies from the database, sorted by title.
        /// </summary>
        public void PopulateMovies()
        {
            cboMovie.DisplayMember = "Title";
            cboMovie.ValueMember = "MovieID";
            // Call method GetAllMovies using Result.
            List<Movie> movies = DataLayer.DataLayer.GetAllMovies().OrderBy(m => m.GetTitle()).ToList();
            cboMovie.DataSource = movies;
            cboMovie.SelectedIndex = -1;
        }

        /// <summary>
        /// Populate the sessions dropdown with a list of Sessions from the database, filtering by a selected movie and date.
        /// </summary>
        public void PopulateSessions(int MovieID, DateTime date)
        {
            cboSession.DisplayMember = "ShortFormat";
            cboSession.ValueMember = "SessionID";
            List<Session> sessions = DataLayer.DataLayer.GetAllSessionsForMovie(MovieID, date).OrderBy(s => s.SessionDate).ToList();
            cboSession.DataSource = sessions;
        }

        /// <summary>
        /// When the selected movie is changed, update the options in the sessions dropdown.
        /// </summary>
        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtpSessionDate.Value != null && cboMovie.SelectedValue != null)
            {
                // Populate the sessions dropdown with values based on the newly selected movie.
                PopulateSessions((int)cboMovie.SelectedValue, dtpSessionDate.Value);
                // Clear errors on the datepicker and the session dropdown as they are no longer relevant.
                errorProvider.SetError(dtpSessionDate, "");
                errorProvider.SetError(cboSession, "");
            }
            else
            {
                // Clear out the sessions dropdown if prerequesite fields aren't filled in.
                cboSession.DataSource = null;
            }
        }

        /// <summary>
        /// When the selected date is changed, update the options in the sessions dropdown.
        /// </summary>
        private void dtpSessionDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpSessionDate.Value != null && cboMovie.SelectedValue != null)
            {
                // Populate the sessions dropdown with values based on the newly selected date.
                PopulateSessions((int)cboMovie.SelectedValue, dtpSessionDate.Value);
                // Clear errors on the session dropdown as they are no longer relevant.
                errorProvider.SetError(cboSession, "");
            }
            else
            {
                // Clear out the sessions dropdown if prerequesite fields aren't filled in.
                cboSession.DataSource = null;
            }
        }

        /// <summary>
        /// When a session is selected, set the SessionID for the Booking and update the price on the form.
        /// </summary>
        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSession.SelectedValue != null)
            {
                booking.SessionId = (int)cboSession.SelectedValue;
                Session session = DataLayer.DataLayer.GetSessionByID(booking.SessionId);
                booking.SessionDate = session.SessionDate;
            }
            else booking.SessionId = 0;

            if (!string.IsNullOrEmpty(txtQuantity.Text) && booking.SessionId > 0)
            {
                UpdatePrice();
            }
        }

        /// <summary>
        /// When the quantity is changed, update the price on the form if the quantity is valid and a session is selected.
        /// </summary>
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && cboSession.SelectedValue != null)
            {
                booking.Quantity = int.Parse(txtQuantity.Text);
                UpdatePrice();
            }
        }

        /// <summary>
        /// Update the price to match the selected values.
        /// </summary>
        private void UpdatePrice()
        {
            decimal originalPrice = booking.Quantity * BASETICKETPRICE;
            // Calculate the original (full) price.

            decimal finalPrice = originalPrice;

            originalPrice = booking.OriginalPrice;
            string specialName = "";



            // Prepare to compare original price to special prices.

            foreach (var  price in specialPlugins)
            {
                decimal currentSpecialPrice = originalPrice;
                string currentSpecialName = "";

                if (price.CalculateSpecial(booking, ref currentSpecialName,ref currentSpecialPrice) == true)
                {
                    if (currentSpecialPrice < finalPrice)
                    {
                        finalPrice = currentSpecialPrice;
                        currentSpecialName = specialName;

                    }
                }
                booking.FinalPrice = finalPrice;
                booking.Special = specialName;
                booking.Discount = originalPrice - finalPrice;

            }
            lblFinalPrice.Text = booking.FinalPrice.ToString();
            lblOriginalPrice.Text = booking.Discount.ToString();
            lblSpecialName.Text = booking.Special;


            
            
                
               
               
            
            // Record pricing and special information in the Booking.
            



            // Display pricing and special information on the form.
            



        }
       



        
        

        #region Form validation

        // We set this to true to apply stricter validation, e.g. prevent continuing form submission.
        private bool blockSubmitIfValidationFails = false;

        /// <summary>
        /// Check all form fields are valid. This works even if they haven't clicked into every field.
        /// </summary>
        /// <returns></returns>
        private bool IsFormValid()
        {
            try
            {
                blockSubmitIfValidationFails = true;
                foreach (Control control in Controls)
                {
                    // Set focus on control
                    control.Focus();
                    // Validate causes the control's Validating event to be fired,
                    // if CausesValidation is True
                    if (!Validate())
                    {
                        return false;
                    }
                }
            }
            finally
            {
                blockSubmitIfValidationFails = false;
                Validate(); // Fixes rare combo box issue where the combo won't dropdown after Validating handler sets e.Cancel=true;
            }
            return true;
        }
        
        /// <summary>
        /// Validate that a movie has been selected.
        /// </summary>
        private void cboMovie_Validating(object sender, CancelEventArgs e)
        {
            if (cboMovie.SelectedIndex < 0)
            {
                errorProvider.SetError(cboMovie, "Please select a movie");
                e.Cancel = blockSubmitIfValidationFails;
            }
            else errorProvider.SetError(cboMovie, "");
        }

        /// <summary>
        /// Validate that a session is selected if there are any sessions to select.
        /// </summary>
        private void cboSession_Validating(object sender, CancelEventArgs e)
        {
            if (cboSession.SelectedIndex < 0 && cboSession.Items.Count > 0)
            {
                errorProvider.SetError(cboSession, "Please select a session");
                e.Cancel = blockSubmitIfValidationFails; // To prevent getting trapped in this field if the wrong movie or date is selected.
            }
            else errorProvider.SetError(cboSession, "");
        }

        /// <summary>
        /// Validate that at least one session exists for the selected movie and date, if a movie is selected.
        /// </summary>
        private void SessionDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (cboMovie.SelectedIndex > -1 && cboSession.Items.Count == 0)
            {
                errorProvider.SetError(dtpSessionDate, "Please select a valid session date");
                e.Cancel = blockSubmitIfValidationFails; // To prevent getting trapped in this field if the wrong movie is selected.
            }
            else errorProvider.SetError(dtpSessionDate, "");
        }

        /// <summary>
        /// Validate that a quantity between 1 and 200 has been entered.
        /// </summary>
        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            int quantity = 0;
            int.TryParse(txtQuantity.Text, out quantity);

            if (quantity < 1 || quantity > 200)
            {
                errorProvider.SetError(txtQuantity, "Please enter a valid quantity");
                e.Cancel = true;
            }
            else errorProvider.SetError(txtQuantity, "");
        }

        private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't allow validation to prevent closing.
            e.Cancel = false;
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.FormClosing += BookingForm_FormClosing;
            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsFormValid() == true)
            {
                DataLayer.DataLayer.AddBooking(booking);
                MessageBox.Show("Added booking" + booking.BookingNumber);
               
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}

