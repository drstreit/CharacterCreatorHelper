namespace CharacterCreatorHelper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbToggle = new System.Windows.Forms.CheckBox();
            this.b_LoadPicture = new System.Windows.Forms.Button();
            this.tB_Alpha = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tB_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // cbToggle
            // 
            this.cbToggle.AutoSize = true;
            this.cbToggle.Enabled = false;
            this.cbToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbToggle.Location = new System.Drawing.Point(13, 42);
            this.cbToggle.Name = "cbToggle";
            this.cbToggle.Size = new System.Drawing.Size(106, 17);
            this.cbToggle.TabIndex = 0;
            this.cbToggle.Text = "Picture touchable";
            this.cbToggle.UseVisualStyleBackColor = true;
            this.cbToggle.CheckedChanged += new System.EventHandler(this.cbToggle_CheckedChanged);
            // 
            // b_LoadPicture
            // 
            this.b_LoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_LoadPicture.Location = new System.Drawing.Point(13, 13);
            this.b_LoadPicture.Name = "b_LoadPicture";
            this.b_LoadPicture.Size = new System.Drawing.Size(91, 23);
            this.b_LoadPicture.TabIndex = 1;
            this.b_LoadPicture.Text = "Load picture";
            this.b_LoadPicture.UseVisualStyleBackColor = true;
            this.b_LoadPicture.Click += new System.EventHandler(this.b_LoadPicture_Click);
            // 
            // tB_Alpha
            // 
            this.tB_Alpha.Enabled = false;
            this.tB_Alpha.Location = new System.Drawing.Point(123, 13);
            this.tB_Alpha.Maximum = 100;
            this.tB_Alpha.Minimum = 10;
            this.tB_Alpha.Name = "tB_Alpha";
            this.tB_Alpha.Size = new System.Drawing.Size(308, 45);
            this.tB_Alpha.SmallChange = 5;
            this.tB_Alpha.TabIndex = 3;
            this.tB_Alpha.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tB_Alpha.Value = 10;
            this.tB_Alpha.Scroll += new System.EventHandler(this.tB_Alpha_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 72);
            this.Controls.Add(this.tB_Alpha);
            this.Controls.Add(this.b_LoadPicture);
            this.Controls.Add(this.cbToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Character Creator Helper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tB_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbToggle;
        private System.Windows.Forms.Button b_LoadPicture;
        private System.Windows.Forms.TrackBar tB_Alpha;
    }
}

