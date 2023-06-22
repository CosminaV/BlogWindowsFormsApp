
namespace ViuletCosmina_ProiectPAW_Blog
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PrenumeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VarstaLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.PrenumeTextBox = new System.Windows.Forms.TextBox();
            this.ParolaTextBox = new System.Windows.Forms.TextBox();
            this.VarstaTextBox = new System.Windows.Forms.TextBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ParolaLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.OwnerCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ai venit pe blogul meu!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fa-ti un cont";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(245, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 24);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Nume:";
            // 
            // PrenumeLabel
            // 
            this.PrenumeLabel.AutoSize = true;
            this.PrenumeLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenumeLabel.Location = new System.Drawing.Point(245, 193);
            this.PrenumeLabel.Name = "PrenumeLabel";
            this.PrenumeLabel.Size = new System.Drawing.Size(88, 24);
            this.PrenumeLabel.TabIndex = 3;
            this.PrenumeLabel.Text = "Prenume:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(245, 305);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(142, 24);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Adresa de email:";
            // 
            // VarstaLabel
            // 
            this.VarstaLabel.AutoSize = true;
            this.VarstaLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarstaLabel.Location = new System.Drawing.Point(245, 429);
            this.VarstaLabel.Name = "VarstaLabel";
            this.VarstaLabel.Size = new System.Drawing.Size(64, 24);
            this.VarstaLabel.TabIndex = 5;
            this.VarstaLabel.Text = "Varsta:";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(245, 492);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(42, 24);
            this.SexLabel.TabIndex = 6;
            this.SexLabel.Text = "Sex:";
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.Location = new System.Drawing.Point(417, 134);
            this.NumeTextBox.Multiline = true;
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(327, 35);
            this.NumeTextBox.TabIndex = 1;
            // 
            // PrenumeTextBox
            // 
            this.PrenumeTextBox.Location = new System.Drawing.Point(417, 193);
            this.PrenumeTextBox.Multiline = true;
            this.PrenumeTextBox.Name = "PrenumeTextBox";
            this.PrenumeTextBox.Size = new System.Drawing.Size(327, 34);
            this.PrenumeTextBox.TabIndex = 2;
            // 
            // ParolaTextBox
            // 
            this.ParolaTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParolaTextBox.Location = new System.Drawing.Point(417, 370);
            this.ParolaTextBox.Multiline = true;
            this.ParolaTextBox.Name = "ParolaTextBox";
            this.ParolaTextBox.PasswordChar = '*';
            this.ParolaTextBox.Size = new System.Drawing.Size(327, 40);
            this.ParolaTextBox.TabIndex = 5;
            this.ParolaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ParolaTextBox_Validating);
            this.ParolaTextBox.Validated += new System.EventHandler(this.ParolaTextBox_Validated);
            // 
            // VarstaTextBox
            // 
            this.VarstaTextBox.Location = new System.Drawing.Point(417, 429);
            this.VarstaTextBox.Multiline = true;
            this.VarstaTextBox.Name = "VarstaTextBox";
            this.VarstaTextBox.Size = new System.Drawing.Size(327, 37);
            this.VarstaTextBox.TabIndex = 6;
            // 
            // SexComboBox
            // 
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.SexComboBox.Location = new System.Drawing.Point(417, 492);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(327, 28);
            this.SexComboBox.TabIndex = 7;
            this.SexComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SexComboBox_KeyPress);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(477, 541);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(134, 33);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Inregistreaza-te";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ai deja cont?";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(486, 641);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(123, 32);
            this.LogInButton.TabIndex = 14;
            this.LogInButton.Text = "Intra in cont";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(245, 251);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(96, 24);
            this.UsernameLabel.TabIndex = 15;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(417, 251);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(327, 39);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // ParolaLabel
            // 
            this.ParolaLabel.AutoSize = true;
            this.ParolaLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaLabel.Location = new System.Drawing.Point(245, 370);
            this.ParolaLabel.Name = "ParolaLabel";
            this.ParolaLabel.Size = new System.Drawing.Size(64, 24);
            this.ParolaLabel.TabIndex = 17;
            this.ParolaLabel.Text = "Parola:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(417, 305);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(327, 37);
            this.EmailTextBox.TabIndex = 4;
            // 
            // OwnerCheckBox
            // 
            this.OwnerCheckBox.AutoSize = true;
            this.OwnerCheckBox.Location = new System.Drawing.Point(859, 52);
            this.OwnerCheckBox.Name = "OwnerCheckBox";
            this.OwnerCheckBox.Size = new System.Drawing.Size(81, 24);
            this.OwnerCheckBox.TabIndex = 19;
            this.OwnerCheckBox.Text = "Owner";
            this.OwnerCheckBox.UseVisualStyleBackColor = true;
            this.OwnerCheckBox.CheckedChanged += new System.EventHandler(this.OwnerCheckBox_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 36);
            // 
            // salveazaInFisierToolStripMenuItem
            // 
            this.salveazaInFisierToolStripMenuItem.Name = "salveazaInFisierToolStripMenuItem";
            this.salveazaInFisierToolStripMenuItem.Size = new System.Drawing.Size(212, 32);
            this.salveazaInFisierToolStripMenuItem.Text = "Salveaza in fisier";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 1050);
            this.Controls.Add(this.OwnerCheckBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ParolaLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.VarstaTextBox);
            this.Controls.Add(this.ParolaTextBox);
            this.Controls.Add(this.PrenumeTextBox);
            this.Controls.Add(this.NumeTextBox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.VarstaLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PrenumeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PrenumeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label VarstaLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.TextBox PrenumeTextBox;
        private System.Windows.Forms.TextBox ParolaTextBox;
        private System.Windows.Forms.TextBox VarstaTextBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label ParolaLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.CheckBox OwnerCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierToolStripMenuItem;
    }
}