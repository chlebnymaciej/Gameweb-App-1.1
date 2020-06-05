namespace GameWeb
{
    partial class AddCountryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCountryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryId = new System.Windows.Forms.TextBox();
            this.add_countryButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countryName);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country name";
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(6, 31);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(243, 20);
            this.countryName.TabIndex = 0;
            this.countryName.Validating += new System.ComponentModel.CancelEventHandler(this.countryId_Validating);
            this.countryName.Validated += new System.EventHandler(this.countryId_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countryId);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country Identifier";
            // 
            // countryId
            // 
            this.countryId.Location = new System.Drawing.Point(6, 31);
            this.countryId.Name = "countryId";
            this.countryId.Size = new System.Drawing.Size(243, 20);
            this.countryId.TabIndex = 0;
            this.countryId.Validating += new System.ComponentModel.CancelEventHandler(this.countryId_Validating);
            this.countryId.Validated += new System.EventHandler(this.countryId_Validated);
            // 
            // add_countryButton
            // 
            this.add_countryButton.Location = new System.Drawing.Point(168, 247);
            this.add_countryButton.Name = "add_countryButton";
            this.add_countryButton.Size = new System.Drawing.Size(136, 42);
            this.add_countryButton.TabIndex = 2;
            this.add_countryButton.Text = "Add Country";
            this.add_countryButton.UseVisualStyleBackColor = true;
            this.add_countryButton.Click += new System.EventHandler(this.add_countryButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(316, 301);
            this.Controls.Add(this.add_countryButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCountryForm";
            this.Text = "Add Country";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox countryId;
        private System.Windows.Forms.Button add_countryButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}