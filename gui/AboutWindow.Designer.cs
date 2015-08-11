namespace chromium_updater_sharp.gui
{
	partial class AboutWindow
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
			this.AppIcon = new System.Windows.Forms.PictureBox();
			this.AppTitle = new System.Windows.Forms.Label();
			this.CreditLabel = new System.Windows.Forms.Label();
			this.LicenseLabel = new System.Windows.Forms.Label();
			this.LinkLabel = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// AppIcon
			// 
			this.AppIcon.Location = new System.Drawing.Point(107, 12);
			this.AppIcon.Name = "AppIcon";
			this.AppIcon.Size = new System.Drawing.Size(128, 128);
			this.AppIcon.TabIndex = 0;
			this.AppIcon.TabStop = false;
			// 
			// AppTitle
			// 
			this.AppTitle.AutoSize = true;
			this.AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AppTitle.Location = new System.Drawing.Point(76, 143);
			this.AppTitle.Name = "AppTitle";
			this.AppTitle.Size = new System.Drawing.Size(190, 84);
			this.AppTitle.TabIndex = 1;
			this.AppTitle.Text = "Chromium\r\nUpdater#";
			this.AppTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CreditLabel
			// 
			this.CreditLabel.Location = new System.Drawing.Point(12, 227);
			this.CreditLabel.Name = "CreditLabel";
			this.CreditLabel.Size = new System.Drawing.Size(318, 97);
			this.CreditLabel.TabIndex = 2;
			this.CreditLabel.Text = "©2012 Darrell Perks [plusperks]\r\n\r\n©2006-2012 The Chromium Authors\r\n(Original Chr" +
    "omium icon and name)\r\n\r\n©2001-2010 Mike Krueger, John Reilly\r\n(#ziplib library)";
			this.CreditLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LicenseLabel
			// 
			this.LicenseLabel.AutoSize = true;
			this.LicenseLabel.Location = new System.Drawing.Point(94, 324);
			this.LicenseLabel.Name = "LicenseLabel";
			this.LicenseLabel.Size = new System.Drawing.Size(86, 13);
			this.LicenseLabel.TabIndex = 3;
			this.LicenseLabel.Text = "Licensed under:";
			// 
			// LinkLabel
			// 
			this.LinkLabel.AutoSize = true;
			this.LinkLabel.Location = new System.Drawing.Point(176, 324);
			this.LinkLabel.Name = "LinkLabel";
			this.LinkLabel.Size = new System.Drawing.Size(72, 13);
			this.LinkLabel.TabIndex = 4;
			this.LinkLabel.TabStop = true;
			this.LinkLabel.Text = "GNU GPL v3";
			this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelLinkClicked);
			// 
			// AboutWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 346);
			this.Controls.Add(this.LinkLabel);
			this.Controls.Add(this.LicenseLabel);
			this.Controls.Add(this.CreditLabel);
			this.Controls.Add(this.AppTitle);
			this.Controls.Add(this.AppIcon);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutWindow";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.Load += new System.EventHandler(this.AboutWindowLoad);
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox AppIcon;
		private System.Windows.Forms.Label AppTitle;
		private System.Windows.Forms.Label CreditLabel;
		private System.Windows.Forms.Label LicenseLabel;
		private System.Windows.Forms.LinkLabel LinkLabel;
	}
}