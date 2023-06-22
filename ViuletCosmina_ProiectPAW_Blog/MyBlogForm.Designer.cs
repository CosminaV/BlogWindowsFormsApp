
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class MyBlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBlogForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriiComboBox = new System.Windows.Forms.ComboBox();
            this.AboutMeLabel = new System.Windows.Forms.Label();
            this.AboutMeTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareaFundaluluiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(337, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cosmina\'s Blog";
            // 
            // CategoriiComboBox
            // 
            this.CategoriiComboBox.BackColor = System.Drawing.Color.Moccasin;
            this.CategoriiComboBox.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriiComboBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.CategoriiComboBox.FormattingEnabled = true;
            this.CategoriiComboBox.Items.AddRange(new object[] {
            "STYLE",
            "FOOD",
            "BEAUTY"});
            this.CategoriiComboBox.Location = new System.Drawing.Point(202, 148);
            this.CategoriiComboBox.Name = "CategoriiComboBox";
            this.CategoriiComboBox.Size = new System.Drawing.Size(174, 35);
            this.CategoriiComboBox.TabIndex = 1;
            this.CategoriiComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriiComboBox_SelectedIndexChanged);
            // 
            // AboutMeLabel
            // 
            this.AboutMeLabel.AutoSize = true;
            this.AboutMeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutMeLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMeLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.AboutMeLabel.Location = new System.Drawing.Point(202, 341);
            this.AboutMeLabel.Name = "AboutMeLabel";
            this.AboutMeLabel.Size = new System.Drawing.Size(174, 38);
            this.AboutMeLabel.TabIndex = 2;
            this.AboutMeLabel.Text = "ABOUT ME";
            // 
            // AboutMeTextBox
            // 
            this.AboutMeTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.AboutMeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AboutMeTextBox.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMeTextBox.ForeColor = System.Drawing.Color.Black;
            this.AboutMeTextBox.Location = new System.Drawing.Point(518, 263);
            this.AboutMeTextBox.Multiline = true;
            this.AboutMeTextBox.Name = "AboutMeTextBox";
            this.AboutMeTextBox.ReadOnly = true;
            this.AboutMeTextBox.Size = new System.Drawing.Size(459, 182);
            this.AboutMeTextBox.TabIndex = 3;
            this.AboutMeTextBox.Text = resources.GetString("AboutMeTextBox.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareaFundaluluiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(307, 36);
            // 
            // schimbaCuloareaFundaluluiToolStripMenuItem
            // 
            this.schimbaCuloareaFundaluluiToolStripMenuItem.Name = "schimbaCuloareaFundaluluiToolStripMenuItem";
            this.schimbaCuloareaFundaluluiToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.schimbaCuloareaFundaluluiToolStripMenuItem.Text = "Schimba culoarea fundalului";
            this.schimbaCuloareaFundaluluiToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareaFundaluluiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AboutMeTextBox);
            this.panel1.Controls.Add(this.AboutMeLabel);
            this.panel1.Controls.Add(this.CategoriiComboBox);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 602);
            this.panel1.TabIndex = 5;
            // 
            // MyBlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 599);
            this.Controls.Add(this.panel1);
            this.Name = "MyBlogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoriiComboBox;
        private System.Windows.Forms.Label AboutMeLabel;
        private System.Windows.Forms.TextBox AboutMeTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaFundaluluiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

