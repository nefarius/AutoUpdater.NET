using System.Threading;

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
			labelUpdate = new ReaLTaiizor.Controls.MaterialLabel();
			labelDescription = new ReaLTaiizor.Controls.MaterialLabel();
			labelReleaseNotes = new ReaLTaiizor.Controls.MaterialLabel();
			buttonUpdate = new ReaLTaiizor.Controls.MaterialButton();
			buttonRemindLater = new ReaLTaiizor.Controls.MaterialButton();
			pictureBoxIcon = new System.Windows.Forms.PictureBox();
			buttonSkip = new ReaLTaiizor.Controls.MaterialButton();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
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
			labelUpdate.Depth = 0;
			labelUpdate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			labelUpdate.Name = "labelUpdate";
			// 
			// labelDescription
			// 
			resources.ApplyResources(labelDescription, "labelDescription");
			labelDescription.Depth = 0;
			labelDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			labelDescription.Name = "labelDescription";
			// 
			// labelReleaseNotes
			// 
			resources.ApplyResources(labelReleaseNotes, "labelReleaseNotes");
			labelReleaseNotes.Depth = 0;
			labelReleaseNotes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			labelReleaseNotes.Name = "labelReleaseNotes";
			// 
			// buttonUpdate
			// 
			resources.ApplyResources(buttonUpdate, "buttonUpdate");
			buttonUpdate.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
			buttonUpdate.Depth = 0;
			buttonUpdate.HighEmphasis = true;
			buttonUpdate.Icon = Properties.Resources.download;
			buttonUpdate.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
			buttonUpdate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
			buttonUpdate.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
			buttonUpdate.UseAccentColor = false;
			buttonUpdate.UseVisualStyleBackColor = true;
			buttonUpdate.Click += ButtonUpdateClick;
			// 
			// buttonRemindLater
			// 
			resources.ApplyResources(buttonRemindLater, "buttonRemindLater");
			buttonRemindLater.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
			buttonRemindLater.Depth = 0;
			buttonRemindLater.HighEmphasis = true;
			buttonRemindLater.Icon = Properties.Resources.clock_go;
			buttonRemindLater.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
			buttonRemindLater.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			buttonRemindLater.Name = "buttonRemindLater";
			buttonRemindLater.NoAccentTextColor = System.Drawing.Color.Empty;
			buttonRemindLater.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
			buttonRemindLater.UseAccentColor = false;
			buttonRemindLater.UseVisualStyleBackColor = true;
			buttonRemindLater.Click += ButtonRemindLaterClick;
			// 
			// pictureBoxIcon
			// 
			pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
			pictureBoxIcon.Image = Properties.Resources.update;
			resources.ApplyResources(pictureBoxIcon, "pictureBoxIcon");
			pictureBoxIcon.Name = "pictureBoxIcon";
			pictureBoxIcon.TabStop = false;
			// 
			// buttonSkip
			// 
			resources.ApplyResources(buttonSkip, "buttonSkip");
			buttonSkip.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
			buttonSkip.Depth = 0;
			buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
			buttonSkip.HighEmphasis = true;
			buttonSkip.Icon = Properties.Resources.hand_point;
			buttonSkip.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
			buttonSkip.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
			buttonSkip.Name = "buttonSkip";
			buttonSkip.NoAccentTextColor = System.Drawing.Color.Empty;
			buttonSkip.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
			buttonSkip.UseAccentColor = false;
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
			// UpdateForm
			// 
			AcceptButton = buttonUpdate;
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "UpdateForm";
			FormClosing += UpdateForm_FormClosing;
			FormClosed += UpdateForm_FormClosed;
			Load += UpdateFormLoad;
			((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.MaterialButton buttonRemindLater;
		private ReaLTaiizor.Controls.MaterialButton buttonUpdate;
		private ReaLTaiizor.Controls.MaterialButton buttonSkip;
		private System.Windows.Forms.WebBrowser webBrowser;
		private ReaLTaiizor.Controls.MaterialLabel labelUpdate;
		private ReaLTaiizor.Controls.MaterialLabel labelDescription;
		private ReaLTaiizor.Controls.MaterialLabel labelReleaseNotes;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
	}
}