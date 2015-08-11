namespace chromium_updater_sharp.gui
{
	partial class MainWindow
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
				TrayIcon.Dispose();
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
			this.LocalBuildLabel = new System.Windows.Forms.Label();
			this.RemoteBuildLabel = new System.Windows.Forms.Label();
			this.SchedulerGroup = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.CheckLabel = new System.Windows.Forms.Label();
			this.TimeFreq = new System.Windows.Forms.ComboBox();
			this.UpdateRadio = new System.Windows.Forms.RadioButton();
			this.NotifyRadio = new System.Windows.Forms.RadioButton();
			this.CheckRadio = new System.Windows.Forms.RadioButton();
			this.StartupGroup = new System.Windows.Forms.GroupBox();
			this.StartBootCheck = new System.Windows.Forms.CheckBox();
			this.FoldersGroup = new System.Windows.Forms.GroupBox();
			this.UserDirButton = new System.Windows.Forms.Button();
			this.InstallDirButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.LocalBuildNumberLabel = new System.Windows.Forms.Label();
			this.RemoteBuildNumberLabel = new System.Windows.Forms.Label();
			this.SchedulerGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.StartupGroup.SuspendLayout();
			this.FoldersGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// LocalBuildLabel
			// 
			this.LocalBuildLabel.AutoSize = true;
			this.LocalBuildLabel.Location = new System.Drawing.Point(12, 9);
			this.LocalBuildLabel.Name = "LocalBuildLabel";
			this.LocalBuildLabel.Size = new System.Drawing.Size(79, 13);
			this.LocalBuildLabel.TabIndex = 1;
			this.LocalBuildLabel.Text = "Installed build:";
			// 
			// RemoteBuildLabel
			// 
			this.RemoteBuildLabel.AutoSize = true;
			this.RemoteBuildLabel.Location = new System.Drawing.Point(12, 22);
			this.RemoteBuildLabel.Name = "RemoteBuildLabel";
			this.RemoteBuildLabel.Size = new System.Drawing.Size(67, 13);
			this.RemoteBuildLabel.TabIndex = 2;
			this.RemoteBuildLabel.Text = "Latest build:";
			// 
			// SchedulerGroup
			// 
			this.SchedulerGroup.Controls.Add(this.groupBox1);
			this.SchedulerGroup.Controls.Add(this.CheckLabel);
			this.SchedulerGroup.Controls.Add(this.TimeFreq);
			this.SchedulerGroup.Controls.Add(this.UpdateRadio);
			this.SchedulerGroup.Controls.Add(this.NotifyRadio);
			this.SchedulerGroup.Controls.Add(this.CheckRadio);
			this.SchedulerGroup.Location = new System.Drawing.Point(12, 38);
			this.SchedulerGroup.Name = "SchedulerGroup";
			this.SchedulerGroup.Size = new System.Drawing.Size(202, 186);
			this.SchedulerGroup.TabIndex = 3;
			this.SchedulerGroup.TabStop = false;
			this.SchedulerGroup.Text = "Scheduler";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(6, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(190, 65);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Extra Chrome Plugins";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 42);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(85, 17);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "PDF Viewer";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(88, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Adobe Flash";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// CheckLabel
			// 
			this.CheckLabel.AutoSize = true;
			this.CheckLabel.Location = new System.Drawing.Point(6, 91);
			this.CheckLabel.Name = "CheckLabel";
			this.CheckLabel.Size = new System.Drawing.Size(73, 13);
			this.CheckLabel.TabIndex = 5;
			this.CheckLabel.Text = "Check every:";
			// 
			// TimeFreq
			// 
			this.TimeFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TimeFreq.FormattingEnabled = true;
			this.TimeFreq.Location = new System.Drawing.Point(85, 88);
			this.TimeFreq.Name = "TimeFreq";
			this.TimeFreq.Size = new System.Drawing.Size(78, 21);
			this.TimeFreq.TabIndex = 4;
			// 
			// UpdateRadio
			// 
			this.UpdateRadio.AutoSize = true;
			this.UpdateRadio.Location = new System.Drawing.Point(6, 65);
			this.UpdateRadio.Name = "UpdateRadio";
			this.UpdateRadio.Size = new System.Drawing.Size(190, 17);
			this.UpdateRadio.TabIndex = 2;
			this.UpdateRadio.TabStop = true;
			this.UpdateRadio.Text = "Automatically update to new build";
			this.UpdateRadio.UseVisualStyleBackColor = true;
			// 
			// NotifyRadio
			// 
			this.NotifyRadio.AutoSize = true;
			this.NotifyRadio.Location = new System.Drawing.Point(6, 42);
			this.NotifyRadio.Name = "NotifyRadio";
			this.NotifyRadio.Size = new System.Drawing.Size(173, 17);
			this.NotifyRadio.TabIndex = 1;
			this.NotifyRadio.TabStop = true;
			this.NotifyRadio.Text = "Notify if new build is available";
			this.NotifyRadio.UseVisualStyleBackColor = true;
			// 
			// CheckRadio
			// 
			this.CheckRadio.AutoSize = true;
			this.CheckRadio.Location = new System.Drawing.Point(6, 19);
			this.CheckRadio.Name = "CheckRadio";
			this.CheckRadio.Size = new System.Drawing.Size(155, 17);
			this.CheckRadio.TabIndex = 0;
			this.CheckRadio.TabStop = true;
			this.CheckRadio.Text = "Only check in background";
			this.CheckRadio.UseVisualStyleBackColor = true;
			// 
			// StartupGroup
			// 
			this.StartupGroup.Controls.Add(this.StartBootCheck);
			this.StartupGroup.Location = new System.Drawing.Point(12, 230);
			this.StartupGroup.Name = "StartupGroup";
			this.StartupGroup.Size = new System.Drawing.Size(202, 42);
			this.StartupGroup.TabIndex = 4;
			this.StartupGroup.TabStop = false;
			this.StartupGroup.Text = "Startup";
			// 
			// StartBootCheck
			// 
			this.StartBootCheck.AutoSize = true;
			this.StartBootCheck.Location = new System.Drawing.Point(9, 19);
			this.StartBootCheck.Name = "StartBootCheck";
			this.StartBootCheck.Size = new System.Drawing.Size(157, 17);
			this.StartBootCheck.TabIndex = 0;
			this.StartBootCheck.Text = "Start when Windows starts";
			this.StartBootCheck.UseVisualStyleBackColor = true;
			// 
			// FoldersGroup
			// 
			this.FoldersGroup.Controls.Add(this.UserDirButton);
			this.FoldersGroup.Controls.Add(this.InstallDirButton);
			this.FoldersGroup.Location = new System.Drawing.Point(12, 278);
			this.FoldersGroup.Name = "FoldersGroup";
			this.FoldersGroup.Size = new System.Drawing.Size(202, 48);
			this.FoldersGroup.TabIndex = 5;
			this.FoldersGroup.TabStop = false;
			this.FoldersGroup.Text = "Chromium Folders";
			// 
			// UserDirButton
			// 
			this.UserDirButton.Location = new System.Drawing.Point(104, 19);
			this.UserDirButton.Name = "UserDirButton";
			this.UserDirButton.Size = new System.Drawing.Size(92, 23);
			this.UserDirButton.TabIndex = 1;
			this.UserDirButton.Text = "User Data";
			this.UserDirButton.UseVisualStyleBackColor = true;
			this.UserDirButton.Click += new System.EventHandler(this.ButtonClick);
			// 
			// InstallDirButton
			// 
			this.InstallDirButton.Location = new System.Drawing.Point(6, 19);
			this.InstallDirButton.Name = "InstallDirButton";
			this.InstallDirButton.Size = new System.Drawing.Size(92, 23);
			this.InstallDirButton.TabIndex = 0;
			this.InstallDirButton.Text = "Install Location";
			this.InstallDirButton.UseVisualStyleBackColor = true;
			this.InstallDirButton.Click += new System.EventHandler(this.ButtonClick);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(58, 332);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.ButtonClick);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(139, 332);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.ButtonClick);
			// 
			// LocalBuildNumberLabel
			// 
			this.LocalBuildNumberLabel.AutoSize = true;
			this.LocalBuildNumberLabel.Location = new System.Drawing.Point(87, 9);
			this.LocalBuildNumberLabel.Name = "LocalBuildNumberLabel";
			this.LocalBuildNumberLabel.Size = new System.Drawing.Size(13, 13);
			this.LocalBuildNumberLabel.TabIndex = 8;
			this.LocalBuildNumberLabel.Text = "0";
			// 
			// RemoteBuildNumberLabel
			// 
			this.RemoteBuildNumberLabel.AutoSize = true;
			this.RemoteBuildNumberLabel.Location = new System.Drawing.Point(75, 22);
			this.RemoteBuildNumberLabel.Name = "RemoteBuildNumberLabel";
			this.RemoteBuildNumberLabel.Size = new System.Drawing.Size(13, 13);
			this.RemoteBuildNumberLabel.TabIndex = 9;
			this.RemoteBuildNumberLabel.Text = "0";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 367);
			this.Controls.Add(this.RemoteBuildNumberLabel);
			this.Controls.Add(this.LocalBuildNumberLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.FoldersGroup);
			this.Controls.Add(this.StartupGroup);
			this.Controls.Add(this.SchedulerGroup);
			this.Controls.Add(this.RemoteBuildLabel);
			this.Controls.Add(this.LocalBuildLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = global::chromium_updater_sharp.Properties.Resources.chromium;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chromium Updater# Options";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.SchedulerGroup.ResumeLayout(false);
			this.SchedulerGroup.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.StartupGroup.ResumeLayout(false);
			this.StartupGroup.PerformLayout();
			this.FoldersGroup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LocalBuildLabel;
		private System.Windows.Forms.Label RemoteBuildLabel;
		private System.Windows.Forms.GroupBox SchedulerGroup;
		private System.Windows.Forms.Label CheckLabel;
		private System.Windows.Forms.ComboBox TimeFreq;
		private System.Windows.Forms.RadioButton UpdateRadio;
		private System.Windows.Forms.RadioButton NotifyRadio;
		private System.Windows.Forms.RadioButton CheckRadio;
		private System.Windows.Forms.GroupBox StartupGroup;
		private System.Windows.Forms.CheckBox StartBootCheck;
		private System.Windows.Forms.GroupBox FoldersGroup;
		private System.Windows.Forms.Button UserDirButton;
		private System.Windows.Forms.Button InstallDirButton;
		private System.Windows.Forms.Button SaveButton;
		private new System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		internal System.Windows.Forms.Label LocalBuildNumberLabel;
		internal System.Windows.Forms.Label RemoteBuildNumberLabel;
	}
}