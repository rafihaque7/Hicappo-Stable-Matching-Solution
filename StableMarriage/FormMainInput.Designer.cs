namespace StableMarriage
{
    partial class FormMainInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainInput));
            this.listViewMale = new System.Windows.Forms.ListView();
            this.listViewFemale = new System.Windows.Forms.ListView();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.buttonAddMale = new System.Windows.Forms.Button();
            this.buttonAddFemale = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonNextinvis = new System.Windows.Forms.Button();
            this.labelHalfCountMale = new System.Windows.Forms.Label();
            this.labelHalfCountFemale = new System.Windows.Forms.Label();
            this.labelCurrentMale = new System.Windows.Forms.Label();
            this.labelCurrentFemale = new System.Windows.Forms.Label();
            this.buttonPreference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMale
            // 
            this.listViewMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listViewMale.HideSelection = false;
            this.listViewMale.Location = new System.Drawing.Point(82, 74);
            this.listViewMale.Name = "listViewMale";
            this.listViewMale.Size = new System.Drawing.Size(221, 360);
            this.listViewMale.TabIndex = 0;
            this.listViewMale.UseCompatibleStateImageBehavior = false;
            this.listViewMale.View = System.Windows.Forms.View.Details;
            // 
            // listViewFemale
            // 
            this.listViewFemale.HideSelection = false;
            this.listViewFemale.Location = new System.Drawing.Point(362, 74);
            this.listViewFemale.Name = "listViewFemale";
            this.listViewFemale.Size = new System.Drawing.Size(233, 360);
            this.listViewFemale.TabIndex = 0;
            this.listViewFemale.UseCompatibleStateImageBehavior = false;
            this.listViewFemale.View = System.Windows.Forms.View.Details;
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMale.Location = new System.Drawing.Point(143, 9);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(99, 42);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "Male";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelFemale.Location = new System.Drawing.Point(411, 9);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(142, 42);
            this.labelFemale.TabIndex = 1;
            this.labelFemale.Text = "Female";
            // 
            // buttonAddMale
            // 
            this.buttonAddMale.Location = new System.Drawing.Point(670, 100);
            this.buttonAddMale.Name = "buttonAddMale";
            this.buttonAddMale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMale.TabIndex = 2;
            this.buttonAddMale.Text = "Add Male";
            this.buttonAddMale.UseVisualStyleBackColor = true;
            this.buttonAddMale.Click += new System.EventHandler(this.buttonAddMale_Click);
            // 
            // buttonAddFemale
            // 
            this.buttonAddFemale.Location = new System.Drawing.Point(670, 147);
            this.buttonAddFemale.Name = "buttonAddFemale";
            this.buttonAddFemale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFemale.TabIndex = 2;
            this.buttonAddFemale.Text = "Add Female";
            this.buttonAddFemale.UseVisualStyleBackColor = true;
            this.buttonAddFemale.Click += new System.EventHandler(this.buttonAddFemale_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(670, 195);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonNextinvis
            // 
            this.buttonNextinvis.Location = new System.Drawing.Point(698, 503);
            this.buttonNextinvis.Name = "buttonNextinvis";
            this.buttonNextinvis.Size = new System.Drawing.Size(75, 23);
            this.buttonNextinvis.TabIndex = 4;
            this.buttonNextinvis.Text = "Next";
            this.buttonNextinvis.UseVisualStyleBackColor = true;
            this.buttonNextinvis.Click += new System.EventHandler(this.buttonNextinvis_Click);
            // 
            // labelHalfCountMale
            // 
            this.labelHalfCountMale.AutoSize = true;
            this.labelHalfCountMale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelHalfCountMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalfCountMale.ForeColor = System.Drawing.Color.Lime;
            this.labelHalfCountMale.Location = new System.Drawing.Point(185, 460);
            this.labelHalfCountMale.Name = "labelHalfCountMale";
            this.labelHalfCountMale.Size = new System.Drawing.Size(118, 42);
            this.labelHalfCountMale.TabIndex = 5;
            this.labelHalfCountMale.Text = "label1";
            // 
            // labelHalfCountFemale
            // 
            this.labelHalfCountFemale.AutoSize = true;
            this.labelHalfCountFemale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelHalfCountFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalfCountFemale.ForeColor = System.Drawing.Color.Lime;
            this.labelHalfCountFemale.Location = new System.Drawing.Point(477, 460);
            this.labelHalfCountFemale.Name = "labelHalfCountFemale";
            this.labelHalfCountFemale.Size = new System.Drawing.Size(118, 42);
            this.labelHalfCountFemale.TabIndex = 5;
            this.labelHalfCountFemale.Text = "label1";
            // 
            // labelCurrentMale
            // 
            this.labelCurrentMale.AutoSize = true;
            this.labelCurrentMale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelCurrentMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentMale.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelCurrentMale.Location = new System.Drawing.Point(75, 460);
            this.labelCurrentMale.Name = "labelCurrentMale";
            this.labelCurrentMale.Size = new System.Drawing.Size(118, 42);
            this.labelCurrentMale.TabIndex = 5;
            this.labelCurrentMale.Text = "label1";
            // 
            // labelCurrentFemale
            // 
            this.labelCurrentFemale.AutoSize = true;
            this.labelCurrentFemale.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelCurrentFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentFemale.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelCurrentFemale.Location = new System.Drawing.Point(355, 460);
            this.labelCurrentFemale.Name = "labelCurrentFemale";
            this.labelCurrentFemale.Size = new System.Drawing.Size(118, 42);
            this.labelCurrentFemale.TabIndex = 5;
            this.labelCurrentFemale.Text = "label1";
            // 
            // buttonPreference
            // 
            this.buttonPreference.Location = new System.Drawing.Point(670, 242);
            this.buttonPreference.Name = "buttonPreference";
            this.buttonPreference.Size = new System.Drawing.Size(75, 23);
            this.buttonPreference.TabIndex = 6;
            this.buttonPreference.Text = "Preference";
            this.buttonPreference.UseVisualStyleBackColor = true;
            this.buttonPreference.Click += new System.EventHandler(this.buttonPreference_Click);
            // 
            // FormMainInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StableMarriage.Properties.Resources.WP_Elefantasia_2560x1440_00000;
            this.ClientSize = new System.Drawing.Size(815, 565);
            this.Controls.Add(this.buttonPreference);
            this.Controls.Add(this.labelCurrentFemale);
            this.Controls.Add(this.labelHalfCountFemale);
            this.Controls.Add(this.labelCurrentMale);
            this.Controls.Add(this.labelHalfCountMale);
            this.Controls.Add(this.buttonNextinvis);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddFemale);
            this.Controls.Add(this.buttonAddMale);
            this.Controls.Add(this.labelFemale);
            this.Controls.Add(this.labelMale);
            this.Controls.Add(this.listViewFemale);
            this.Controls.Add(this.listViewMale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainInput";
            this.Text = "Hicappo Stable Matching Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMale;
        private System.Windows.Forms.ListView listViewFemale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Button buttonAddMale;
        private System.Windows.Forms.Button buttonAddFemale;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonNextinvis;
        private System.Windows.Forms.Label labelHalfCountMale;
        private System.Windows.Forms.Label labelHalfCountFemale;
        private System.Windows.Forms.Label labelCurrentMale;
        private System.Windows.Forms.Label labelCurrentFemale;
        private System.Windows.Forms.Button buttonPreference;
    }
}