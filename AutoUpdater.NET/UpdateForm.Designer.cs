﻿using System.Threading;

namespace AutoUpdaterDotNET
{
	sealed partial class UpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
			webBrowser = new System.Windows.Forms.WebBrowser();
			labelUpdate = new System.Windows.Forms.Label();
			labelDescription = new System.Windows.Forms.Label();
			labelReleaseNotes = new System.Windows.Forms.Label();
			buttonUpdate = new System.Windows.Forms.Button();
			buttonRemindLater = new System.Windows.Forms.Button();
			pictureBoxIcon = new System.Windows.Forms.PictureBox();
			buttonSkip = new System.Windows.Forms.Button();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
			metroStyleManager = new ReaLTaiizor.Manager.MetroStyleManager();
			((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
			SuspendLayout();
			// 
			// webBrowser
			// 
			resources.ApplyResources(webBrowser, "webBrowser");
			webBrowser.Name = "webBrowser";
			webBrowser.ScriptErrorsSuppressed = true;
			// 
			// labelUpdate
			// 
			resources.ApplyResources(labelUpdate, "labelUpdate");
			labelUpdate.Name = "labelUpdate";
			// 
			// labelDescription
			// 
			resources.ApplyResources(labelDescription, "labelDescription");
			labelDescription.Name = "labelDescription";
			// 
			// labelReleaseNotes
			// 
			resources.ApplyResources(labelReleaseNotes, "labelReleaseNotes");
			labelReleaseNotes.Name = "labelReleaseNotes";
			// 
			// buttonUpdate
			// 
			resources.ApplyResources(buttonUpdate, "buttonUpdate");
			buttonUpdate.Image = Properties.Resources.download;
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.UseVisualStyleBackColor = true;
			buttonUpdate.Click += ButtonUpdateClick;
			// 
			// buttonRemindLater
			// 
			resources.ApplyResources(buttonRemindLater, "buttonRemindLater");
			buttonRemindLater.Image = Properties.Resources.clock_go;
			buttonRemindLater.Name = "buttonRemindLater";
			buttonRemindLater.UseVisualStyleBackColor = true;
			buttonRemindLater.Click += ButtonRemindLaterClick;
			// 
			// pictureBoxIcon
			// 
			pictureBoxIcon.Image = Properties.Resources.update;
			resources.ApplyResources(pictureBoxIcon, "pictureBoxIcon");
			pictureBoxIcon.Name = "pictureBoxIcon";
			pictureBoxIcon.TabStop = false;
			// 
			// buttonSkip
			// 
			resources.ApplyResources(buttonSkip, "buttonSkip");
			buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
			buttonSkip.Image = Properties.Resources.hand_point;
			buttonSkip.Name = "buttonSkip";
			buttonSkip.UseVisualStyleBackColor = true;
			buttonSkip.Click += ButtonSkipClick;
			// 
			// webView2
			// 
			webView2.AllowExternalDrop = true;
			resources.ApplyResources(webView2, "webView2");
			webView2.CreationProperties = null;
			webView2.DefaultBackgroundColor = System.Drawing.Color.White;
			webView2.Name = "webView2";
			webView2.ZoomFactor = 1D;
			// 
			// metroStyleManager
			// 
			metroStyleManager.CustomTheme = "C:\\Users\\nefar\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
			metroStyleManager.OwnerForm = this;
			metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
			metroStyleManager.ThemeAuthor = "Taiizor";
			metroStyleManager.ThemeName = "MetroDark";
			// 
			// UpdateForm
			// 
			AcceptButton = buttonUpdate;
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
			Controls.Add(pictureBoxIcon);
			Controls.Add(labelReleaseNotes);
			Controls.Add(labelDescription);
			Controls.Add(labelUpdate);
			Controls.Add(buttonUpdate);
			Controls.Add(buttonSkip);
			Controls.Add(buttonRemindLater);
			Controls.Add(webView2);
			Controls.Add(webBrowser);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Name = "UpdateForm";
			Style = ReaLTaiizor.Enum.Metro.Style.Dark;
			StyleManager = metroStyleManager;
			TextColor = System.Drawing.Color.White;
			ThemeName = "MetroDark";
			FormClosing += UpdateForm_FormClosing;
			FormClosed += UpdateForm_FormClosed;
			Load += UpdateFormLoad;
			((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button buttonRemindLater;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonSkip;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Label labelUpdate;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelReleaseNotes;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
		private ReaLTaiizor.Manager.MetroStyleManager metroStyleManager;
	}
}