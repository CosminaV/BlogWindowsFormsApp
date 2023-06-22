
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class EditPostForm
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
            this.AddPostTitleLabel = new System.Windows.Forms.Label();
            this.PostTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.EditPostSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPostTitleLabel
            // 
            this.AddPostTitleLabel.AutoSize = true;
            this.AddPostTitleLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPostTitleLabel.Location = new System.Drawing.Point(74, 84);
            this.AddPostTitleLabel.Name = "AddPostTitleLabel";
            this.AddPostTitleLabel.Size = new System.Drawing.Size(65, 32);
            this.AddPostTitleLabel.TabIndex = 9;
            this.AddPostTitleLabel.Text = "Title";
            // 
            // PostTitleTextBox
            // 
            this.PostTitleTextBox.Location = new System.Drawing.Point(361, 90);
            this.PostTitleTextBox.Multiline = true;
            this.PostTitleTextBox.Name = "PostTitleTextBox";
            this.PostTitleTextBox.Size = new System.Drawing.Size(387, 32);
            this.PostTitleTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description";
            // 
            // PostTextBox
            // 
            this.PostTextBox.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTextBox.Location = new System.Drawing.Point(361, 183);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(387, 160);
            this.PostTextBox.TabIndex = 12;
            // 
            // EditPostSaveButton
            // 
            this.EditPostSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditPostSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPostSaveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditPostSaveButton.Location = new System.Drawing.Point(636, 399);
            this.EditPostSaveButton.Name = "EditPostSaveButton";
            this.EditPostSaveButton.Size = new System.Drawing.Size(112, 35);
            this.EditPostSaveButton.TabIndex = 13;
            this.EditPostSaveButton.Text = "Save";
            this.EditPostSaveButton.UseVisualStyleBackColor = false;
            this.EditPostSaveButton.Click += new System.EventHandler(this.EditPostSaveButton_Click);
            // 
            // EditPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 539);
            this.Controls.Add(this.EditPostSaveButton);
            this.Controls.Add(this.PostTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostTitleTextBox);
            this.Controls.Add(this.AddPostTitleLabel);
            this.Name = "EditPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddPostTitleLabel;
        private System.Windows.Forms.TextBox PostTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.Button EditPostSaveButton;
    }
}