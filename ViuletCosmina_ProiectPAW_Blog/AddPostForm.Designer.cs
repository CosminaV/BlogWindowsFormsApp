
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class AddPostForm 
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
            this.AddPostTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostTitleTextBox = new System.Windows.Forms.TextBox();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.PostSaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaGrosimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareImagineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.signaturePanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPostTitleLabel
            // 
            this.AddPostTitleLabel.AutoSize = true;
            this.AddPostTitleLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPostTitleLabel.Location = new System.Drawing.Point(74, 85);
            this.AddPostTitleLabel.Name = "AddPostTitleLabel";
            this.AddPostTitleLabel.Size = new System.Drawing.Size(65, 32);
            this.AddPostTitleLabel.TabIndex = 0;
            this.AddPostTitleLabel.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // PostTitleTextBox
            // 
            this.PostTitleTextBox.Location = new System.Drawing.Point(361, 91);
            this.PostTitleTextBox.Multiline = true;
            this.PostTitleTextBox.Name = "PostTitleTextBox";
            this.PostTitleTextBox.Size = new System.Drawing.Size(387, 32);
            this.PostTitleTextBox.TabIndex = 2;
            // 
            // PostTextBox
            // 
            this.PostTextBox.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTextBox.Location = new System.Drawing.Point(361, 168);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(387, 160);
            this.PostTextBox.TabIndex = 3;
            // 
            // PostSaveButton
            // 
            this.PostSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PostSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostSaveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PostSaveButton.Location = new System.Drawing.Point(636, 522);
            this.PostSaveButton.Name = "PostSaveButton";
            this.PostSaveButton.Size = new System.Drawing.Size(112, 35);
            this.PostSaveButton.TabIndex = 4;
            this.PostSaveButton.Text = "Save";
            this.PostSaveButton.UseVisualStyleBackColor = false;
            this.PostSaveButton.Click += new System.EventHandler(this.PostSaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your digital signature";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.schimbaGrosimeToolStripMenuItem,
            this.salvareImagineToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(223, 100);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // schimbaGrosimeToolStripMenuItem
            // 
            this.schimbaGrosimeToolStripMenuItem.Name = "schimbaGrosimeToolStripMenuItem";
            this.schimbaGrosimeToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.schimbaGrosimeToolStripMenuItem.Text = "Schimba grosime";
            this.schimbaGrosimeToolStripMenuItem.Click += new System.EventHandler(this.schimbaGrosimeToolStripMenuItem_Click);
            // 
            // salvareImagineToolStripMenuItem
            // 
            this.salvareImagineToolStripMenuItem.Name = "salvareImagineToolStripMenuItem";
            this.salvareImagineToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.salvareImagineToolStripMenuItem.Text = "Salvare imagine";
            this.salvareImagineToolStripMenuItem.Click += new System.EventHandler(this.salvareImagineToolStripMenuItem_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(80, 530);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(114, 26);
            this.hScrollBar1.TabIndex = 11;
            // 
            // signaturePanel
            // 
            this.signaturePanel.BackColor = System.Drawing.Color.White;
            this.signaturePanel.ContextMenuStrip = this.contextMenuStrip2;
            this.signaturePanel.Location = new System.Drawing.Point(361, 398);
            this.signaturePanel.Name = "signaturePanel";
            this.signaturePanel.Size = new System.Drawing.Size(387, 102);
            this.signaturePanel.TabIndex = 10;
            this.signaturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signaturePanel_Paint_1);
            this.signaturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseDown);
            this.signaturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseMove);
            this.signaturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.signaturePanel_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 603);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.signaturePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostSaveButton);
            this.Controls.Add(this.PostTextBox);
            this.Controls.Add(this.PostTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPostTitleLabel);
            this.Name = "AddPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPostForm";
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPostTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostTitleTextBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.Button PostSaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaGrosimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareImagineToolStripMenuItem;
        private System.Windows.Forms.Panel signaturePanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}