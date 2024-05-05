
namespace WindowsFormsApp3
{
    partial class ConnectedForm
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
            this.panel1 = new WindowsFormsApp3.RoundPanel();
            this.addArtist = new System.Windows.Forms.Button();
            this.artistEnquiry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderWidth = 1;
            this.panel1.Controls.Add(this.addArtist);
            this.panel1.Controls.Add(this.artistEnquiry);
            this.panel1.Location = new System.Drawing.Point(53, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.Size = new System.Drawing.Size(670, 627);
            this.panel1.TabIndex = 0;
            // 
            // addArtist
            // 
            this.addArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            this.addArtist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addArtist.FlatAppearance.BorderSize = 2;
            this.addArtist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addArtist.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addArtist.Location = new System.Drawing.Point(168, 345);
            this.addArtist.Name = "addArtist";
            this.addArtist.Size = new System.Drawing.Size(315, 86);
            this.addArtist.TabIndex = 1;
            this.addArtist.Text = "Add artist / artwork";
            this.addArtist.UseVisualStyleBackColor = false;
            this.addArtist.Click += new System.EventHandler(this.addArtist_Click);
            // 
            // artistEnquiry
            // 
            this.artistEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.artistEnquiry.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistEnquiry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.artistEnquiry.Location = new System.Drawing.Point(168, 162);
            this.artistEnquiry.Name = "artistEnquiry";
            this.artistEnquiry.Size = new System.Drawing.Size(315, 86);
            this.artistEnquiry.TabIndex = 0;
            this.artistEnquiry.Text = "Artist Enquiry";
            this.artistEnquiry.UseVisualStyleBackColor = true;
            this.artistEnquiry.Click += new System.EventHandler(this.artistEnquiry_Click);
            // 
            // ConnectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(787, 699);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ConnectedForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConnectedForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel panel1;
        private System.Windows.Forms.Button artistEnquiry;
        private System.Windows.Forms.Button addArtist;
    }
}