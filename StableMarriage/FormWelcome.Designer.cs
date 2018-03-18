namespace StableMarriage
{
    partial class FormWelcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetstarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 192);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hicappo Matching Solution \r\nBy Rafi Haque\r\n\r\n";
            // 
            // buttonGetstarted
            // 
            this.buttonGetstarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetstarted.Location = new System.Drawing.Point(216, 272);
            this.buttonGetstarted.Name = "buttonGetstarted";
            this.buttonGetstarted.Size = new System.Drawing.Size(385, 165);
            this.buttonGetstarted.TabIndex = 1;
            this.buttonGetstarted.Text = "Get Started!";
            this.buttonGetstarted.UseVisualStyleBackColor = true;
            this.buttonGetstarted.Click += new System.EventHandler(this.buttonGetstarted_Click);
            // 
            // FormWelcome
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::StableMarriage.Properties.Resources.WP_Elefantasia_2560x1440_00000;
            this.ClientSize = new System.Drawing.Size(1087, 565);
            this.Controls.Add(this.buttonGetstarted);
            this.Controls.Add(this.label2);
            this.Name = "FormWelcome";
            this.Text = "Hicappo Stable Matching Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetstarted;
    }
}

