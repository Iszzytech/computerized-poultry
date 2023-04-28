namespace Computerized_Poultry_Farm
{
    partial class breedTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(breedTypeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.breedType1 = new Computerized_Poultry_Farm.breedType();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.gunaImageButton2);
            this.panel1.Controls.Add(this.breedType1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 450);
            this.panel1.TabIndex = 0;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.White;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.gunaImageButton2.Location = new System.Drawing.Point(792, 5);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, -1);
            this.gunaImageButton2.Size = new System.Drawing.Size(32, 32);
            this.gunaImageButton2.TabIndex = 22;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // breedType1
            // 
            this.breedType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.breedType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breedType1.Location = new System.Drawing.Point(0, 0);
            this.breedType1.Name = "breedType1";
            this.breedType1.Size = new System.Drawing.Size(836, 450);
            this.breedType1.TabIndex = 0;
            this.breedType1.Load += new System.EventHandler(this.breedType1_Load);
            // 
            // breedTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "breedTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "breedTypeForm";
            this.Load += new System.EventHandler(this.breedTypeForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private breedType breedType1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}