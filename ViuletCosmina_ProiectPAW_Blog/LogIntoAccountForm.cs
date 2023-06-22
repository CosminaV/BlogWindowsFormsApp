using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ViuletCosmina_ProiectPAW_Blog.Entities;
using ViuletCosmina_ProiectPAW_Blog.Database;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class LogIntoAccountForm : Form
    {
        static int attempts = 3;
        static int tries = 0;
        public LogIntoAccountForm()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (emailTb.Text != "" && ParolaTb.Text != "" && UsernameTb.Text != "")
            {
                int nrCaractere = ParolaTb.Text.Length;
                if (UsernameTb.Text.Any(char.IsUpper))
                    errorProvider1.SetError(UsernameTb, "Username-ul trebuie sa fie cu litere mici");
                else if ((!emailTb.Text.Contains('@') || !emailTb.Text.Contains('.')))
                    errorProvider1.SetError(emailTb, "Formatul email-ului nu este corect");
                else if (nrCaractere < 7 || nrCaractere > 15)
                    errorProvider1.SetError(ParolaTb, "Parola trebuie sa contina intre 7 si 15 caractere!");
                else
                {
                    var entity = new Abonat(UsernameTb.Text, emailTb.Text, ParolaTb.Text);
                    if(FakeDatabase.abonati.Count(x => x.Email==entity.Email 
                                            && x.Password==entity.Password
                                            &&x.Username==entity.Username)>0)
                    {
                        attempts = 0;
                        MessageBox.Show("Te-ai logat cu succes");
                        var blog = new MyBlogForm();
                        blog.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorProvider1.Clear();
                        attempts--;
                        MessageBox.Show("Mai ai " + Convert.ToInt32(attempts) + " incercari");
                        if (attempts == 0)
                        {
                            tries++;
                            if (tries == 2)
                                Application.Exit();
                            else
                            {
                                MessageBox.Show("Ai incercat de prea multe ori sa te loghezi! Incearca din nou peste 5 secunde.");
                                Thread.Sleep(5000);
                                attempts = 3;
                            }
                        }
                    }
                }
            }
            
        }

        private void ParolaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                e.Handled = true;
                button1_Click_1(sender, null);           
            }
        }

      
    }
    public class MyException2 : Exception
    {
        public MyException2() : base()
        {

        }

        public MyException2(string message) : base(message)
        {

        }

    }
}
