namespace AutoUpdaterDotNET
{
	partial class DownloadUpdateDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadUpdateDialog));
			progressBar = new ReaLTaiizor.Controls.PoisonProgressBar();
			labelInformation = new ReaLTaiizor.Controls.PoisonLabel();
			labelSize = new ReaLTaiizor.Controls.PoisonLabel();
			poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
			SuspendLayout();
			// 
			// progressBar
			// 
			resources.ApplyResources(progressBar, "progressBar");
			progressBar.Name = "progressBar";
			// 
			// labelInformation
			// 
			resources.ApplyResources(labelInformation, "labelInformation");
			labelInformation.Name = "labelInformation";
			// 
			// labelSize
			// 
			resources.ApplyResources(labelSize, "labelSize");
			labelSize.Name = "labelSize";
			// 
			// poisonStyleManager
			// 
			poisonStyleManager.Owner = null;
			// 
			// DownloadUpdateDialog
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackImage = Properties.Resources.download_32;
			BackImagePadding = new System.Windows.Forms.Padding(360, 20, 0, 0);
			BackMaxSize = 32;
			Controls.Add(labelSize);
			Controls.Add(labelInformation);
			Controls.Add(progressBar);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DownloadUpdateDialog";
			ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.None;
			StyleManager = poisonStyleManager;
			FormClosing += DownloadUpdateDialog_FormClosing;
			Load += DownloadUpdateDialogLoad;
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ReaLTaiizor.Controls.PoisonProgressBar progressBar;
		private ReaLTaiizor.Controls.PoisonLabel labelInformation;
		private ReaLTaiizor.Controls.PoisonLabel labelSize;
		private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
	}
}