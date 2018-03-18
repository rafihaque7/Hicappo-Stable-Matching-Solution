namespace StableMarriage
{
    partial class FormTotalCount
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
            this.label1 = new System.Windows.Forms.Label();
            this.textTotalCount = new System.Windows.Forms.TextBox();
            this.buttonTotalCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many people in total \r\nwill be participating?";
            // 
            // textTotalCount
            // 
            this.textTotalCount.Location = new System.Drawing.Point(108, 213);
            this.textTotalCount.Name = "textTotalCount";
            this.textTotalCount.Size = new System.Drawing.Size(841, 20);
            this.textTotalCount.TabIndex = 1;
            this.textTotalCount.Text = "has to be even!!!";
            this.textTotalCount.TextChanged += new System.EventHandler(this.textTotalCount_TextChanged);
            // 
            // buttonTotalCount
            // 
            this.buttonTotalCount.Location = new System.Drawing.Point(670, 259);
            this.buttonTotalCount.Name = "buttonTotalCount";
            this.buttonTotalCount.Size = new System.Drawing.Size(279, 96);
            this.buttonTotalCount.TabIndex = 2;
            this.buttonTotalCount.Text = "next";
            this.buttonTotalCount.UseVisualStyleBackColor = true;
            this.buttonTotalCount.Click += new System.EventHandler(this.buttonTotalCount_Click);
            // 
            // FormTotalCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StableMarriage.Properties.Resources.WP_Elefantasia_2560x1440_00000;
            this.ClientSize = new System.Drawing.Size(1087, 565);
            this.Controls.Add(this.buttonTotalCount);
            this.Controls.Add(this.textTotalCount);
            this.Controls.Add(this.label1);
            this.Name = "FormTotalCount";
            this.Text = "Hicappo Stable Matching Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotalCount;
        private System.Windows.Forms.Button buttonTotalCount;
    }
}