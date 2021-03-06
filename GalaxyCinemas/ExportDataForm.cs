﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using Common;
namespace GalaxyCinemas
{
    public partial class ExportDataForm : Form
    {
        public ExportDataForm()
        {
            InitializeComponent();
            this.FormClosing += ExportDataForm_FormClosing;
        }

        /// <summary>
        /// Allows user to browse to a save location for the XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectExportBooking_Click(object sender, EventArgs e)
        {
            




            txtFileBooking.Focus(); // Set focus on this field. Moving focus will force validation of the value.
        } //here warning
       // TextWriter writer;
        private void Serialise(List<Booking> list, String fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Booking));
            // TextWriter writer;
            //  serializer.Serialize(writer, list);
            String xml;
            using (StringWriter stringWriter = new StringWriter())
            {
              serializer.Serialize(stringWriter, list);
                xml = stringWriter.ToString();
                //  Console.WriteLine(writer);

            }
            //return writer.ToString();
        }
        /// <summary>
        /// Export bookings to XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
















        /// <summary>
        /// Serialize bookings to XML file.
        /// </summary>
        /// <param name="list"></param>
        















        /// <summary>
        /// Closes the form and goes back to main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        #region Form validation

        /// <summary>
        /// Check all form fields are valid. This works even if they haven't clicked into every field.
        /// </summary>
        /// <returns></returns>
        private bool IsFormValid()
        {
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
            return true;
        }

        /// <summary>
        /// Validate the filename.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFileBooking_Validating(object sender, CancelEventArgs e)
        {
            // Check if file path is valid.
            bool pathValid = true;
            try
            {
                FileInfo fi = new FileInfo(txtFileBooking.Text);
                pathValid = fi.Directory.Exists;
            }
            catch (Exception)
            {
                pathValid = false;
            }

            if (!pathValid)
            {
                errorProvider.SetError(txtFileBooking, "Please choose a valid path to export to");
                e.Cancel = true; // Don't allow moving to the next field.
            }
            else errorProvider.SetError(txtFileBooking, ""); // Clear error if all fine.
        }

        /// <summary>
        /// Validate the to date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTo_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTo.Value.Date < dtpFrom.Value.Date)
            {
                errorProvider.SetError(dtpTo, "The 'to' date must be greater than or equal to the 'from' date");
                e.Cancel = true; // Don't allow moving to the next field.
            }
            else errorProvider.SetError(dtpTo, ""); // Clear error if all fine.
        }

        private void ExportDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't allow validation to prevent closing.
            e.Cancel = false;
        }

        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            txtFileBooking.Text = saveFileDialog.FileName;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(IsFormValid() == false){
                return;
            }
            try
            {
               string dtpfromString = dtpFrom.ToString();
                string dtpToString = dtpTo.ToString();
                DateTime from = DateTime.Parse(dtpfromString);
                DateTime to = DateTime.Parse(dtpToString);

                List<Booking> bookings = DataLayer.DataLayer.GetBookingsInDateRange(from,to);
                Serialise(bookings,bookings.Count.ToString());
          //    int imported =   bookings.Count();
               

            }
            catch (Exception ex )
            {
                MessageBox.Show("error has occured while booking");
                Console.WriteLine(ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            
            this.Close();
        }

        private void ExportDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
