/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 5/22/2014
 * Time: 3:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImgONE
{
	partial class frm_About
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
            this.label_motto = new System.Windows.Forms.Label();
            this.btn_github = new System.Windows.Forms.Button();
            this.label_build = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_motto
            // 
            this.label_motto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_motto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_motto.Location = new System.Drawing.Point(71, 125);
            this.label_motto.Name = "label_motto";
            this.label_motto.Size = new System.Drawing.Size(378, 23);
            this.label_motto.TabIndex = 1;
            this.label_motto.Text = "Simple, fast image sharing!";
            this.label_motto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_github
            // 
            this.btn_github.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_github.Location = new System.Drawing.Point(352, 160);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(97, 26);
            this.btn_github.TabIndex = 2;
            this.btn_github.Text = "Official Website";
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.Btn_githubClick);
            // 
            // label_build
            // 
            this.label_build.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_build.Location = new System.Drawing.Point(71, 161);
            this.label_build.Name = "label_build";
            this.label_build.Size = new System.Drawing.Size(88, 26);
            this.label_build.TabIndex = 3;
            this.label_build.Text = "Build: 0";
            this.label_build.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_report
            // 
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_report.Location = new System.Drawing.Point(249, 161);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(97, 26);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "WebmasterONE";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.Btn_reportClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImgONE.Properties.Resources.imgone1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 110);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 197);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.label_build);
            this.Controls.Add(this.btn_github);
            this.Controls.Add(this.label_motto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About ImgONE";
            this.Load += new System.EventHandler(this.Frm_AboutLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label_build;
        private System.Windows.Forms.Button btn_report;
		private System.Windows.Forms.Label label_motto;
		private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
