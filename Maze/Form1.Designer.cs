namespace Maze
{
    partial class Form1
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
            this.uxButton = new System.Windows.Forms.Button();
            this.uxMazePicture = new Ksu.Cis300.MazeLibrary.Maze();
            this.SuspendLayout();
            // 
            // uxButton
            // 
            this.uxButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxButton.AutoSize = true;
            this.uxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton.Location = new System.Drawing.Point(53, 218);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(106, 30);
            this.uxButton.TabIndex = 0;
            this.uxButton.Text = "New Maze";
            this.uxButton.UseVisualStyleBackColor = true;
            this.uxButton.Click += new System.EventHandler(this.uxButton_Click);
            // 
            // uxMazePicture
            // 
            this.uxMazePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMazePicture.AutoSize = true;
            this.uxMazePicture.Location = new System.Drawing.Point(13, 11);
            this.uxMazePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMazePicture.Name = "uxMazePicture";
            this.uxMazePicture.PathColor = System.Drawing.SystemColors.Highlight;
            this.uxMazePicture.Size = new System.Drawing.Size(184, 191);
            this.uxMazePicture.TabIndex = 1;
            this.uxMazePicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxMazePicture_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 260);
            this.Controls.Add(this.uxMazePicture);
            this.Controls.Add(this.uxButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButton;
        private Ksu.Cis300.MazeLibrary.Maze uxMazePicture;
    }
}

