namespace GalaxyCinemas
{
    partial class ExportDataForm
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
            this.btnSelectExportMovies = new System.Windows.Forms.Button();
            this.btnExportMoviesStart = new System.Windows.Forms.Button();
            this.btnMovieExportStop = new System.Windows.Forms.Button();
            this.txtFileMovie = new System.Windows.Forms.TextBox();
            this.btnSelectExportSessions = new System.Windows.Forms.Button();
            this.btnExportSessionsStart = new System.Windows.Forms.Button();
            this.btnExportSessionStop = new System.Windows.Forms.Button();
            this.txtFileSession = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileBooking = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectExportMovies
            // 
            this.btnSelectExportMovies.Location = new System.Drawing.Point(57, 586);
            this.btnSelectExportMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectExportMovies.Name = "btnSelectExportMovies";
            this.btnSelectExportMovies.Size = new System.Drawing.Size(268, 35);
            this.btnSelectExportMovies.TabIndex = 0;
            this.btnSelectExportMovies.Text = "Select File for Exporting Movies";
            this.btnSelectExportMovies.UseVisualStyleBackColor = true;
            this.btnSelectExportMovies.Visible = false;
            // 
            // btnExportMoviesStart
            // 
            this.btnExportMoviesStart.Location = new System.Drawing.Point(57, 671);
            this.btnExportMoviesStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportMoviesStart.Name = "btnExportMoviesStart";
            this.btnExportMoviesStart.Size = new System.Drawing.Size(112, 35);
            this.btnExportMoviesStart.TabIndex = 1;
            this.btnExportMoviesStart.Text = "Start";
            this.btnExportMoviesStart.UseVisualStyleBackColor = true;
            this.btnExportMoviesStart.Visible = false;
            // 
            // btnMovieExportStop
            // 
            this.btnMovieExportStop.Location = new System.Drawing.Point(57, 671);
            this.btnMovieExportStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovieExportStop.Name = "btnMovieExportStop";
            this.btnMovieExportStop.Size = new System.Drawing.Size(112, 35);
            this.btnMovieExportStop.TabIndex = 2;
            this.btnMovieExportStop.Text = "Stop";
            this.btnMovieExportStop.UseVisualStyleBackColor = true;
            this.btnMovieExportStop.Visible = false;
            // 
            // txtFileMovie
            // 
            this.txtFileMovie.Location = new System.Drawing.Point(57, 631);
            this.txtFileMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileMovie.Name = "txtFileMovie";
            this.txtFileMovie.Size = new System.Drawing.Size(361, 26);
            this.txtFileMovie.TabIndex = 3;
            this.txtFileMovie.Visible = false;
            // 
            // btnSelectExportSessions
            // 
            this.btnSelectExportSessions.Location = new System.Drawing.Point(57, 766);
            this.btnSelectExportSessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectExportSessions.Name = "btnSelectExportSessions";
            this.btnSelectExportSessions.Size = new System.Drawing.Size(268, 35);
            this.btnSelectExportSessions.TabIndex = 4;
            this.btnSelectExportSessions.Text = "Select File for Exporting Sessions";
            this.btnSelectExportSessions.UseVisualStyleBackColor = true;
            this.btnSelectExportSessions.Visible = false;
            // 
            // btnExportSessionsStart
            // 
            this.btnExportSessionsStart.Location = new System.Drawing.Point(57, 851);
            this.btnExportSessionsStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportSessionsStart.Name = "btnExportSessionsStart";
            this.btnExportSessionsStart.Size = new System.Drawing.Size(112, 35);
            this.btnExportSessionsStart.TabIndex = 5;
            this.btnExportSessionsStart.Text = "Start";
            this.btnExportSessionsStart.UseVisualStyleBackColor = true;
            this.btnExportSessionsStart.Visible = false;
            // 
            // btnExportSessionStop
            // 
            this.btnExportSessionStop.Location = new System.Drawing.Point(57, 851);
            this.btnExportSessionStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportSessionStop.Name = "btnExportSessionStop";
            this.btnExportSessionStop.Size = new System.Drawing.Size(112, 35);
            this.btnExportSessionStop.TabIndex = 6;
            this.btnExportSessionStop.Text = "Stop";
            this.btnExportSessionStop.UseVisualStyleBackColor = true;
            this.btnExportSessionStop.Visible = false;
            // 
            // txtFileSession
            // 
            this.txtFileSession.Location = new System.Drawing.Point(57, 811);
            this.txtFileSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileSession.Name = "txtFileSession";
            this.txtFileSession.Size = new System.Drawing.Size(361, 26);
            this.txtFileSession.TabIndex = 7;
            this.txtFileSession.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(483, 645);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(483, 811);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML|*.xml";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Save Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "From:";
            // 
            // txtFileBooking
            // 
            this.txtFileBooking.Location = new System.Drawing.Point(212, 23);
            this.txtFileBooking.Name = "txtFileBooking";
            this.txtFileBooking.Size = new System.Drawing.Size(350, 26);
            this.txtFileBooking.TabIndex = 12;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(627, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 32);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Export Bookings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "To:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(184, 121);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 17;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(533, 121);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 18;
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(823, 330);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFileSession);
            this.Controls.Add(this.btnExportSessionStop);
            this.Controls.Add(this.btnExportSessionsStart);
            this.Controls.Add(this.btnSelectExportSessions);
            this.Controls.Add(this.txtFileMovie);
            this.Controls.Add(this.btnMovieExportStop);
            this.Controls.Add(this.btnExportMoviesStart);
            this.Controls.Add(this.btnSelectExportMovies);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExportDataForm";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectExportMovies;
        private System.Windows.Forms.Button btnExportMoviesStart;
        private System.Windows.Forms.Button btnMovieExportStop;
        private System.Windows.Forms.TextBox txtFileMovie;
        private System.Windows.Forms.Button btnSelectExportSessions;
        private System.Windows.Forms.Button btnExportSessionsStart;
        private System.Windows.Forms.Button btnExportSessionStop;
        private System.Windows.Forms.TextBox txtFileSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}