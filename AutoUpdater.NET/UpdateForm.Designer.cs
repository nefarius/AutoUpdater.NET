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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
			webBrowser = new System.Windows.Forms.WebBrowser();
			labelDescription = new ReaLTaiizor.Controls.PoisonLabel();
			labelReleaseNotes = new ReaLTaiizor.Controls.PoisonLabel();
			buttonUpdate = new ReaLTaiizor.Controls.PoisonButton();
			buttonRemindLater = new ReaLTaiizor.Controls.PoisonButton();
			buttonSkip = new ReaLTaiizor.Controls.PoisonButton();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
			poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
			poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(components);
			((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
			SuspendLayout();
			// 
			// webBrowser
			// 
			resources.ApplyResources(webBrowser, "webBrowser");
			poisonStyleExtender.SetApplyPoisonTheme(webBrowser, true);
			webBrowser.Name = "webBrowser";
			webBrowser.ScriptErrorsSuppressed = true;
			// 
			// labelDescription
			// 
			resources.ApplyResources(labelDescription, "labelDescription");
			labelDescription.Name = "labelDescription";
			labelDescription.WrapToLine = true;
			// 
			// labelReleaseNotes
			// 
			resources.ApplyResources(labelReleaseNotes, "labelReleaseNotes");
			labelReleaseNotes.Name = "labelReleaseNotes";
			// 
			// buttonUpdate
			// 
			resources.ApplyResources(buttonUpdate, "buttonUpdate");
			buttonUpdate.Highlight = true;
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.UseSelectable = true;
			buttonUpdate.Click += ButtonUpdateClick;
			// 
			// buttonRemindLater
			// 
			resources.ApplyResources(buttonRemindLater, "buttonRemindLater");
			buttonRemindLater.Name = "buttonRemindLater";
			buttonRemindLater.UseSelectable = true;
			buttonRemindLater.Click += ButtonRemindLaterClick;
			// 
			// buttonSkip
			// 
			buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
			resources.ApplyResources(buttonSkip, "buttonSkip");
			buttonSkip.Name = "buttonSkip";
			buttonSkip.UseSelectable = true;
			buttonSkip.UseVisualStyleBackColor = true;
			buttonSkip.Click += ButtonSkipClick;
			// 
			// webView2
			// 
			webView2.AllowExternalDrop = true;
			resources.ApplyResources(webView2, "webView2");
			poisonStyleExtender.SetApplyPoisonTheme(webView2, true);
			webView2.CreationProperties = null;
			webView2.DefaultBackgroundColor = System.Drawing.Color.White;
			webView2.Name = "webView2";
			webView2.ZoomFactor = 1D;
			// 
			// poisonStyleManager
			// 
			poisonStyleManager.Owner = this;
			// 
			// UpdateForm
			// 
			AcceptButton = buttonUpdate;
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackImage = Properties.Resources.update;
			BackImagePadding = new System.Windows.Forms.Padding(580, 25, 0, 0);
			BackMaxSize = 50;
			Controls.Add(labelReleaseNotes);
			Controls.Add(labelDescription);
			Controls.Add(buttonUpdate);
			Controls.Add(buttonSkip);
			Controls.Add(buttonRemindLater);
			Controls.Add(webView2);
			Controls.Add(webBrowser);
			MaximizeBox = false;
			Name = "UpdateForm";
			ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.AeroShadow;
			StyleManager = poisonStyleManager;
			FormClosing += UpdateForm_FormClosing;
			FormClosed += UpdateForm_FormClosed;
			Load += UpdateFormLoad;
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.PoisonButton buttonRemindLater;
		private ReaLTaiizor.Controls.PoisonButton buttonUpdate;
		private ReaLTaiizor.Controls.PoisonButton buttonSkip;
		private System.Windows.Forms.WebBrowser webBrowser;
		private ReaLTaiizor.Controls.PoisonLabel labelDescription;
		private ReaLTaiizor.Controls.PoisonLabel labelReleaseNotes;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
		private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
		private ReaLTaiizor.Controls.PoisonStyleExtender poisonStyleExtender;
	}
}