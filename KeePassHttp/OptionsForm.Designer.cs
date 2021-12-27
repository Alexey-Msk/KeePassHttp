namespace KeePassHttp
{
	partial class OptionsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.SortByUsernameRadioButton = new System.Windows.Forms.RadioButton();
			this.SortByTitleRadioButton = new System.Windows.Forms.RadioButton();
			this.hideExpiredCheckbox = new System.Windows.Forms.CheckBox();
			this.matchSchemesCheckbox = new System.Windows.Forms.CheckBox();
			this.removePermissionsButton = new System.Windows.Forms.Button();
			this.unlockDatabaseCheckbox = new System.Windows.Forms.CheckBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.credMatchingCheckbox = new System.Windows.Forms.CheckBox();
			this.credNotifyCheckbox = new System.Windows.Forms.CheckBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.returnStringFieldsWithKphOnlyCheckBox = new System.Windows.Forms.CheckBox();
			this.hostName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.portNumber = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.returnStringFieldsCheckbox = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.credSearchInAllOpenedDatabases = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.credAllowUpdatesCheckbox = new System.Windows.Forms.CheckBox();
			this.credAllowAccessCheckbox = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.portNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			resources.ApplyResources(this.cancelButton, "cancelButton");
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			resources.ApplyResources(this.okButton, "okButton");
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Name = "okButton";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tabPage1
			// 
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Controls.Add(this.SortByUsernameRadioButton);
			this.tabPage1.Controls.Add(this.SortByTitleRadioButton);
			this.tabPage1.Controls.Add(this.hideExpiredCheckbox);
			this.tabPage1.Controls.Add(this.matchSchemesCheckbox);
			this.tabPage1.Controls.Add(this.removePermissionsButton);
			this.tabPage1.Controls.Add(this.unlockDatabaseCheckbox);
			this.tabPage1.Controls.Add(this.removeButton);
			this.tabPage1.Controls.Add(this.credMatchingCheckbox);
			this.tabPage1.Controls.Add(this.credNotifyCheckbox);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// SortByUsernameRadioButton
			// 
			resources.ApplyResources(this.SortByUsernameRadioButton, "SortByUsernameRadioButton");
			this.SortByUsernameRadioButton.Name = "SortByUsernameRadioButton";
			this.SortByUsernameRadioButton.TabStop = true;
			this.SortByUsernameRadioButton.UseVisualStyleBackColor = true;
			// 
			// SortByTitleRadioButton
			// 
			resources.ApplyResources(this.SortByTitleRadioButton, "SortByTitleRadioButton");
			this.SortByTitleRadioButton.Name = "SortByTitleRadioButton";
			this.SortByTitleRadioButton.TabStop = true;
			this.SortByTitleRadioButton.UseVisualStyleBackColor = true;
			// 
			// hideExpiredCheckbox
			// 
			resources.ApplyResources(this.hideExpiredCheckbox, "hideExpiredCheckbox");
			this.hideExpiredCheckbox.Name = "hideExpiredCheckbox";
			this.hideExpiredCheckbox.UseVisualStyleBackColor = true;
			// 
			// matchSchemesCheckbox
			// 
			resources.ApplyResources(this.matchSchemesCheckbox, "matchSchemesCheckbox");
			this.matchSchemesCheckbox.Name = "matchSchemesCheckbox";
			this.matchSchemesCheckbox.UseVisualStyleBackColor = true;
			// 
			// removePermissionsButton
			// 
			resources.ApplyResources(this.removePermissionsButton, "removePermissionsButton");
			this.removePermissionsButton.Name = "removePermissionsButton";
			this.removePermissionsButton.UseVisualStyleBackColor = true;
			this.removePermissionsButton.Click += new System.EventHandler(this.removePermissionsButton_Click);
			// 
			// unlockDatabaseCheckbox
			// 
			resources.ApplyResources(this.unlockDatabaseCheckbox, "unlockDatabaseCheckbox");
			this.unlockDatabaseCheckbox.Name = "unlockDatabaseCheckbox";
			this.unlockDatabaseCheckbox.UseVisualStyleBackColor = true;
			// 
			// removeButton
			// 
			resources.ApplyResources(this.removeButton, "removeButton");
			this.removeButton.Name = "removeButton";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// credMatchingCheckbox
			// 
			resources.ApplyResources(this.credMatchingCheckbox, "credMatchingCheckbox");
			this.credMatchingCheckbox.Name = "credMatchingCheckbox";
			this.credMatchingCheckbox.UseVisualStyleBackColor = true;
			// 
			// credNotifyCheckbox
			// 
			resources.ApplyResources(this.credNotifyCheckbox, "credNotifyCheckbox");
			this.credNotifyCheckbox.Name = "credNotifyCheckbox";
			this.credNotifyCheckbox.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Controls.Add(this.returnStringFieldsWithKphOnlyCheckBox);
			this.tabPage2.Controls.Add(this.hostName);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.portNumber);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.returnStringFieldsCheckbox);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.credSearchInAllOpenedDatabases);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.credAllowUpdatesCheckbox);
			this.tabPage2.Controls.Add(this.credAllowAccessCheckbox);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// returnStringFieldsWithKphOnlyCheckBox
			// 
			resources.ApplyResources(this.returnStringFieldsWithKphOnlyCheckBox, "returnStringFieldsWithKphOnlyCheckBox");
			this.returnStringFieldsWithKphOnlyCheckBox.Name = "returnStringFieldsWithKphOnlyCheckBox";
			this.returnStringFieldsWithKphOnlyCheckBox.UseVisualStyleBackColor = true;
			// 
			// hostName
			// 
			resources.ApplyResources(this.hostName, "hostName");
			this.hostName.Name = "hostName";
			this.hostName.TextChanged += new System.EventHandler(this.hostName_TextChanged);
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// portNumber
			// 
			resources.ApplyResources(this.portNumber, "portNumber");
			this.portNumber.Maximum = new decimal(new int[] {
			99999,
			0,
			0,
			0});
			this.portNumber.Minimum = new decimal(new int[] {
			1025,
			0,
			0,
			0});
			this.portNumber.Name = "portNumber";
			this.portNumber.Value = new decimal(new int[] {
			19455,
			0,
			0,
			0});
			this.portNumber.ValueChanged += new System.EventHandler(this.portNumber_ValueChanged);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// returnStringFieldsCheckbox
			// 
			resources.ApplyResources(this.returnStringFieldsCheckbox, "returnStringFieldsCheckbox");
			this.returnStringFieldsCheckbox.Name = "returnStringFieldsCheckbox";
			this.returnStringFieldsCheckbox.UseVisualStyleBackColor = true;
			this.returnStringFieldsCheckbox.CheckedChanged += new System.EventHandler(this.returnStringFieldsCheckbox_CheckedChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// credSearchInAllOpenedDatabases
			// 
			resources.ApplyResources(this.credSearchInAllOpenedDatabases, "credSearchInAllOpenedDatabases");
			this.credSearchInAllOpenedDatabases.Name = "credSearchInAllOpenedDatabases";
			this.credSearchInAllOpenedDatabases.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Name = "label1";
			// 
			// credAllowUpdatesCheckbox
			// 
			resources.ApplyResources(this.credAllowUpdatesCheckbox, "credAllowUpdatesCheckbox");
			this.credAllowUpdatesCheckbox.Name = "credAllowUpdatesCheckbox";
			this.credAllowUpdatesCheckbox.UseVisualStyleBackColor = true;
			// 
			// credAllowAccessCheckbox
			// 
			resources.ApplyResources(this.credAllowAccessCheckbox, "credAllowAccessCheckbox");
			this.credAllowAccessCheckbox.Name = "credAllowAccessCheckbox";
			this.credAllowAccessCheckbox.UseVisualStyleBackColor = true;
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.okButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.portNumber)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.CheckBox hideExpiredCheckbox;
		private System.Windows.Forms.CheckBox matchSchemesCheckbox;
		private System.Windows.Forms.Button removePermissionsButton;
		private System.Windows.Forms.CheckBox unlockDatabaseCheckbox;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.CheckBox credMatchingCheckbox;
		private System.Windows.Forms.CheckBox credNotifyCheckbox;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox credSearchInAllOpenedDatabases;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox credAllowUpdatesCheckbox;
		private System.Windows.Forms.CheckBox credAllowAccessCheckbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox returnStringFieldsCheckbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton SortByUsernameRadioButton;
		private System.Windows.Forms.RadioButton SortByTitleRadioButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown portNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox hostName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox returnStringFieldsWithKphOnlyCheckBox;
	}
}