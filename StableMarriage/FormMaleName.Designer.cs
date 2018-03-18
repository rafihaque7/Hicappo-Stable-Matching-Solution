namespace StableMarriage
{
    partial class FormMaleName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaleName));
            this.labelMaleName = new System.Windows.Forms.Label();
            this.textMaleName = new System.Windows.Forms.TextBox();
            this.buttonAddMale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaleName
            // 
            this.labelMaleName.AutoSize = true;
            this.labelMaleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaleName.Location = new System.Drawing.Point(12, 27);
            this.labelMaleName.Name = "labelMaleName";
            this.labelMaleName.Size = new System.Drawing.Size(68, 25);
            this.labelMaleName.TabIndex = 0;
            this.labelMaleName.Text = "Name";
            // 
            // textMaleName
            // 
            this.textMaleName.Location = new System.Drawing.Point(86, 32);
            this.textMaleName.Name = "textMaleName";
            this.textMaleName.Size = new System.Drawing.Size(152, 20);
            this.textMaleName.TabIndex = 1;
            this.textMaleName.TextChanged += new System.EventHandler(this.textMaleName_TextChanged);
            // 
            // buttonAddMale
            // 
            this.buttonAddMale.Location = new System.Drawing.Point(163, 58);
            this.buttonAddMale.Name = "buttonAddMale";
            this.buttonAddMale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMale.TabIndex = 2;
            this.buttonAddMale.Text = "Add";
            this.buttonAddMale.UseVisualStyleBackColor = true;
            this.buttonAddMale.Click += new System.EventHandler(this.buttonAddMale_Click);
            // 
            // FormMaleName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 109);
            this.Controls.Add(this.buttonAddMale);
            this.Controls.Add(this.textMaleName);
            this.Controls.Add(this.labelMaleName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMaleName";
            this.Text = "Add a Male";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaleName;
        private System.Windows.Forms.TextBox textMaleName;
        private System.Windows.Forms.Button buttonAddMale;
    }
}