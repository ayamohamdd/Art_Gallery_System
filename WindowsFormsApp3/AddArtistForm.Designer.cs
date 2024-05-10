namespace WindowsFormsApp3
{
    partial class AddArtistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtistForm));
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.artworksGridView = new System.Windows.Forms.DataGridView();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artworksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameTextBox
            // 
            resources.ApplyResources(this.fnameTextBox, "fnameTextBox");
            this.fnameTextBox.Name = "fnameTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.Name = "emailTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lnameTextBox
            // 
            resources.ApplyResources(this.lnameTextBox, "lnameTextBox");
            this.lnameTextBox.Name = "lnameTextBox";
            // 
            // showButton
            // 
            resources.ApplyResources(this.showButton, "showButton");
            this.showButton.Name = "showButton";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // artworksGridView
            // 
            this.artworksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.artworksGridView, "artworksGridView");
            this.artworksGridView.Name = "artworksGridView";
            this.artworksGridView.RowTemplate.Height = 32;
            // 
            // IdTextBox
            // 
            resources.ApplyResources(this.IdTextBox, "IdTextBox");
            this.IdTextBox.Name = "IdTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // AddArtistForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.artworksGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameTextBox);
            this.Name = "AddArtistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddArtistForm_FormClosed);
            this.Load += new System.EventHandler(this.AddArtistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artworksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView artworksGridView;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label5;
    }
}