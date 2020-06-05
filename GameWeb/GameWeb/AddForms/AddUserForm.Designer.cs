namespace GameWeb
{
    partial class AddUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryBox = new System.Windows.Forms.CheckBox();
            this.countriesChoice = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.add_countryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(6, 31);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(243, 20);
            this.userName.TabIndex = 0;
            this.userName.Validating += new System.ComponentModel.CancelEventHandler(this.userName_Validating);
            this.userName.Validated += new System.EventHandler(this.userName_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countryBox);
            this.groupBox2.Controls.Add(this.countriesChoice);
            this.groupBox2.Location = new System.Drawing.Point(10, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 107);
            this.groupBox2.TabIndex = 2;
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
            this.countryBox.CheckedChanged += new System.EventHandler(this.countryBox_CheckedChanged);
            // 
            // countriesChoice
            // 
            this.countriesChoice.FormattingEnabled = true;
            this.countriesChoice.Location = new System.Drawing.Point(6, 28);
            this.countriesChoice.Name = "countriesChoice";
            this.countriesChoice.Size = new System.Drawing.Size(240, 21);
            this.countriesChoice.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // add_countryButton
            // 
            this.add_countryButton.Location = new System.Drawing.Point(164, 264);
            this.add_countryButton.Name = "add_countryButton";
            this.add_countryButton.Size = new System.Drawing.Size(136, 42);
            this.add_countryButton.TabIndex = 4;
            this.add_countryButton.Text = "Add User";
            this.add_countryButton.UseVisualStyleBackColor = true;
            this.add_countryButton.Click += new System.EventHandler(this.add_userButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(312, 318);
            this.Controls.Add(this.add_countryButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.Text = "Add User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox countriesChoice;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button add_countryButton;
        private System.Windows.Forms.CheckBox countryBox;
    }
}