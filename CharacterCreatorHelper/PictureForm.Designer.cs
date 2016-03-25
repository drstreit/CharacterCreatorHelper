namespace CharacterCreatorHelper
{
    partial class PictureForm
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
            this.pB_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_image
            // 
            this.pB_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pB_image.Location = new System.Drawing.Point(0, 0);
            this.pB_image.Name = "pB_image";
            this.pB_image.Size = new System.Drawing.Size(284, 261);
            this.pB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_image.TabIndex = 0;
            this.pB_image.TabStop = false;
            this.pB_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pB_image_MouseDown);
            this.pB_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pB_image_MouseMove);
            this.pB_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pB_image_MouseUp);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.pB_image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PictureForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureForm";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pB_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_image;
    }
}