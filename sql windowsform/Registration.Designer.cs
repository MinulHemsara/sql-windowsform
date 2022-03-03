namespace sql_windowsform
{
    partial class Registration
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.txt_age = new MetroFramework.Controls.MetroTextBox();
            this.txt_tp = new MetroFramework.Controls.MetroTextBox();
            this.date_picker = new MetroFramework.Controls.MetroDateTime();
            this.btn_register = new MetroFramework.Controls.MetroButton();
            this.btn_clr = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(133, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Client ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(130, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Client Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(133, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Client Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(130, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Client DOB";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(133, 315);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "CLient Age";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(133, 361);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 20);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Client TP";
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(340, 86);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(200, 23);
            this.txt_id.TabIndex = 6;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(340, 136);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(200, 23);
            this.txt_name.TabIndex = 7;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(340, 190);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(200, 23);
            this.txt_address.TabIndex = 8;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_address.Click += new System.EventHandler(this.txt_address_Click);
            // 
            // txt_age
            // 
            // 
            // 
            // 
            this.txt_age.CustomButton.Image = null;
            this.txt_age.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_age.CustomButton.Name = "";
            this.txt_age.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_age.CustomButton.TabIndex = 1;
            this.txt_age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_age.CustomButton.UseSelectable = true;
            this.txt_age.CustomButton.Visible = false;
            this.txt_age.Lines = new string[0];
            this.txt_age.Location = new System.Drawing.Point(340, 312);
            this.txt_age.MaxLength = 32767;
            this.txt_age.Name = "txt_age";
            this.txt_age.PasswordChar = '\0';
            this.txt_age.ReadOnly = true;
            this.txt_age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_age.SelectedText = "";
            this.txt_age.SelectionLength = 0;
            this.txt_age.SelectionStart = 0;
            this.txt_age.ShortcutsEnabled = true;
            this.txt_age.Size = new System.Drawing.Size(200, 23);
            this.txt_age.TabIndex = 9;
            this.txt_age.UseSelectable = true;
            this.txt_age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_age.Click += new System.EventHandler(this.txt_age_Click);
            // 
            // txt_tp
            // 
            // 
            // 
            // 
            this.txt_tp.CustomButton.Image = null;
            this.txt_tp.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_tp.CustomButton.Name = "";
            this.txt_tp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_tp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tp.CustomButton.TabIndex = 1;
            this.txt_tp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tp.CustomButton.UseSelectable = true;
            this.txt_tp.CustomButton.Visible = false;
            this.txt_tp.Lines = new string[0];
            this.txt_tp.Location = new System.Drawing.Point(340, 361);
            this.txt_tp.MaxLength = 32767;
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.PasswordChar = '\0';
            this.txt_tp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tp.SelectedText = "";
            this.txt_tp.SelectionLength = 0;
            this.txt_tp.SelectionStart = 0;
            this.txt_tp.ShortcutsEnabled = true;
            this.txt_tp.Size = new System.Drawing.Size(200, 23);
            this.txt_tp.TabIndex = 10;
            this.txt_tp.UseSelectable = true;
            this.txt_tp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_tp.Click += new System.EventHandler(this.txt_tp_Click);
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(340, 255);
            this.date_picker.MinimumSize = new System.Drawing.Size(0, 30);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 30);
            this.date_picker.TabIndex = 11;
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(195, 475);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(90, 34);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "Save";
            this.btn_register.UseSelectable = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(382, 475);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(79, 34);
            this.btn_clr.TabIndex = 13;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseSelectable = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(564, 475);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 34);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 611);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.txt_tp);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroTextBox txt_age;
        private MetroFramework.Controls.MetroTextBox txt_tp;
        private MetroFramework.Controls.MetroDateTime date_picker;
        private MetroFramework.Controls.MetroButton btn_register;
        private MetroFramework.Controls.MetroButton btn_clr;
        private MetroFramework.Controls.MetroButton btn_exit;
    }
}