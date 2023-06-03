namespace AutoUpdaterDotNET
{
	partial class RemindLaterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindLaterForm));
			labelDescription = new ReaLTaiizor.Controls.PoisonLabel();
			radioButtonYes = new ReaLTaiizor.Controls.PoisonRadioButton();
			radioButtonNo = new ReaLTaiizor.Controls.PoisonRadioButton();
			comboBoxRemindLater = new ReaLTaiizor.Controls.PoisonComboBox();
			buttonOK = new ReaLTaiizor.Controls.PoisonButton();
			tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			pictureBoxIcon = new System.Windows.Forms.PictureBox();
			labelTitle = new ReaLTaiizor.Controls.PoisonLabel();
			poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(components);
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).BeginInit();
			SuspendLayout();
			// 
			// labelDescription
			// 
			resources.ApplyResources(labelDescription, "labelDescription");
			tableLayoutPanel.SetColumnSpan(labelDescription, 2);
			labelDescription.Name = "labelDescription";
			// 
			// radioButtonYes
			// 
			resources.ApplyResources(radioButtonYes, "radioButtonYes");
			radioButtonYes.Checked = true;
			radioButtonYes.Name = "radioButtonYes";
			radioButtonYes.TabStop = true;
			radioButtonYes.UseSelectable = true;
			radioButtonYes.UseVisualStyleBackColor = true;
			radioButtonYes.CheckedChanged += RadioButtonYesCheckedChanged;
			// 
			// radioButtonNo
			// 
			resources.ApplyResources(radioButtonNo, "radioButtonNo");
			tableLayoutPanel.SetColumnSpan(radioButtonNo, 2);
			radioButtonNo.Name = "radioButtonNo";
			radioButtonNo.UseSelectable = true;
			radioButtonNo.UseVisualStyleBackColor = true;
			// 
			// comboBoxRemindLater
			// 
			resources.ApplyResources(comboBoxRemindLater, "comboBoxRemindLater");
			comboBoxRemindLater.FormattingEnabled = true;
			comboBoxRemindLater.Items.AddRange(new object[] { resources.GetString("comboBoxRemindLater.Items"), resources.GetString("comboBoxRemindLater.Items1"), resources.GetString("comboBoxRemindLater.Items2"), resources.GetString("comboBoxRemindLater.Items3"), resources.GetString("comboBoxRemindLater.Items4"), resources.GetString("comboBoxRemindLater.Items5"), resources.GetString("comboBoxRemindLater.Items6") });
			comboBoxRemindLater.Name = "comboBoxRemindLater";
			comboBoxRemindLater.UseSelectable = true;
			// 
			// buttonOK
			// 
			buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			resources.ApplyResources(buttonOK, "buttonOK");
			buttonOK.Name = "buttonOK";
			buttonOK.UseSelectable = true;
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += ButtonOkClick;
			// 
			// tableLayoutPanel
			// 
			resources.ApplyResources(tableLayoutPanel, "tableLayoutPanel");
			tableLayoutPanel.Controls.Add(pictureBoxIcon, 0, 0);
			tableLayoutPanel.Controls.Add(labelTitle, 1, 0);
			tableLayoutPanel.Controls.Add(radioButtonNo, 1, 3);
			tableLayoutPanel.Controls.Add(comboBoxRemindLater, 2, 2);
			tableLayoutPanel.Controls.Add(radioButtonYes, 1, 2);
			tableLayoutPanel.Controls.Add(labelDescription, 1, 1);
			tableLayoutPanel.Controls.Add(buttonOK, 2, 4);
			tableLayoutPanel.Name = "tableLayoutPanel";
			// 
			// pictureBoxIcon
			// 
			resources.ApplyResources(pictureBoxIcon, "pictureBoxIcon");
			pictureBoxIcon.Image = Properties.Resources.clock_go_32;
			pictureBoxIcon.Name = "pictureBoxIcon";
			tableLayoutPanel.SetRowSpan(pictureBoxIcon, 2);
			pictureBoxIcon.TabStop = false;
			// 
			// labelTitle
			// 
			resources.ApplyResources(labelTitle, "labelTitle");
			tableLayoutPanel.SetColumnSpan(labelTitle, 2);
			labelTitle.Name = "labelTitle";
			// 
			// poisonStyleManager
			// 
			poisonStyleManager.Owner = null;
			// 
			// RemindLaterForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackImage = Properties.Resources.clock_go_32;
			BackImagePadding = new System.Windows.Forms.Padding(510, 24, 0, 0);
			BackMaxSize = 32;
			Controls.Add(tableLayoutPanel);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "RemindLaterForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StyleManager = poisonStyleManager;
			Load += RemindLaterFormLoad;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)poisonStyleManager).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private ReaLTaiizor.Controls.PoisonLabel labelDescription;
		private ReaLTaiizor.Controls.PoisonRadioButton radioButtonYes;
		private ReaLTaiizor.Controls.PoisonRadioButton radioButtonNo;
		private ReaLTaiizor.Controls.PoisonComboBox comboBoxRemindLater;
		private ReaLTaiizor.Controls.PoisonButton buttonOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private ReaLTaiizor.Controls.PoisonLabel labelTitle;
		private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager;
	}
}