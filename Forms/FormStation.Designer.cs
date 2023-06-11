namespace FenixMusic.Forms
{
    partial class FormStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStation));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtCategories = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCategories = new MaterialSkin.Controls.MaterialLabel();
            this.txtLink = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLink = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtCategories);
            this.materialCard1.Controls.Add(this.lblCategories);
            this.materialCard1.Controls.Add(this.txtLink);
            this.materialCard1.Controls.Add(this.lblLink);
            this.materialCard1.Controls.Add(this.txtName);
            this.materialCard1.Controls.Add(this.lblName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(597, 262);
            this.materialCard1.TabIndex = 0;
            // 
            // txtCategories
            // 
            this.txtCategories.AnimateReadOnly = false;
            this.txtCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategories.Depth = 0;
            this.txtCategories.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCategories.LeadingIcon = null;
            this.txtCategories.Location = new System.Drawing.Point(139, 167);
            this.txtCategories.MaxLength = 50;
            this.txtCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategories.Multiline = false;
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.Size = new System.Drawing.Size(441, 50);
            this.txtCategories.TabIndex = 5;
            this.txtCategories.Text = "";
            this.txtCategories.TrailingIcon = null;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Depth = 0;
            this.lblCategories.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategories.Location = new System.Drawing.Point(17, 187);
            this.lblCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(88, 19);
            this.lblCategories.TabIndex = 4;
            this.lblCategories.Text = "Categories : ";
            // 
            // txtLink
            // 
            this.txtLink.AnimateReadOnly = false;
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLink.Depth = 0;
            this.txtLink.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLink.LeadingIcon = null;
            this.txtLink.Location = new System.Drawing.Point(139, 89);
            this.txtLink.MaxLength = 50;
            this.txtLink.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLink.Multiline = false;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(441, 50);
            this.txtLink.TabIndex = 3;
            this.txtLink.Text = "";
            this.txtLink.TrailingIcon = null;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Depth = 0;
            this.lblLink.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLink.Location = new System.Drawing.Point(17, 105);
            this.lblLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(43, 19);
            this.lblLink.TabIndex = 2;
            this.lblLink.Text = "Link : ";
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(139, 17);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(441, 50);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(17, 29);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(280, 369);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStation";
            this.Text = "Station";
            this.Load += new System.EventHandler(this.FormStation_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialTextBox txtCategories;
        private MaterialSkin.Controls.MaterialLabel lblCategories;
        private MaterialSkin.Controls.MaterialTextBox txtLink;
        private MaterialSkin.Controls.MaterialLabel lblLink;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}