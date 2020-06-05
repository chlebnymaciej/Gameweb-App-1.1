namespace GameWeb.ModifyForms
{
    partial class ModifyUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUserForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryBox = new System.Windows.Forms.CheckBox();
            this.countriesChoice = new System.Windows.Forms.ComboBox();
            this.add_countryButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countryBox);
            this.groupBox2.Controls.Add(this.countriesChoice);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.AutoSize = true;
            this.countryBox.Location = new System.Drawing.Point(12, 70);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(175, 17);
            this.countryBox.TabIndex = 1;
            this.countryBox.Text = "I do not want to add my country";
            this.countryBox.UseVisualStyleBackColor = true;
            // 
            // countriesChoice
            // 
            this.countriesChoice.FormattingEnabled = true;
            this.countriesChoice.Location = new System.Drawing.Point(6, 28);
            this.countriesChoice.Name = "countriesChoice";
            this.countriesChoice.Size = new System.Drawing.Size(240, 21);
            this.countriesChoice.TabIndex = 0;
            // 
            // add_countryButton
            // 
            this.add_countryButton.Location = new System.Drawing.Point(170, 138);
            this.add_countryButton.Name = "add_countryButton";
            this.add_countryButton.Size = new System.Drawing.Size(136, 42);
            this.add_countryButton.TabIndex = 5;
            this.add_countryButton.Text = "Apply";
            this.add_countryButton.UseVisualStyleBackColor = true;
            this.add_countryButton.Click += new System.EventHandler(this.add_countryButton_Click);
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 192);
            this.Controls.Add(this.add_countryButton);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyUserForm";
            this.Text = "ModifyUserForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox countryBox;
        private System.Windows.Forms.ComboBox countriesChoice;
        private System.Windows.Forms.Button add_countryButton;
    }
}