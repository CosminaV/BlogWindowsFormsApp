
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class CategoriesDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesDatabaseForm));
            this.categoriesDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.afisAbonatiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesDataGrid
            // 
            this.categoriesDataGrid.AllowUserToAddRows = false;
            this.categoriesDataGrid.AllowUserToDeleteRows = false;
            this.categoriesDataGrid.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.categoriesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGrid.Location = new System.Drawing.Point(60, 152);
            this.categoriesDataGrid.Name = "categoriesDataGrid";
            this.categoriesDataGrid.ReadOnly = true;
            this.categoriesDataGrid.RowHeadersWidth = 62;
            this.categoriesDataGrid.RowTemplate.Height = 28;
            this.categoriesDataGrid.Size = new System.Drawing.Size(397, 185);
            this.categoriesDataGrid.TabIndex = 0;
            this.categoriesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // afisAbonatiButton
            // 
            this.afisAbonatiButton.Location = new System.Drawing.Point(365, 45);
            this.afisAbonatiButton.Name = "afisAbonatiButton";
            this.afisAbonatiButton.Size = new System.Drawing.Size(178, 37);
            this.afisAbonatiButton.TabIndex = 26;
            this.afisAbonatiButton.Text = "Afiseaza lista abonati";
            this.afisAbonatiButton.UseVisualStyleBackColor = true;
            this.afisAbonatiButton.Click += new System.EventHandler(this.afisAbonatiButton_Click);
            // 
            // CategoriesDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 424);
            this.Controls.Add(this.afisAbonatiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoriesDataGrid);
            this.Name = "CategoriesDatabaseForm";
            this.Text = "CategoriesDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button afisAbonatiButton;
    }
}