namespace DownloadFile
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_savedin = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "لینک";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ذخیره در";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(30, 42);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(568, 20);
            this.txt_url.TabIndex = 2;
            // 
            // txt_savedin
            // 
            this.txt_savedin.Location = new System.Drawing.Point(122, 86);
            this.txt_savedin.Name = "txt_savedin";
            this.txt_savedin.ReadOnly = true;
            this.txt_savedin.Size = new System.Drawing.Size(476, 20);
            this.txt_savedin.TabIndex = 3;
            // 
            // btn_select
            // 
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_select.Location = new System.Drawing.Point(30, 84);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(86, 32);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "انتخاب";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_download
            // 
            this.btn_download.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_download.Location = new System.Drawing.Point(512, 121);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(86, 32);
            this.btn_download.TabIndex = 5;
            this.btn_download.Text = "دانلود فایل";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(568, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 215);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_savedin);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "فرم دانلود";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_savedin;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

