namespace Computerized_Poultry_Farm
{
    partial class report_expense
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Etype = new Guna.UI.WinForms.GunaComboBox();
            this.BPFromdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BPTodate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_load = new Guna.UI.WinForms.GunaButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BPFromdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BPTodate);
            this.panel1.Controls.Add(this.gunaVSeparator1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 57);
            this.panel1.TabIndex = 2;
            // 
            // Etype
            // 
            this.Etype.BackColor = System.Drawing.Color.Transparent;
            this.Etype.BaseColor = System.Drawing.Color.White;
            this.Etype.BorderColor = System.Drawing.Color.Silver;
            this.Etype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Etype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Etype.FocusedColor = System.Drawing.Color.Empty;
            this.Etype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Etype.ForeColor = System.Drawing.Color.Black;
            this.Etype.FormattingEnabled = true;
            this.Etype.Items.AddRange(new object[] {
            "--Select Category--"});
            this.Etype.Location = new System.Drawing.Point(7, 91);
            this.Etype.Name = "Etype";
            this.Etype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Etype.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Etype.Size = new System.Drawing.Size(148, 26);
            this.Etype.TabIndex = 68;
            this.Etype.Visible = false;
            // 
            // BPFromdate
            // 
            this.BPFromdate.BaseColor = System.Drawing.Color.White;
            this.BPFromdate.BorderColor = System.Drawing.Color.Silver;
            this.BPFromdate.CustomFormat = "yyyy-MM-dd";
            this.BPFromdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.BPFromdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPFromdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BPFromdate.ForeColor = System.Drawing.Color.Black;
            this.BPFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BPFromdate.Location = new System.Drawing.Point(84, 13);
            this.BPFromdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BPFromdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BPFromdate.Name = "BPFromdate";
            this.BPFromdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.BPFromdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPFromdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPFromdate.OnPressedColor = System.Drawing.Color.Black;
            this.BPFromdate.Size = new System.Drawing.Size(123, 30);
            this.BPFromdate.TabIndex = 62;
            this.BPFromdate.Text = "2008-07-21";
            this.BPFromdate.Value = new System.DateTime(2008, 7, 21, 0, 0, 0, 0);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(162, 90);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 3;
            this.gunaButton1.Size = new System.Drawing.Size(89, 28);
            this.gunaButton1.TabIndex = 69;
            this.gunaButton1.Text = "SEARCH";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Visible = false;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "From:";
            // 
            // BPTodate
            // 
            this.BPTodate.BaseColor = System.Drawing.Color.White;
            this.BPTodate.BorderColor = System.Drawing.Color.Silver;
            this.BPTodate.CustomFormat = "yyyy-MM-dd";
            this.BPTodate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.BPTodate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPTodate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BPTodate.ForeColor = System.Drawing.Color.Black;
            this.BPTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BPTodate.Location = new System.Drawing.Point(263, 13);
            this.BPTodate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BPTodate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BPTodate.Name = "BPTodate";
            this.BPTodate.OnHoverBaseColor = System.Drawing.Color.White;
            this.BPTodate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPTodate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BPTodate.OnPressedColor = System.Drawing.Color.Black;
            this.BPTodate.Size = new System.Drawing.Size(124, 30);
            this.BPTodate.TabIndex = 64;
            this.BPTodate.Text = "2020-07-21";
            this.BPTodate.Value = new System.DateTime(2020, 7, 21, 0, 0, 0, 0);
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(213, 11);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(7, 33);
            this.gunaVSeparator1.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(224, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "To:";
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.AnimationHoverSpeed = 0.07F;
            this.btn_load.AnimationSpeed = 0.03F;
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btn_load.BorderColor = System.Drawing.Color.Black;
            this.btn_load.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_load.FocusedColor = System.Drawing.Color.Empty;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Image = null;
            this.btn_load.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_load.Location = new System.Drawing.Point(611, 13);
            this.btn_load.Name = "btn_load";
            this.btn_load.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_load.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_load.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_load.OnHoverImage = null;
            this.btn_load.OnPressedColor = System.Drawing.Color.Black;
            this.btn_load.Radius = 3;
            this.btn_load.Size = new System.Drawing.Size(187, 30);
            this.btn_load.TabIndex = 66;
            this.btn_load.Text = "LOAD REPORT";
            this.btn_load.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 504);
            this.reportViewer1.TabIndex = 70;
            // 
            // report_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Etype);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaButton1);
            this.Name = "report_expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report_expense";
            this.Load += new System.EventHandler(this.report_expense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox Etype;
        private Guna.UI.WinForms.GunaDateTimePicker BPFromdate;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker BPTodate;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btn_load;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}