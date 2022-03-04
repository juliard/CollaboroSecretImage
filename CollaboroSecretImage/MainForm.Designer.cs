
namespace CollaboroSecretImage
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.DecodedPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.DecodeImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecodedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Location = new System.Drawing.Point(23, 21);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(751, 196);
            this.OriginalPictureBox.TabIndex = 0;
            this.OriginalPictureBox.TabStop = false;
            // 
            // DecodedPictureBox
            // 
            this.DecodedPictureBox.Location = new System.Drawing.Point(23, 270);
            this.DecodedPictureBox.Name = "DecodedPictureBox";
            this.DecodedPictureBox.Size = new System.Drawing.Size(751, 196);
            this.DecodedPictureBox.TabIndex = 1;
            this.DecodedPictureBox.TabStop = false;
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Location = new System.Drawing.Point(56, 486);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(222, 37);
            this.OpenImageButton.TabIndex = 2;
            this.OpenImageButton.Text = "Open Image";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            this.OpenImageButton.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // DecodeImageButton
            // 
            this.DecodeImageButton.Location = new System.Drawing.Point(511, 486);
            this.DecodeImageButton.Name = "DecodeImageButton";
            this.DecodeImageButton.Size = new System.Drawing.Size(222, 37);
            this.DecodeImageButton.TabIndex = 3;
            this.DecodeImageButton.Text = "Decode Image";
            this.DecodeImageButton.UseVisualStyleBackColor = true;
            this.DecodeImageButton.Click += new System.EventHandler(this.DecodeImageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.DecodeImageButton);
            this.Controls.Add(this.OpenImageButton);
            this.Controls.Add(this.DecodedPictureBox);
            this.Controls.Add(this.OriginalPictureBox);
            this.Name = "MainForm";
            this.Text = "Image Processor";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecodedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.PictureBox DecodedPictureBox;
        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.Button DecodeImageButton;
    }
}

