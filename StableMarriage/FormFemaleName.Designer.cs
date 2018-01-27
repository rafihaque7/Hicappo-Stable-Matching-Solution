namespace StableMarriage
{
    partial class FormFemaleName
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
            this.labelFemaleName = new System.Windows.Forms.Label();
            this.textFemaleName = new System.Windows.Forms.TextBox();
            this.buttonAddFemale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFemaleName
            // 
            this.labelFemaleName.AutoSize = true;
            this.labelFemaleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemaleName.Location = new System.Drawing.Point(24, 29);
            this.labelFemaleName.Name = "labelFemaleName";
            this.labelFemaleName.Size = new System.Drawing.Size(61, 24);
            this.labelFemaleName.TabIndex = 0;
            this.labelFemaleName.Text = "Name";
            // 
            // textFemaleName
            // 
            this.textFemaleName.Location = new System.Drawing.Point(98, 29);
            this.textFemaleName.Name = "textFemaleName";
            this.textFemaleName.Size = new System.Drawing.Size(100, 20);
            this.textFemaleName.TabIndex = 1;
            this.textFemaleName.TextChanged += new System.EventHandler(this.textFemaleName_TextChanged);
            // 
            // buttonAddFemale
            // 
            this.buttonAddFemale.Location = new System.Drawing.Point(123, 65);
            this.buttonAddFemale.Name = "buttonAddFemale";
            this.buttonAddFemale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFemale.TabIndex = 2;
            this.buttonAddFemale.Text = "Add";
            this.buttonAddFemale.UseVisualStyleBackColor = true;
            this.buttonAddFemale.Click += new System.EventHandler(this.buttonAddFemale_Click);
            // 
            // FormFemaleName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 100);
            this.Controls.Add(this.buttonAddFemale);
            this.Controls.Add(this.textFemaleName);
            this.Controls.Add(this.labelFemaleName);
            this.MaximizeBox = false;
            this.Name = "FormFemaleName";
            this.Text = "FormFemaleName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFemaleName;
        private System.Windows.Forms.TextBox textFemaleName;
        private System.Windows.Forms.Button buttonAddFemale;
    }
}