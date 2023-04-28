namespace Computerized_Poultry_Farm
{
    partial class PoultryDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoultryDoc));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboSymptom = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnChecker = new Guna.UI.WinForms.GunaButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.labelDisease = new System.Windows.Forms.Label();
            this.Labelfactor = new System.Windows.Forms.Label();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.loader = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelResult.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(348, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "POULTRY DOCTOR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(281, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Discover noticeable animal symptoms and diseases ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboSymptom
            // 
            this.comboSymptom.BackColor = System.Drawing.Color.Transparent;
            this.comboSymptom.BaseColor = System.Drawing.Color.White;
            this.comboSymptom.BorderColor = System.Drawing.Color.Silver;
            this.comboSymptom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSymptom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSymptom.FocusedColor = System.Drawing.Color.Empty;
            this.comboSymptom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSymptom.ForeColor = System.Drawing.Color.Black;
            this.comboSymptom.FormattingEnabled = true;
            this.comboSymptom.Items.AddRange(new object[] {
            "-- Select Noticed Symptom --",
            "Strains",
            "Respiratory Issue",
            "Air Sac Issue",
            "Dehydration",
            "Swelling",
            "Low Egg Production",
            "High mortality",
            "Low Feed Efficiency",
            "Sinus Swelling Under Turkey Eye",
            "Stupor",
            "Loss of Appetite",
            "Rapid Weight Loss",
            "Lameness",
            "Swollen Wattles",
            "Difficult Breathing",
            "Watery, Yellowish or Green Diarrhea",
            "Darkening of head & Wattles",
            "Listleness",
            "Increased Thirst and a Pale",
            "Anemic Apperance of Comb & wattles",
            "Weakness",
            "Noticeable Paralysis",
            "Egg Hatch Issues",
            "Slower / Retarded Growth",
            "Nervous Disorder",
            "Nasal Discharge",
            "Excessive Mucous in trachea",
            "Cloudiness in the cornea of the eye",
            "Gasping & Sneezing",
            " "});
            this.comboSymptom.Location = new System.Drawing.Point(248, 183);
            this.comboSymptom.Name = "comboSymptom";
            this.comboSymptom.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboSymptom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboSymptom.Size = new System.Drawing.Size(281, 26);
            this.comboSymptom.TabIndex = 51;
            this.comboSymptom.SelectedIndexChanged += new System.EventHandler(this.comboSymptom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(268, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Select noticeable animal symptoms";
            // 
            // BtnChecker
            // 
            this.BtnChecker.AnimationHoverSpeed = 0.07F;
            this.BtnChecker.AnimationSpeed = 0.03F;
            this.BtnChecker.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnChecker.BorderColor = System.Drawing.Color.Black;
            this.BtnChecker.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnChecker.FocusedColor = System.Drawing.Color.Empty;
            this.BtnChecker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnChecker.ForeColor = System.Drawing.Color.White;
            this.BtnChecker.Image = ((System.Drawing.Image)(resources.GetObject("BtnChecker.Image")));
            this.BtnChecker.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnChecker.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnChecker.Location = new System.Drawing.Point(248, 220);
            this.BtnChecker.Name = "BtnChecker";
            this.BtnChecker.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnChecker.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnChecker.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnChecker.OnHoverImage = null;
            this.BtnChecker.OnPressedColor = System.Drawing.Color.Black;
            this.BtnChecker.Size = new System.Drawing.Size(281, 41);
            this.BtnChecker.TabIndex = 53;
            this.BtnChecker.Text = "Check Disease & Cure";
            this.BtnChecker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnChecker.Click += new System.EventHandler(this.BtnChecker_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(530, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.Controls.Add(this.labelRecommendation);
            this.panelResult.Controls.Add(this.labelDisease);
            this.panelResult.Controls.Add(this.Labelfactor);
            this.panelResult.Controls.Add(this.gunaVSeparator2);
            this.panelResult.Controls.Add(this.gunaVSeparator1);
            this.panelResult.Controls.Add(this.panel2);
            this.panelResult.Controls.Add(this.panel3);
            this.panelResult.Controls.Add(this.panel1);
            this.panelResult.Location = new System.Drawing.Point(71, 274);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(735, 288);
            this.panelResult.TabIndex = 59;
            this.panelResult.Visible = false;
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecommendation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRecommendation.Location = new System.Drawing.Point(321, 56);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(108, 18);
            this.labelRecommendation.TabIndex = 62;
            this.labelRecommendation.Text = "Bacterial Disease";
            // 
            // labelDisease
            // 
            this.labelDisease.AutoSize = true;
            this.labelDisease.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDisease.Location = new System.Drawing.Point(168, 56);
            this.labelDisease.Name = "labelDisease";
            this.labelDisease.Size = new System.Drawing.Size(0, 18);
            this.labelDisease.TabIndex = 61;
            // 
            // Labelfactor
            // 
            this.Labelfactor.AutoSize = true;
            this.Labelfactor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelfactor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Labelfactor.Location = new System.Drawing.Point(5, 56);
            this.Labelfactor.Name = "Labelfactor";
            this.Labelfactor.Size = new System.Drawing.Size(108, 18);
            this.Labelfactor.TabIndex = 60;
            this.Labelfactor.Text = "Bacterial Disease";
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator2.Location = new System.Drawing.Point(311, 41);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(10, 224);
            this.gunaVSeparator2.TabIndex = 59;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(153, 41);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 224);
            this.gunaVSeparator1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(159, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 40);
            this.panel2.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Possible Diseases";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(316, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 40);
            this.panel3.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(132, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Recommended solution";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 40);
            this.panel1.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Disease Factor";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.White;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton2.Location = new System.Drawing.Point(843, 5);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton2.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton2.TabIndex = 63;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // loader
            // 
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(794, 113);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(58, 50);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 64;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PoultryDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(900, 587);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnChecker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSymptom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoultryDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoultryDoc";
            this.Load += new System.EventHandler(this.PoultryDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox comboSymptom;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton BtnChecker;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelRecommendation;
        private System.Windows.Forms.Label labelDisease;
        private System.Windows.Forms.Label Labelfactor;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.Timer timer2;
    }
}