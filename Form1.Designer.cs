namespace Computerized_Poultry_Farm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.PictureBox();
            this.txtIcon2 = new System.Windows.Forms.PictureBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.showPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.indicator = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(592, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harness the login form below ";
            // 
            // txtIcon
            // 
            this.bunifuTransition1.SetDecoration(this.txtIcon, BunifuAnimatorNS.DecorationType.None);
            this.txtIcon.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon.Image")));
            this.txtIcon.Location = new System.Drawing.Point(568, 228);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(226, 41);
            this.txtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtIcon.TabIndex = 3;
            this.txtIcon.TabStop = false;
            // 
            // txtIcon2
            // 
            this.bunifuTransition1.SetDecoration(this.txtIcon2, BunifuAnimatorNS.DecorationType.None);
            this.txtIcon2.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon2.Image")));
            this.txtIcon2.Location = new System.Drawing.Point(568, 301);
            this.txtIcon2.Name = "txtIcon2";
            this.txtIcon2.Size = new System.Drawing.Size(226, 41);
            this.txtIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtIcon2.TabIndex = 4;
            this.txtIcon2.TabStop = false;
            // 
            // textbox_email
            // 
            this.textbox_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.textbox_email, BunifuAnimatorNS.DecorationType.None);
            this.textbox_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_email.ForeColor = System.Drawing.Color.DarkGray;
            this.textbox_email.Location = new System.Drawing.Point(623, 237);
            this.textbox_email.Multiline = true;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(140, 24);
            this.textbox_email.TabIndex = 5;
            this.textbox_email.TabStop = false;
            this.textbox_email.Text = "Email Address";
            this.textbox_email.UseSystemPasswordChar = true;
            this.textbox_email.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textbox_email.Leave += new System.EventHandler(this.textbox_email_Leave);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.textbox_password, BunifuAnimatorNS.DecorationType.None);
            this.textbox_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.ForeColor = System.Drawing.Color.DarkGray;
            this.textbox_password.Location = new System.Drawing.Point(626, 310);
            this.textbox_password.Multiline = true;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(132, 24);
            this.textbox_password.TabIndex = 6;
            this.textbox_password.TabStop = false;
            this.textbox_password.Text = "Password";
            this.textbox_password.Enter += new System.EventHandler(this.textbox_password_Enter);
            this.textbox_password.Leave += new System.EventHandler(this.textbox_password_Leave);
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showPass.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showPass.Checked = false;
            this.showPass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.showPass, BunifuAnimatorNS.DecorationType.None);
            this.showPass.ForeColor = System.Drawing.Color.White;
            this.showPass.Location = new System.Drawing.Point(591, 365);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(20, 20);
            this.showPass.TabIndex = 7;
            this.showPass.OnChange += new System.EventHandler(this.showPass_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(617, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Show Password";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(558, 393);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(256, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(625, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "New User?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(692, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Register";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.icon, BunifuAnimatorNS.DecorationType.None);
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(600, 235);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(14, 22);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 12;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // icon2
            // 
            this.icon2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.icon2, BunifuAnimatorNS.DecorationType.None);
            this.icon2.Image = ((System.Drawing.Image)(resources.GetObject("icon2.Image")));
            this.icon2.Location = new System.Drawing.Point(601, 310);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(13, 21);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2.TabIndex = 13;
            this.icon2.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(814, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picBox
            // 
            this.bunifuTransition1.SetDecoration(this.picBox, BunifuAnimatorNS.DecorationType.None);
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(-11, -1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(582, 561);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.indicator, BunifuAnimatorNS.DecorationType.None);
            this.indicator.Location = new System.Drawing.Point(656, 528);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(0, 13);
            this.indicator.TabIndex = 15;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(850, 558);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.icon2);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.txtIcon2);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBox);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox txtIcon;
        private System.Windows.Forms.PictureBox txtIcon2;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_password;
        private Bunifu.Framework.UI.BunifuCheckbox showPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.PictureBox icon;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label indicator;
    }
}

