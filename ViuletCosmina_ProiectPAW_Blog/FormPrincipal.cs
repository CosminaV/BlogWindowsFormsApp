using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViuletCosmina_ProiectPAW_Blog.Database;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            incarcaDatele();
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIntoAccountForm myBlog = new LogIntoAccountForm();
            myBlog.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (NumeTextBox.Text == "")
            {
                errorProvider1.SetError(NumeTextBox, "Introduceti numele!");
            }
            else if (PrenumeTextBox.Text == "")
            {
                errorProvider1.SetError(PrenumeTextBox, "Introduceti prenumele!");
            }
            else if (UsernameTextBox.Text == "")
            {
                errorProvider1.SetError(UsernameTextBox, "Introduceti username-ul!");
            }
            else if ((!EmailTextBox.Text.Contains('@') || !EmailTextBox.Text.Contains('.')))
            {
                errorProvider1.SetError(EmailTextBox, "Formatul email-ului nu este corect!");
            }
            else if (VarstaTextBox.Text == "")
            {
                errorProvider1.SetError(VarstaTextBox, "Introduceti varsta!");
            }
            else if (SexComboBox.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(SexComboBox, "Alegeti sexul dvs!");
            }
            else
            {
                try
                {
                    var abonatNou = new AbonatNou();
                    abonatNou.Username = UsernameTextBox.Text;
                    abonatNou.Email = EmailTextBox.Text;
                    abonatNou.Password = ParolaTextBox.Text;
                    abonatNou.Nume = NumeTextBox.Text;
                    abonatNou.Prenume = PrenumeTextBox.Text;
                    abonatNou.Varsta = Convert.ToInt32(VarstaTextBox.Text);
                    abonatNou.Sex = SexComboBox.Text;
                    abonatNou.AnAbonare = System.DateTime.Now.Year;
                    MessageBox.Show(abonatNou.ToString());
                    FakeDatabase.abonati.Add(abonatNou);
                    string str = abonatNou.Nume + " " + abonatNou.Prenume + " " + abonatNou.Email + " " +
                        abonatNou.Username+" "+abonatNou.Password + " " + abonatNou.Varsta + " " + abonatNou.Sex+" "+abonatNou.AnAbonare;
                    File.AppendAllText("abonati.txt", str + Environment.NewLine);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                    NumeTextBox.Clear();
                    PrenumeTextBox.Clear();
                    UsernameTextBox.Clear();
                    ParolaTextBox.Clear();
                    EmailTextBox.Clear();
                    VarstaTextBox.Clear();
                    SexComboBox.ResetText();
                }
            }
        }

        private void OwnerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var frm = new CategoriesDatabaseForm();
            frm.ShowDialog();
            //this.Hide();
        }

        private void ParolaTextBox_Validated(object sender, EventArgs e)
        {
            //MessageBox.Show("Am validat!");
        }

        private void ParolaTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int nrCaractere = ParolaTextBox.Text.Length;
                if(nrCaractere < 7 || nrCaractere > 15)
                {
                    throw new MyException1("Parola trebuie sa contina intre 7 si 15 caractere!");
                    //MessageBox.Show("Parola trebuie sa contina intre 7 si 15 caractere!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SexComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
                RegisterButton_Click(sender, null);
            }
        }

        private void incarcaDatele()
        {
            StreamReader sr = new StreamReader("abonati.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                var a = new AbonatNou();
                a.Nume = linie.Split(' ')[0];
                a.Prenume = linie.Split(' ')[1];
                a.Email = linie.Split(' ')[2];
                a.Username = linie.Split(' ')[3];
                a.Password = linie.Split(' ')[4];
                a.Varsta = Convert.ToInt32(linie.Split(' ')[5]);
                a.Sex = linie.Split(' ')[6];
                a.AnAbonare = Convert.ToInt32(linie.Split(' ')[7]);
                FakeDatabase.abonati.Add(a);
            }
            sr.Close();
        }
    }

    public class MyException1 : Exception
    {
        public MyException1():base()
        {

        }

        public MyException1(string message):base(message)
        {

        }

    }
}
