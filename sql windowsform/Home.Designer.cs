namespace sql_windowsform
{
    partial class Home
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
            this.registration_tile = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.update_tile = new MetroFramework.Controls.MetroTile();
            this.Delete_tile = new MetroFramework.Controls.MetroTile();
            this.display_tile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // registration_tile
            // 
            this.registration_tile.ActiveControl = null;
            this.registration_tile.Location = new System.Drawing.Point(221, 149);
            this.registration_tile.Name = "registration_tile";
            this.registration_tile.Size = new System.Drawing.Size(170, 79);
            this.registration_tile.TabIndex = 0;
            this.registration_tile.Text = "Registration";
            this.registration_tile.UseSelectable = true;
            this.registration_tile.Click += new System.EventHandler(this.registration_tile_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Location = new System.Drawing.Point(418, 149);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // update_tile
            // 
            this.update_tile.ActiveControl = null;
            this.update_tile.Location = new System.Drawing.Point(499, 149);
            this.update_tile.Name = "update_tile";
            this.update_tile.Size = new System.Drawing.Size(159, 79);
            this.update_tile.TabIndex = 2;
            this.update_tile.Text = "Update Client";
            this.update_tile.UseSelectable = true;
            this.update_tile.Click += new System.EventHandler(this.update_tile_Click);
            // 
            // Delete_tile
            // 
            this.Delete_tile.ActiveControl = null;
            this.Delete_tile.Location = new System.Drawing.Point(221, 276);
            this.Delete_tile.Name = "Delete_tile";
            this.Delete_tile.Size = new System.Drawing.Size(170, 75);
            this.Delete_tile.TabIndex = 3;
            this.Delete_tile.Text = "Delete Client";
            this.Delete_tile.UseSelectable = true;
            this.Delete_tile.Click += new System.EventHandler(this.Delete_tile_Click);
            // 
            // display_tile
            // 
            this.display_tile.ActiveControl = null;
            this.display_tile.Location = new System.Drawing.Point(499, 276);
            this.display_tile.Name = "display_tile";
            this.display_tile.Size = new System.Drawing.Size(159, 75);
            this.display_tile.TabIndex = 4;
            this.display_tile.Text = "Display Client";
            this.display_tile.UseSelectable = true;
            this.display_tile.Click += new System.EventHandler(this.display_tile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 546);
            this.Controls.Add(this.display_tile);
            this.Controls.Add(this.Delete_tile);
            this.Controls.Add(this.update_tile);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.registration_tile);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile registration_tile;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTile update_tile;
        private MetroFramework.Controls.MetroTile Delete_tile;
        private MetroFramework.Controls.MetroTile display_tile;
    }
}

