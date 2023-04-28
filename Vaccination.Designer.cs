namespace Computerized_Poultry_Farm
{
    partial class Vaccination
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vaccination));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.combo_vaccine = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_name = new Guna.UI.WinForms.GunaTextBox();
            this.textbox_reaction = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_staff = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_other = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vacdataGridView = new System.Windows.Forms.DataGridView();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_save = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(400, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Add up all vaccine entry";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "VACCINATION  ENTRY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(339, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // combo_vaccine
            // 
            this.combo_vaccine.BackColor = System.Drawing.Color.Transparent;
            this.combo_vaccine.BaseColor = System.Drawing.Color.White;
            this.combo_vaccine.BorderColor = System.Drawing.Color.Silver;
            this.combo_vaccine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_vaccine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vaccine.FocusedColor = System.Drawing.Color.Empty;
            this.combo_vaccine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_vaccine.ForeColor = System.Drawing.Color.Black;
            this.combo_vaccine.FormattingEnabled = true;
            this.combo_vaccine.Items.AddRange(new object[] {
            "--Select Vaccine --"});
            this.combo_vaccine.Location = new System.Drawing.Point(129, 126);
            this.combo_vaccine.Name = "combo_vaccine";
            this.combo_vaccine.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_vaccine.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_vaccine.Size = new System.Drawing.Size(204, 26);
            this.combo_vaccine.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(128, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Select Vaccine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(128, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textbox_name
            // 
            this.textbox_name.BaseColor = System.Drawing.Color.White;
            this.textbox_name.BorderColor = System.Drawing.Color.Silver;
            this.textbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_name.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_name.Location = new System.Drawing.Point(129, 213);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.PasswordChar = '\0';
            this.textbox_name.Size = new System.Drawing.Size(204, 26);
            this.textbox_name.TabIndex = 35;
            this.textbox_name.TextChanged += new System.EventHandler(this.textbox_phoneno_TextChanged);
            // 
            // textbox_reaction
            // 
            this.textbox_reaction.BaseColor = System.Drawing.Color.White;
            this.textbox_reaction.BorderColor = System.Drawing.Color.Silver;
            this.textbox_reaction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_reaction.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox_reaction.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_reaction.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox_reaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_reaction.Location = new System.Drawing.Point(131, 294);
            this.textbox_reaction.Name = "textbox_reaction";
            this.textbox_reaction.PasswordChar = '\0';
            this.textbox_reaction.Size = new System.Drawing.Size(204, 26);
            this.textbox_reaction.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(130, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Reaction";
            // 
            // vdate
            // 
            this.vdate.BaseColor = System.Drawing.Color.White;
            this.vdate.BorderColor = System.Drawing.Color.Silver;
            this.vdate.CustomFormat = "yyyy-MM-dd";
            this.vdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.vdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vdate.ForeColor = System.Drawing.Color.Black;
            this.vdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vdate.Location = new System.Drawing.Point(387, 122);
            this.vdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.vdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.vdate.Name = "vdate";
            this.vdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.vdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.vdate.OnPressedColor = System.Drawing.Color.Black;
            this.vdate.Size = new System.Drawing.Size(204, 30);
            this.vdate.TabIndex = 39;
            this.vdate.Text = "2020-07-21";
            this.vdate.Value = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(384, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date Received";
            // 
            // textbox_staff
            // 
            this.textbox_staff.BackColor = System.Drawing.Color.Transparent;
            this.textbox_staff.BaseColor = System.Drawing.Color.White;
            this.textbox_staff.BorderColor = System.Drawing.Color.Silver;
            this.textbox_staff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.textbox_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textbox_staff.FocusedColor = System.Drawing.Color.Empty;
            this.textbox_staff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textbox_staff.ForeColor = System.Drawing.Color.Black;
            this.textbox_staff.FormattingEnabled = true;
            this.textbox_staff.Items.AddRange(new object[] {
            "-- Select Staff --"});
            this.textbox_staff.Location = new System.Drawing.Point(387, 213);
            this.textbox_staff.Name = "textbox_staff";
            this.textbox_staff.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_staff.OnHoverItemForeColor = System.Drawing.Color.White;
            this.textbox_staff.Size = new System.Drawing.Size(204, 26);
            this.textbox_staff.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(386, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Administered By";
            // 
            // textbox_other
            // 
            this.textbox_other.BaseColor = System.Drawing.Color.White;
            this.textbox_other.BorderColor = System.Drawing.Color.Silver;
            this.textbox_other.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_other.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox_other.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_other.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox_other.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_other.Location = new System.Drawing.Point(387, 294);
            this.textbox_other.Name = "textbox_other";
            this.textbox_other.PasswordChar = '\0';
            this.textbox_other.Size = new System.Drawing.Size(204, 26);
            this.textbox_other.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(386, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Other";
            // 
            // vacdataGridView
            // 
            this.vacdataGridView.AllowUserToAddRows = false;
            this.vacdataGridView.AllowUserToDeleteRows = false;
            this.vacdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.vacdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.vacdataGridView.Location = new System.Drawing.Point(129, 359);
            this.vacdataGridView.Name = "vacdataGridView";
            this.vacdataGridView.ReadOnly = true;
            this.vacdataGridView.Size = new System.Drawing.Size(612, 200);
            this.vacdataGridView.TabIndex = 44;
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(215)))), ((int)(((byte)(239)))));
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete.Location = new System.Drawing.Point(638, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(103, 42);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(215)))), ((int)(((byte)(239)))));
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_save.Location = new System.Drawing.Point(638, 122);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Size = new System.Drawing.Size(103, 42);
            this.btn_save.TabIndex = 45;
            this.btn_save.Text = "SAVE ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Vaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.vacdataGridView);
            this.Controls.Add(this.textbox_other);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_staff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_reaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_vaccine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Vaccination";
            this.Size = new System.Drawing.Size(945, 640);
            this.Load += new System.EventHandler(this.Vaccination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaComboBox combo_vaccine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox textbox_name;
        private Guna.UI.WinForms.GunaTextBox textbox_reaction;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker vdate;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox textbox_staff;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox textbox_other;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView vacdataGridView;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_save;
    }
}
