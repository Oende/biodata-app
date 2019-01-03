namespace AppBiodata
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.SidePanel = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnNotification = new System.Windows.Forms.Button();
			this.btnLinkedin = new System.Windows.Forms.Button();
			this.btnInstagram = new System.Windows.Forms.Button();
			this.btnGithub = new System.Windows.Forms.Button();
			this.btnFacebook = new System.Windows.Forms.Button();
			this.addBiodataControl1 = new AppBiodata.AddBiodataControl();
			this.aboutControl1 = new AppBiodata.AboutControl();
			this.homeControl1 = new AppBiodata.HomeControl();
			this.viewBiodataControl1 = new AppBiodata.ViewBiodataControl();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.SidePanel);
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnAbout);
			this.panel1.Controls.Add(this.btnView);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnHome);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 381);
			this.panel1.TabIndex = 0;
			// 
			// SidePanel
			// 
			this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.SidePanel.Location = new System.Drawing.Point(0, 11);
			this.SidePanel.Name = "SidePanel";
			this.SidePanel.Size = new System.Drawing.Size(10, 66);
			this.SidePanel.TabIndex = 6;
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Image = global::AppBiodata.Properties.Resources.exit_25;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(-1, 275);
			this.btnExit.Name = "btnExit";
			this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnExit.Size = new System.Drawing.Size(160, 66);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "   Exit";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbout.FlatAppearance.BorderSize = 0;
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbout.ForeColor = System.Drawing.Color.White;
			this.btnAbout.Image = global::AppBiodata.Properties.Resources.about_25;
			this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbout.Location = new System.Drawing.Point(-1, 209);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAbout.Size = new System.Drawing.Size(160, 66);
			this.btnAbout.TabIndex = 3;
			this.btnAbout.Text = "   About";
			this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnView
			// 
			this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnView.FlatAppearance.BorderSize = 0;
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.ForeColor = System.Drawing.Color.White;
			this.btnView.Image = global::AppBiodata.Properties.Resources.view_25;
			this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnView.Location = new System.Drawing.Point(0, 143);
			this.btnView.Name = "btnView";
			this.btnView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnView.Size = new System.Drawing.Size(160, 66);
			this.btnView.TabIndex = 2;
			this.btnView.Text = "   View";
			this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::AppBiodata.Properties.Resources.add_25;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(-1, 77);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAdd.Size = new System.Drawing.Size(160, 66);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "   Add";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnHome
			// 
			this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Image = global::AppBiodata.Properties.Resources.home_25;
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(-1, 11);
			this.btnHome.Name = "btnHome";
			this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnHome.Size = new System.Drawing.Size(160, 66);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "   Home";
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(160, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(611, 12);
			this.panel2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(263, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 22);
			this.label1.TabIndex = 7;
			this.label1.Text = "Follow me!";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel3.Location = new System.Drawing.Point(203, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(54, 87);
			this.panel3.TabIndex = 8;
			// 
			// button6
			// 
			this.button6.AccessibleDescription = "";
			this.button6.AccessibleName = "";
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Image = global::AppBiodata.Properties.Resources.setting_25;
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(39, 61);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(34, 30);
			this.button6.TabIndex = 17;
			this.button6.Tag = "";
			this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// btnQuit
			// 
			this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuit.FlatAppearance.BorderSize = 0;
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.ForeColor = System.Drawing.Color.White;
			this.btnQuit.Image = global::AppBiodata.Properties.Resources.shutdown_25;
			this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuit.Location = new System.Drawing.Point(75, 6);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(34, 30);
			this.btnQuit.TabIndex = 16;
			this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaximize.ForeColor = System.Drawing.Color.White;
			this.btnMaximize.Image = global::AppBiodata.Properties.Resources.maximize_25;
			this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMaximize.Location = new System.Drawing.Point(39, 6);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(34, 30);
			this.btnMaximize.TabIndex = 15;
			this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Image = global::AppBiodata.Properties.Resources.minimize_25;
			this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMinimize.Location = new System.Drawing.Point(3, 6);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(34, 30);
			this.btnMinimize.TabIndex = 14;
			this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.AccessibleDescription = "";
			this.btnSetting.AccessibleName = "";
			this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetting.ForeColor = System.Drawing.Color.White;
			this.btnSetting.Image = global::AppBiodata.Properties.Resources.help_25;
			this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetting.Location = new System.Drawing.Point(5, 61);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(34, 30);
			this.btnSetting.TabIndex = 13;
			this.btnSetting.Tag = "";
			this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetting.UseVisualStyleBackColor = true;
			// 
			// btnNotification
			// 
			this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNotification.FlatAppearance.BorderSize = 0;
			this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNotification.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNotification.ForeColor = System.Drawing.Color.White;
			this.btnNotification.Image = global::AppBiodata.Properties.Resources.notification_25;
			this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNotification.Location = new System.Drawing.Point(163, 13);
			this.btnNotification.Name = "btnNotification";
			this.btnNotification.Size = new System.Drawing.Size(34, 30);
			this.btnNotification.TabIndex = 12;
			this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNotification.UseVisualStyleBackColor = true;
			// 
			// btnLinkedin
			// 
			this.btnLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLinkedin.FlatAppearance.BorderSize = 0;
			this.btnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLinkedin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLinkedin.ForeColor = System.Drawing.Color.White;
			this.btnLinkedin.Image = global::AppBiodata.Properties.Resources.linkedin_25;
			this.btnLinkedin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLinkedin.Location = new System.Drawing.Point(435, 13);
			this.btnLinkedin.Name = "btnLinkedin";
			this.btnLinkedin.Size = new System.Drawing.Size(34, 30);
			this.btnLinkedin.TabIndex = 11;
			this.btnLinkedin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLinkedin.UseVisualStyleBackColor = true;
			this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
			// 
			// btnInstagram
			// 
			this.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInstagram.FlatAppearance.BorderSize = 0;
			this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInstagram.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstagram.ForeColor = System.Drawing.Color.White;
			this.btnInstagram.Image = global::AppBiodata.Properties.Resources.instagram_25;
			this.btnInstagram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInstagram.Location = new System.Drawing.Point(469, 13);
			this.btnInstagram.Name = "btnInstagram";
			this.btnInstagram.Size = new System.Drawing.Size(34, 30);
			this.btnInstagram.TabIndex = 10;
			this.btnInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInstagram.UseVisualStyleBackColor = true;
			this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
			// 
			// btnGithub
			// 
			this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGithub.FlatAppearance.BorderSize = 0;
			this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGithub.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGithub.ForeColor = System.Drawing.Color.White;
			this.btnGithub.Image = global::AppBiodata.Properties.Resources.github_25;
			this.btnGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGithub.Location = new System.Drawing.Point(401, 13);
			this.btnGithub.Name = "btnGithub";
			this.btnGithub.Size = new System.Drawing.Size(34, 30);
			this.btnGithub.TabIndex = 9;
			this.btnGithub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGithub.UseVisualStyleBackColor = true;
			this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
			// 
			// btnFacebook
			// 
			this.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFacebook.FlatAppearance.BorderSize = 0;
			this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFacebook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFacebook.ForeColor = System.Drawing.Color.White;
			this.btnFacebook.Image = global::AppBiodata.Properties.Resources.fb_25;
			this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFacebook.Location = new System.Drawing.Point(367, 13);
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.Size = new System.Drawing.Size(34, 30);
			this.btnFacebook.TabIndex = 7;
			this.btnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFacebook.UseVisualStyleBackColor = true;
			this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
			// 
			// addBiodataControl1
			// 
			this.addBiodataControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBiodataControl1.Location = new System.Drawing.Point(160, 99);
			this.addBiodataControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addBiodataControl1.Name = "addBiodataControl1";
			this.addBiodataControl1.Size = new System.Drawing.Size(610, 244);
			this.addBiodataControl1.TabIndex = 18;
			// 
			// aboutControl1
			// 
			this.aboutControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutControl1.Location = new System.Drawing.Point(160, 99);
			this.aboutControl1.Margin = new System.Windows.Forms.Padding(4);
			this.aboutControl1.Name = "aboutControl1";
			this.aboutControl1.Size = new System.Drawing.Size(611, 245);
			this.aboutControl1.TabIndex = 19;
			// 
			// homeControl1
			// 
			this.homeControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.homeControl1.Location = new System.Drawing.Point(160, 99);
			this.homeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.homeControl1.Name = "homeControl1";
			this.homeControl1.Size = new System.Drawing.Size(611, 245);
			this.homeControl1.TabIndex = 20;
			// 
			// viewBiodataControl1
			// 
			this.viewBiodataControl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewBiodataControl1.Location = new System.Drawing.Point(160, 99);
			this.viewBiodataControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.viewBiodataControl1.Name = "viewBiodataControl1";
			this.viewBiodataControl1.Size = new System.Drawing.Size(611, 245);
			this.viewBiodataControl1.TabIndex = 21;
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.btnMinimize);
			this.rightPanel.Controls.Add(this.btnQuit);
			this.rightPanel.Controls.Add(this.btnMaximize);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightPanel.Location = new System.Drawing.Point(659, 12);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(112, 369);
			this.rightPanel.TabIndex = 22;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.btnSetting);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(160, 281);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(499, 100);
			this.panel4.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 381);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.rightPanel);
			this.Controls.Add(this.homeControl1);
			this.Controls.Add(this.aboutControl1);
			this.Controls.Add(this.btnNotification);
			this.Controls.Add(this.btnLinkedin);
			this.Controls.Add(this.btnInstagram);
			this.Controls.Add(this.btnGithub);
			this.Controls.Add(this.btnFacebook);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.addBiodataControl1);
			this.Controls.Add(this.viewBiodataControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aplikasi Biodata";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panel1.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel SidePanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnFacebook;
		private System.Windows.Forms.Button btnGithub;
		private System.Windows.Forms.Button btnInstagram;
		private System.Windows.Forms.Button btnLinkedin;
		private System.Windows.Forms.Button btnNotification;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button button6;
		private AddBiodataControl addBiodataControl1;
		private AboutControl aboutControl1;
		private HomeControl homeControl1;
		private ViewBiodataControl viewBiodataControl1;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.Panel panel4;
	}
}

