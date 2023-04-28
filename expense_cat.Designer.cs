namespace Computerized_Poultry_Farm
{
    partial class expense_cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expense_cat));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_save = new Guna.UI.WinForms.GunaButton();
            this.EdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_expenseType = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(380, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 56);
            this.label1.TabIndex = 56;
            this.label1.Text = "ADD UP EXPENSE\r\nCATEGORY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
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
            this.btn_delete.Location = new System.Drawing.Point(385, 157);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(103, 42);
            this.btn_delete.TabIndex = 54;
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
            this.btn_save.Location = new System.Drawing.Point(275, 157);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Size = new System.Drawing.Size(86, 42);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "SAVE ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // EdataGridView
            // 
            this.EdataGridView.AllowUserToAddRows = false;
            this.EdataGridView.AllowUserToDeleteRows = false;
            this.EdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EdataGridView.Location = new System.Drawing.Point(35, 218);
            this.EdataGridView.Name = "EdataGridView";
            this.EdataGridView.ReadOnly = true;
            this.EdataGridView.Size = new System.Drawing.Size(765, 200);
            this.EdataGridView.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Expense Category";
            // 
            // textbox_expenseType
            // 
            this.textbox_expenseType.BaseColor = System.Drawing.Color.White;
            this.textbox_expenseType.BorderColor = System.Drawing.Color.Silver;
            this.textbox_expenseType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_expenseType.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox_expenseType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox_expenseType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox_expenseType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_expenseType.Location = new System.Drawing.Point(35, 173);
            this.textbox_expenseType.Name = "textbox_expenseType";
            this.textbox_expenseType.PasswordChar = '\0';
            this.textbox_expenseType.Size = new System.Drawing.Size(204, 26);
            this.textbox_expenseType.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.White;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton2.Location = new System.Drawing.Point(792, 4);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton2.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton2.TabIndex = 58;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // expense_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.EdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_expenseType);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "expense_cat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expense_cat";
            this.Load += new System.EventHandler(this.expense_cat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_save;
        private System.Windows.Forms.DataGridView EdataGridView;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox textbox_expenseType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}