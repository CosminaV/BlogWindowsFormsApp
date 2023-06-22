
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class PostareForm
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
            this.PostTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostText = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PostTitleLabel
            // 
            this.PostTitleLabel.AutoSize = true;
            this.PostTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.PostTitleLabel.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTitleLabel.Location = new System.Drawing.Point(516, 31);
            this.PostTitleLabel.Name = "PostTitleLabel";
            this.PostTitleLabel.Size = new System.Drawing.Size(102, 44);
            this.PostTitleLabel.TabIndex = 0;
            this.PostTitleLabel.Text = "label1";
            this.PostTitleLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // PostText
            // 
            this.PostText.AutoSize = true;
            this.PostText.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostText.Location = new System.Drawing.Point(343, 152);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(0, 24);
            this.PostText.TabIndex = 5;
            this.PostText.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(34, 152);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(271, 463);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox2.Location = new System.Drawing.Point(864, 169);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(331, 501);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Visible = false;
            // 
            // PostareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1259, 1050);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PostText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PostTitleLabel);
            this.Name = "PostareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PostareForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PostTitleLabel;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PostText;
        private System.Windows.Forms.PictureBox PictureBox2;
    }
}