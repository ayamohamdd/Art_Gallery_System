namespace WindowsFormsApp3
{
    partial class InformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1 = new WindowsFormsApp3.RoundPanel();
            this.infoGridView = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.custInfoButton = new System.Windows.Forms.RadioButton();
            this.artistInfoButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(961, 721);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 41);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderWidth = 1;
            this.panel1.Controls.Add(this.infoGridView);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.custInfoButton);
            this.panel1.Controls.Add(this.artistInfoButton);
            this.panel1.Location = new System.Drawing.Point(236, 70);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.Size = new System.Drawing.Size(1117, 782);
            this.panel1.TabIndex = 11;
            // 
            // infoGridView
            // 
            this.infoGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.infoGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.infoGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.infoGridView.Location = new System.Drawing.Point(102, 179);
            this.infoGridView.Margin = new System.Windows.Forms.Padding(30);
            this.infoGridView.Name = "infoGridView";
            this.infoGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.infoGridView.RowHeadersWidth = 51;
            this.infoGridView.RowTemplate.Height = 24;
            this.infoGridView.Size = new System.Drawing.Size(905, 536);
            this.infoGridView.TabIndex = 20;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(469, 132);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(126, 41);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // custInfoButton
            // 
            this.custInfoButton.AutoSize = true;
            this.custInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custInfoButton.ForeColor = System.Drawing.Color.White;
            this.custInfoButton.Location = new System.Drawing.Point(429, 83);
            this.custInfoButton.Name = "custInfoButton";
            this.custInfoButton.Size = new System.Drawing.Size(239, 29);
            this.custInfoButton.TabIndex = 11;
            this.custInfoButton.TabStop = true;
            this.custInfoButton.Text = "Customer Information\r\n";
            this.custInfoButton.UseVisualStyleBackColor = true;
            // 
            // artistInfoButton
            // 
            this.artistInfoButton.AutoSize = true;
            this.artistInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistInfoButton.ForeColor = System.Drawing.Color.White;
            this.artistInfoButton.Location = new System.Drawing.Point(428, 31);
            this.artistInfoButton.Name = "artistInfoButton";
            this.artistInfoButton.Size = new System.Drawing.Size(196, 29);
            this.artistInfoButton.TabIndex = 10;
            this.artistInfoButton.TabStop = true;
            this.artistInfoButton.Text = "Artist Information\r\n";
            this.artistInfoButton.UseVisualStyleBackColor = true;
            this.artistInfoButton.CheckedChanged += new System.EventHandler(this.artistInfoButton_CheckedChanged);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1648, 919);
            this.Controls.Add(this.panel1);
            this.Name = "InformationForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private RoundPanel panel1;
        private System.Windows.Forms.DataGridView infoGridView;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RadioButton custInfoButton;
        private System.Windows.Forms.RadioButton artistInfoButton;
    }
}