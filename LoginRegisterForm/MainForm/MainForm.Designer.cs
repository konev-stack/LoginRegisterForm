namespace Online_Bank_with_Database.Forms

{
    partial class MainForm
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chosenUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(577, 56);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(533, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "USER:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.chosenUsernameTextBox);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 101);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 353);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chosenUsernameTextBox
            // 
            // 
            // 
            // 
            this.chosenUsernameTextBox.CustomButton.Image = null;
            this.chosenUsernameTextBox.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.chosenUsernameTextBox.CustomButton.Name = "";
            this.chosenUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.chosenUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chosenUsernameTextBox.CustomButton.TabIndex = 1;
            this.chosenUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chosenUsernameTextBox.CustomButton.UseSelectable = true;
            this.chosenUsernameTextBox.CustomButton.Visible = false;
            this.chosenUsernameTextBox.Lines = new string[0];
            this.chosenUsernameTextBox.Location = new System.Drawing.Point(312, 36);
            this.chosenUsernameTextBox.MaxLength = 32767;
            this.chosenUsernameTextBox.Name = "chosenUsernameTextBox";
            this.chosenUsernameTextBox.PasswordChar = '\0';
            this.chosenUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chosenUsernameTextBox.SelectedText = "";
            this.chosenUsernameTextBox.SelectionLength = 0;
            this.chosenUsernameTextBox.SelectionStart = 0;
            this.chosenUsernameTextBox.ShortcutsEnabled = true;
            this.chosenUsernameTextBox.Size = new System.Drawing.Size(164, 23);
            this.chosenUsernameTextBox.TabIndex = 4;
            this.chosenUsernameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chosenUsernameTextBox.UseSelectable = true;
            this.chosenUsernameTextBox.Visible = false;
            this.chosenUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chosenUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(354, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Username:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Movable = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "MainForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox chosenUsernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}