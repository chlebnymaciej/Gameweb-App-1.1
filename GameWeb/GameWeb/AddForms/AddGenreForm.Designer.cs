namespace GameWeb
{
    partial class AddGenreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenreForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genreName = new System.Windows.Forms.TextBox();
            this.add_countryButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genreName);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre name";
            // 
            // genreName
            // 
            this.genreName.Location = new System.Drawing.Point(6, 31);
            this.genreName.Name = "genreName";
            this.genreName.Size = new System.Drawing.Size(243, 20);
            this.genreName.TabIndex = 0;
            this.genreName.Validating += new System.ComponentModel.CancelEventHandler(this.genreName_Validating);
            this.genreName.Validated += new System.EventHandler(this.genreName_Validated);
            // 
            // add_countryButton
            // 
            this.add_countryButton.Location = new System.Drawing.Point(196, 119);
            this.add_countryButton.Name = "add_countryButton";
            this.add_countryButton.Size = new System.Drawing.Size(136, 42);
            this.add_countryButton.TabIndex = 3;
            this.add_countryButton.Text = "Add Genre";
            this.add_countryButton.UseVisualStyleBackColor = true;
            this.add_countryButton.Click += new System.EventHandler(this.add_countryButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(344, 173);
            this.Controls.Add(this.add_countryButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGenreForm";
            this.Text = "Add Genre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox genreName;
        private System.Windows.Forms.Button add_countryButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}