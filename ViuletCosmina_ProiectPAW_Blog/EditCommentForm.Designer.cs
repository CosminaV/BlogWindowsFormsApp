
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class EditCommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCommentForm));
            this.commentDescriptionLabel = new System.Windows.Forms.Label();
            this.addCommentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveCommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentDescriptionLabel
            // 
            this.commentDescriptionLabel.AutoSize = true;
            this.commentDescriptionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentDescriptionLabel.Location = new System.Drawing.Point(106, 140);
            this.commentDescriptionLabel.Name = "commentDescriptionLabel";
            this.commentDescriptionLabel.Size = new System.Drawing.Size(270, 32);
            this.commentDescriptionLabel.TabIndex = 3;
            this.commentDescriptionLabel.Text = "Type your opinion here";
            // 
            // addCommentDescriptionTextBox
            // 
            this.addCommentDescriptionTextBox.Location = new System.Drawing.Point(446, 120);
            this.addCommentDescriptionTextBox.Multiline = true;
            this.addCommentDescriptionTextBox.Name = "addCommentDescriptionTextBox";
            this.addCommentDescriptionTextBox.Size = new System.Drawing.Size(365, 90);
            this.addCommentDescriptionTextBox.TabIndex = 4;
            // 
            // SaveCommentButton
            // 
            this.SaveCommentButton.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommentButton.Location = new System.Drawing.Point(713, 251);
            this.SaveCommentButton.Name = "SaveCommentButton";
            this.SaveCommentButton.Size = new System.Drawing.Size(98, 38);
            this.SaveCommentButton.TabIndex = 5;
            this.SaveCommentButton.Text = "Save";
            this.SaveCommentButton.UseVisualStyleBackColor = true;
            this.SaveCommentButton.Click += new System.EventHandler(this.SaveCommentButton_Click);
            // 
            // EditCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(910, 635);
            this.Controls.Add(this.SaveCommentButton);
            this.Controls.Add(this.addCommentDescriptionTextBox);
            this.Controls.Add(this.commentDescriptionLabel);
            this.Name = "EditCommentForm";
            this.Text = "EditCommentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commentDescriptionLabel;
        private System.Windows.Forms.TextBox addCommentDescriptionTextBox;
        private System.Windows.Forms.Button SaveCommentButton;
    }
}