namespace StableMarriage
{
    partial class FormPreference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreference));
            this.listViewPreference = new System.Windows.Forms.ListView();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelPreferenceName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPreference
            // 
            this.listViewPreference.HideSelection = false;
            this.listViewPreference.Location = new System.Drawing.Point(12, 41);
            this.listViewPreference.Name = "listViewPreference";
            this.listViewPreference.Size = new System.Drawing.Size(199, 198);
            this.listViewPreference.TabIndex = 0;
            this.listViewPreference.UseCompatibleStateImageBehavior = false;
            this.listViewPreference.View = System.Windows.Forms.View.List;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(217, 41);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(55, 23);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(217, 85);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(55, 23);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelPreferenceName
            // 
            this.labelPreferenceName.AutoSize = true;
            this.labelPreferenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferenceName.Location = new System.Drawing.Point(12, 9);
            this.labelPreferenceName.Name = "labelPreferenceName";
            this.labelPreferenceName.Size = new System.Drawing.Size(70, 25);
            this.labelPreferenceName.TabIndex = 2;
            this.labelPreferenceName.Text = "label1";
            // 
            // FormPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelPreferenceName);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listViewPreference);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPreference;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label labelPreferenceName;
    }
}