namespace WindowsUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnSettings = new FontAwesome.Sharp.IconButton();
            this.ibtnClient = new FontAwesome.Sharp.IconButton();
            this.ibtnCommunication = new FontAwesome.Sharp.IconButton();
            this.ibtnProgramming = new FontAwesome.Sharp.IconButton();
            this.ibtnGaming = new FontAwesome.Sharp.IconButton();
            this.ibtnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.maximize = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.exit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildform = new System.Windows.Forms.Label();
            this.iconCurrentChieldformIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChieldformIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panelMenu.Controls.Add(this.ibtnSettings);
            this.panelMenu.Controls.Add(this.ibtnClient);
            this.panelMenu.Controls.Add(this.ibtnCommunication);
            this.panelMenu.Controls.Add(this.ibtnProgramming);
            this.panelMenu.Controls.Add(this.ibtnGaming);
            this.panelMenu.Controls.Add(this.ibtnDashboard);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnSettings
            // 
            this.ibtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSettings.FlatAppearance.BorderSize = 0;
            this.ibtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSettings.IconSize = 32;
            this.ibtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSettings.Location = new System.Drawing.Point(0, 440);
            this.ibtnSettings.Name = "ibtnSettings";
            this.ibtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnSettings.Rotation = 0D;
            this.ibtnSettings.Size = new System.Drawing.Size(220, 60);
            this.ibtnSettings.TabIndex = 6;
            this.ibtnSettings.Text = "Settings";
            this.ibtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSettings.UseVisualStyleBackColor = true;
            this.ibtnSettings.Click += new System.EventHandler(this.ibtnSettings_Click);
            // 
            // ibtnClient
            // 
            this.ibtnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnClient.FlatAppearance.BorderSize = 0;
            this.ibtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnClient.IconChar = FontAwesome.Sharp.IconChar.SteamSymbol;
            this.ibtnClient.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClient.IconSize = 32;
            this.ibtnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClient.Location = new System.Drawing.Point(0, 380);
            this.ibtnClient.Name = "ibtnClient";
            this.ibtnClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnClient.Rotation = 0D;
            this.ibtnClient.Size = new System.Drawing.Size(220, 60);
            this.ibtnClient.TabIndex = 5;
            this.ibtnClient.Text = "Clienten";
            this.ibtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnClient.UseVisualStyleBackColor = true;
            this.ibtnClient.Click += new System.EventHandler(this.ibtnClient_Click);
            // 
            // ibtnCommunication
            // 
            this.ibtnCommunication.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCommunication.FlatAppearance.BorderSize = 0;
            this.ibtnCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCommunication.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCommunication.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnCommunication.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnCommunication.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnCommunication.IconSize = 32;
            this.ibtnCommunication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCommunication.Location = new System.Drawing.Point(0, 320);
            this.ibtnCommunication.Name = "ibtnCommunication";
            this.ibtnCommunication.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnCommunication.Rotation = 0D;
            this.ibtnCommunication.Size = new System.Drawing.Size(220, 60);
            this.ibtnCommunication.TabIndex = 4;
            this.ibtnCommunication.Text = "Communication";
            this.ibtnCommunication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCommunication.UseVisualStyleBackColor = true;
            this.ibtnCommunication.Click += new System.EventHandler(this.ibtnCommunication_Click);
            // 
            // ibtnProgramming
            // 
            this.ibtnProgramming.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnProgramming.FlatAppearance.BorderSize = 0;
            this.ibtnProgramming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProgramming.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnProgramming.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnProgramming.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.ibtnProgramming.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnProgramming.IconSize = 32;
            this.ibtnProgramming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProgramming.Location = new System.Drawing.Point(0, 260);
            this.ibtnProgramming.Name = "ibtnProgramming";
            this.ibtnProgramming.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnProgramming.Rotation = 0D;
            this.ibtnProgramming.Size = new System.Drawing.Size(220, 60);
            this.ibtnProgramming.TabIndex = 3;
            this.ibtnProgramming.Text = "Programming";
            this.ibtnProgramming.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProgramming.UseVisualStyleBackColor = true;
            this.ibtnProgramming.Click += new System.EventHandler(this.ibtnProgramming_Click);
            // 
            // ibtnGaming
            // 
            this.ibtnGaming.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGaming.FlatAppearance.BorderSize = 0;
            this.ibtnGaming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGaming.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnGaming.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnGaming.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.ibtnGaming.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnGaming.IconSize = 32;
            this.ibtnGaming.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGaming.Location = new System.Drawing.Point(0, 200);
            this.ibtnGaming.Name = "ibtnGaming";
            this.ibtnGaming.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnGaming.Rotation = 0D;
            this.ibtnGaming.Size = new System.Drawing.Size(220, 60);
            this.ibtnGaming.TabIndex = 2;
            this.ibtnGaming.Text = "Gaming";
            this.ibtnGaming.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnGaming.UseVisualStyleBackColor = true;
            this.ibtnGaming.Click += new System.EventHandler(this.ibtnGaming_Click);
            // 
            // ibtnDashboard
            // 
            this.ibtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDashboard.FlatAppearance.BorderSize = 0;
            this.ibtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ibtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDashboard.IconSize = 32;
            this.ibtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDashboard.Location = new System.Drawing.Point(0, 140);
            this.ibtnDashboard.Name = "ibtnDashboard";
            this.ibtnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnDashboard.Rotation = 0D;
            this.ibtnDashboard.Size = new System.Drawing.Size(220, 60);
            this.ibtnDashboard.TabIndex = 1;
            this.ibtnDashboard.Text = "Dashboard";
            this.ibtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDashboard.UseVisualStyleBackColor = true;
            this.ibtnDashboard.Click += new System.EventHandler(this.ibtnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsUI.Properties.Resources.phoenix_fire_mascot_logo;
            this.btnHome.Location = new System.Drawing.Point(28, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 96);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panelTitlebar.Controls.Add(this.maximize);
            this.panelTitlebar.Controls.Add(this.minimize);
            this.panelTitlebar.Controls.Add(this.exit);
            this.panelTitlebar.Controls.Add(this.lblTitleChildform);
            this.panelTitlebar.Controls.Add(this.iconCurrentChieldformIcon);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.ForeColor = System.Drawing.Color.HotPink;
            this.panelTitlebar.Location = new System.Drawing.Point(220, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(964, 75);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // maximize
            // 
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximize.ForeColor = System.Drawing.Color.Black;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize.IconColor = System.Drawing.Color.Black;
            this.maximize.IconSize = 24;
            this.maximize.Location = new System.Drawing.Point(907, 0);
            this.maximize.Name = "maximize";
            this.maximize.Rotation = 0D;
            this.maximize.Size = new System.Drawing.Size(29, 23);
            this.maximize.TabIndex = 4;
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.Color.Black;
            this.minimize.IconSize = 24;
            this.minimize.Location = new System.Drawing.Point(884, 0);
            this.minimize.Name = "minimize";
            this.minimize.Rotation = 0D;
            this.minimize.Size = new System.Drawing.Size(29, 23);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exit.IconColor = System.Drawing.Color.Black;
            this.exit.IconSize = 24;
            this.exit.Location = new System.Drawing.Point(932, 0);
            this.exit.Name = "exit";
            this.exit.Rotation = 0D;
            this.exit.Size = new System.Drawing.Size(29, 23);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblTitleChildform
            // 
            this.lblTitleChildform.AutoSize = true;
            this.lblTitleChildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildform.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitleChildform.Location = new System.Drawing.Point(64, 30);
            this.lblTitleChildform.Name = "lblTitleChildform";
            this.lblTitleChildform.Size = new System.Drawing.Size(45, 16);
            this.lblTitleChildform.TabIndex = 1;
            this.lblTitleChildform.Text = "Home";
            // 
            // iconCurrentChieldformIcon
            // 
            this.iconCurrentChieldformIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.iconCurrentChieldformIcon.ForeColor = System.Drawing.Color.Orchid;
            this.iconCurrentChieldformIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChieldformIcon.IconColor = System.Drawing.Color.Orchid;
            this.iconCurrentChieldformIcon.IconSize = 33;
            this.iconCurrentChieldformIcon.Location = new System.Drawing.Point(25, 20);
            this.iconCurrentChieldformIcon.Name = "iconCurrentChieldformIcon";
            this.iconCurrentChieldformIcon.Size = new System.Drawing.Size(33, 33);
            this.iconCurrentChieldformIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconCurrentChieldformIcon.TabIndex = 0;
            this.iconCurrentChieldformIcon.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelshadow.Location = new System.Drawing.Point(220, 75);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(964, 10);
            this.panelshadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 546);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1200, 670);
            this.MinimumSize = new System.Drawing.Size(1200, 670);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChieldformIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnSettings;
        private FontAwesome.Sharp.IconButton ibtnClient;
        private FontAwesome.Sharp.IconButton ibtnCommunication;
        private FontAwesome.Sharp.IconButton ibtnProgramming;
        private FontAwesome.Sharp.IconButton ibtnGaming;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChieldformIcon;
        private System.Windows.Forms.Label lblTitleChildform;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton exit;
        private FontAwesome.Sharp.IconButton maximize;
        private FontAwesome.Sharp.IconButton minimize;
    }
}

