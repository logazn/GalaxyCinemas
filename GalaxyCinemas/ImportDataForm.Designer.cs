namespace GalaxyCinemas
{
    partial class ImportDataForm
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
            this.btnMovieImportStart = new System.Windows.Forms.Button();
            this.btnMovieImportStop = new System.Windows.Forms.Button();
            this.btnSelectMovieFile = new System.Windows.Forms.Button();
            this.opnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtMovieFileName = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.btnSessStop = new System.Windows.Forms.Button();
            this.btnSessImport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovieImportStart
            // 
            this.btnMovieImportStart.Location = new System.Drawing.Point(20, 101);
            this.btnMovieImportStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovieImportStart.Name = "btnMovieImportStart";
            this.btnMovieImportStart.Size = new System.Drawing.Size(112, 35);
            this.btnMovieImportStart.TabIndex = 0;
            this.btnMovieImportStart.Text = "Import";
            this.btnMovieImportStart.UseVisualStyleBackColor = true;
            this.btnMovieImportStart.Click += new System.EventHandler(this.btnMovieImportStart_Click);
            // 
            // btnMovieImportStop
            // 
            this.btnMovieImportStop.CausesValidation = false;
            this.btnMovieImportStop.Location = new System.Drawing.Point(20, 101);
            this.btnMovieImportStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovieImportStop.Name = "btnMovieImportStop";
            this.btnMovieImportStop.Size = new System.Drawing.Size(112, 35);
            this.btnMovieImportStop.TabIndex = 1;
            this.btnMovieImportStop.Text = "Stop";
            this.btnMovieImportStop.UseVisualStyleBackColor = true;
            this.btnMovieImportStop.Visible = false;
            this.btnMovieImportStop.Click += new System.EventHandler(this.btnMovieImportStop_Click);
            // 
            // btnSelectMovieFile
            // 
            this.btnSelectMovieFile.CausesValidation = false;
            this.btnSelectMovieFile.Location = new System.Drawing.Point(20, 20);
            this.btnSelectMovieFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectMovieFile.Name = "btnSelectMovieFile";
            this.btnSelectMovieFile.Size = new System.Drawing.Size(228, 35);
            this.btnSelectMovieFile.TabIndex = 3;
            this.btnSelectMovieFile.Text = "Select Movie File";
            this.btnSelectMovieFile.UseVisualStyleBackColor = true;
            this.btnSelectMovieFile.Click += new System.EventHandler(this.btnSelectMovieFile_Click);
            // 
            // txtMovieFileName
            // 
            this.txtMovieFileName.Location = new System.Drawing.Point(20, 65);
            this.txtMovieFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMovieFileName.Name = "txtMovieFileName";
            this.txtMovieFileName.Size = new System.Drawing.Size(481, 26);
            this.txtMovieFileName.TabIndex = 4;
            this.txtMovieFileName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMovieFileName_Validating);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(136, 563);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 35);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(20, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Session File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(20, 296);
            this.txtSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(481, 26);
            this.txtSession.TabIndex = 7;
            // 
            // btnSessStop
            // 
            this.btnSessStop.CausesValidation = false;
            this.btnSessStop.Location = new System.Drawing.Point(20, 369);
            this.btnSessStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSessStop.Name = "btnSessStop";
            this.btnSessStop.Size = new System.Drawing.Size(112, 35);
            this.btnSessStop.TabIndex = 8;
            this.btnSessStop.Text = "Stop";
            this.btnSessStop.UseVisualStyleBackColor = true;
            this.btnSessStop.Visible = false;
            // 
            // btnSessImport
            // 
            this.btnSessImport.Location = new System.Drawing.Point(20, 369);
            this.btnSessImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSessImport.Name = "btnSessImport";
            this.btnSessImport.Size = new System.Drawing.Size(112, 35);
            this.btnSessImport.TabIndex = 9;
            this.btnSessImport.Text = "Import";
            this.btnSessImport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSessStop);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtMovieFileName);
            this.Controls.Add(this.btnSelectMovieFile);
            this.Controls.Add(this.btnMovieImportStop);
            this.Controls.Add(this.btnMovieImportStart);
            this.Controls.Add(this.btnSessImport);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportDataForm";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.ImportDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovieImportStart;
        private System.Windows.Forms.Button btnMovieImportStop;
        private System.Windows.Forms.Button btnSelectMovieFile;
        private System.Windows.Forms.OpenFileDialog opnFileDialog;
        private System.Windows.Forms.TextBox txtMovieFileName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSessStop;
        private System.Windows.Forms.Button btnSessImport;
        private System.Windows.Forms.Button button2;
    }
}