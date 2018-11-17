namespace GalaxyCinemas
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.cboSession = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSpecialName = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(44, 528);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboMovie
            // 
            this.cboMovie.DisplayMember = "Title";
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(243, 37);
            this.cboMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(598, 28);
            this.cboMovie.TabIndex = 2;
            this.cboMovie.ValueMember = "ID";
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            this.cboMovie.Validating += new System.ComponentModel.CancelEventHandler(this.cboMovie_Validating);
            // 
            // cboSession
            // 
            this.cboSession.FormattingEnabled = true;
            this.cboSession.Location = new System.Drawing.Point(243, 163);
            this.cboSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSession.Name = "cboSession";
            this.cboSession.Size = new System.Drawing.Size(180, 28);
            this.cboSession.TabIndex = 3;
            this.cboSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            this.cboSession.Validating += new System.ComponentModel.CancelEventHandler(this.cboSession_Validating);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(243, 229);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 26);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Session Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Special";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Final Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Session Date";
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.Location = new System.Drawing.Point(243, 105);
            this.dtpSessionDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSessionDate.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(298, 26);
            this.dtpSessionDate.TabIndex = 17;
            this.dtpSessionDate.ValueChanged += new System.EventHandler(this.dtpSessionDate_ValueChanged);
            this.dtpSessionDate.Validating += new System.ComponentModel.CancelEventHandler(this.SessionDateTimePicker_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 371);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Original Price";
            // 
            // lblSpecialName
            // 
            this.lblSpecialName.AutoSize = true;
            this.lblSpecialName.Location = new System.Drawing.Point(243, 303);
            this.lblSpecialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialName.Name = "lblSpecialName";
            this.lblSpecialName.Size = new System.Drawing.Size(0, 20);
            this.lblSpecialName.TabIndex = 24;
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Location = new System.Drawing.Point(243, 369);
            this.lblOriginalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblOriginalPrice.TabIndex = 25;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(243, 438);
            this.lblFinalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblFinalPrice.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblSpecialName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpSessionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSession);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.btnSubmit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.ComboBox cboSession;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSpecialName;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
    }
}

