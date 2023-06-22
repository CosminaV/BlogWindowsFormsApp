
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class PostsDatabaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostsDatabaseForm));
            this.PostsDataGrid = new System.Windows.Forms.DataGridView();
            this.AddNewPostButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exportButton = new System.Windows.Forms.ToolStripButton();
            this.importButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PostsDataGrid
            // 
            this.PostsDataGrid.AllowUserToAddRows = false;
            this.PostsDataGrid.AllowUserToDeleteRows = false;
            this.PostsDataGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.PostsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostsDataGrid.Location = new System.Drawing.Point(30, 83);
            this.PostsDataGrid.Name = "PostsDataGrid";
            this.PostsDataGrid.RowHeadersWidth = 62;
            this.PostsDataGrid.RowTemplate.Height = 28;
            this.PostsDataGrid.Size = new System.Drawing.Size(848, 538);
            this.PostsDataGrid.TabIndex = 6;
            this.PostsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostsDataGrid_cellClick);
            // 
            // AddNewPostButton
            // 
            this.AddNewPostButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddNewPostButton.Location = new System.Drawing.Point(30, 37);
            this.AddNewPostButton.Name = "AddNewPostButton";
            this.AddNewPostButton.Size = new System.Drawing.Size(148, 40);
            this.AddNewPostButton.TabIndex = 7;
            this.AddNewPostButton.Text = "Add new post";
            this.AddNewPostButton.UseVisualStyleBackColor = false;
            this.AddNewPostButton.Click += new System.EventHandler(this.AddNewPostButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportButton,
            this.importButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 34);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exportButton
            // 
            this.exportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(67, 29);
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(71, 29);
            this.importButton.Text = "Import";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // PostsDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 679);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.AddNewPostButton);
            this.Controls.Add(this.PostsDataGrid);
            this.Name = "PostsDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostsDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PostsDataGrid;
        private System.Windows.Forms.Button AddNewPostButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exportButton;
        private System.Windows.Forms.ToolStripButton importButton;
    }
}