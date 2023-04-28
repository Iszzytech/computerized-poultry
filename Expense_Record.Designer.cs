namespace Computerized_Poultry_Farm
{
    partial class Expense_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense_Record));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combobox_exp = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_desc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Edate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_amount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Edatagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(428, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add up all expense transaction";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "EXPENSE ENTRY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // combobox_exp
            // 
            this.combobox_exp.BackColor = System.Drawing.Color.Transparent;
            this.combobox_exp.BaseColor = System.Drawing.Color.White;
            this.combobox_exp.BorderColor = System.Drawing.Color.Silver;
            this.combobox_exp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_exp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_exp.FocusedColor = System.Drawing.Color.Empty;
            this.combobox_exp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_exp.ForeColor = System.Drawing.Color.Black;
            this.combobox_exp.FormattingEnabled = true;
            this.combobox_exp.Items.AddRange(new object[] {
            "-- Select Expense Category --"});
            this.combobox_exp.Location = new System.Drawing.Point(382, 173);
            this.combobox_exp.Name = "combobox_exp";
            this.combobox_exp.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combobox_exp.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combobox_exp.Size = new System.Drawing.Size(204, 26);
            this.combobox_exp.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(379, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select Expense Category";
            // 
            // textbox_desc
            // 
            this.textbox_desc.Location = new System.Drawing.Point(382, 250);
            this.textbox_desc.Name = "textbox_desc";
            this.textbox_desc.Size = new System.Drawing.Size(204, 59);
            this.textbox_desc.TabIndex = 46;
            this.textbox_desc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(377, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Description";
            // 
            // Edate
            // 
            this.Edate.BaseColor = System.Drawing.Color.White;
            this.Edate.BorderColor = System.Drawing.Color.Silver;
            this.Edate.CustomFormat = "yyyy-MM-dd";
            this.Edate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Edate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Edate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edate.ForeColor = System.Drawing.Color.Black;
            this.Edate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Edate.Location = new System.Drawing.Point(380, 360);
            this.Edate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Edate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Edate.Name = "Edate";
            this.Edate.OnHoverBaseColor = System.Drawing.Color.White;
            this.Edate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Edate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Edate.OnPressedColor = System.Drawing.Color.Black;
            this.Edate.Size = new System.Drawing.Size(204, 30);
            this.Edate.TabIndex = 48;
            this.Edate.Text = "2020-07-21";
            this.Edate.Value = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(377, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(638, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Amount (₦)";
            // 
            // textbox_amount
            // 
            this.textbox_amount.BaseColor = System.Drawing.Color.White;
            this.textbox_amount.BorderColor = System.Drawing.Color.Silver;
            this.textbox_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_amount.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox_amount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_amount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_amount.Location = new System.Drawing.Point(639, 173);
            this.textbox_amount.Name = "textbox_amount";
            this.textbox_amount.PasswordChar = '\0';
            this.textbox_amount.Size = new System.Drawing.Size(204, 26);
            this.textbox_amount.TabIndex = 49;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(215)))), ((int)(((byte)(239)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(639, 348);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(124, 42);
            this.gunaButton2.TabIndex = 52;
            this.gunaButton2.Text = "DELETE";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(215)))), ((int)(((byte)(239)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(639, 250);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(124, 42);
            this.gunaButton1.TabIndex = 51;
            this.gunaButton1.Text = "SAVE DETAILS";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Edatagridview
            // 
            this.Edatagridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edatagridview.Location = new System.Drawing.Point(380, 416);
            this.Edatagridview.Name = "Edatagridview";
            this.Edatagridview.Size = new System.Drawing.Size(463, 198);
            this.Edatagridview.TabIndex = 53;
            // 
            // Expense_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.Edatagridview);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_amount);
            this.Controls.Add(this.Edate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobox_exp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Expense_Record";
            this.Size = new System.Drawing.Size(945, 640);
            this.Load += new System.EventHandler(this.Expense_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox combobox_exp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textbox_desc;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDateTimePicker Edate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox textbox_amount;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.DataGridView Edatagridview;
    }
}
