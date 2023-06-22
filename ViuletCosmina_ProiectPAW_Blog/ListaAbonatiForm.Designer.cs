
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class ListaAbonatiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAbonatiForm));
            this.AbonatiListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.graficButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AbonatiListView
            // 
            this.AbonatiListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.AbonatiListView.AllowColumnReorder = true;
            this.AbonatiListView.AllowDrop = true;
            this.AbonatiListView.CheckBoxes = true;
            this.AbonatiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.AbonatiListView.FullRowSelect = true;
            this.AbonatiListView.GridLines = true;
            this.AbonatiListView.HideSelection = false;
            this.AbonatiListView.Location = new System.Drawing.Point(121, 59);
            this.AbonatiListView.Name = "AbonatiListView";
            this.AbonatiListView.Size = new System.Drawing.Size(516, 423);
            this.AbonatiListView.TabIndex = 23;
            this.AbonatiListView.UseCompatibleStateImageBehavior = false;
            this.AbonatiListView.View = System.Windows.Forms.View.Details;
            this.AbonatiListView.ItemActivate += new System.EventHandler(this.AbonatiListView_ItemActivate);
            this.AbonatiListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.AbonatiListView_ItemChecked);
            this.AbonatiListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AbonatiListView_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Varsta";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sex";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 54;
            // 
            // graficButton
            // 
            this.graficButton.Location = new System.Drawing.Point(533, 12);
            this.graficButton.Name = "graficButton";
            this.graficButton.Size = new System.Drawing.Size(104, 39);
            this.graficButton.TabIndex = 24;
            this.graficButton.Text = "Grafic";
            this.graficButton.UseVisualStyleBackColor = true;
            this.graficButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(680, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 423);
            this.panel1.TabIndex = 25;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // ListaAbonatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1176, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.graficButton);
            this.Controls.Add(this.AbonatiListView);
            this.Name = "ListaAbonatiForm";
            this.Text = "ListaAbonatiForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AbonatiListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button graficButton;
        private System.Windows.Forms.Panel panel1;
    }
}