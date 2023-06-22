
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class PostDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostDetailsForm));
            this.commentsDataGrid = new System.Windows.Forms.DataGridView();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.postTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsDataGrid
            // 
            this.commentsDataGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.commentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDataGrid.Location = new System.Drawing.Point(39, 142);
            this.commentsDataGrid.Name = "commentsDataGrid";
            this.commentsDataGrid.RowHeadersWidth = 62;
            this.commentsDataGrid.RowTemplate.Height = 28;
            this.commentsDataGrid.Size = new System.Drawing.Size(707, 269);
            this.commentsDataGrid.TabIndex = 0;
            this.commentsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentsDataGrid_CellClick);
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(39, 76);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(171, 39);
            this.addCommentButton.TabIndex = 1;
            this.addCommentButton.Text = "Add Comment";
            this.addCommentButton.UseVisualStyleBackColor = true;
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // postTitle
            // 
            this.postTitle.Enabled = false;
            this.postTitle.Location = new System.Drawing.Point(39, 21);
            this.postTitle.Name = "postTitle";
            this.postTitle.ReadOnly = true;
            this.postTitle.Size = new System.Drawing.Size(373, 26);
            this.postTitle.TabIndex = 2;
            // 
            // PostDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postTitle);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.commentsDataGrid);
            this.Name = "PostDetailsForm";
            this.Text = "PostDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView commentsDataGrid;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.TextBox postTitle;
    }
}