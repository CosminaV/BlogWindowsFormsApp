using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViuletCosmina_ProiectPAW_Blog
{
    public partial class PostareForm : Form
    {
        
        public PostareForm(string categorie)
        {
            InitializeComponent();
            
            if (categorie == "STYLE")
            {
                PostTitleLabel.Visible = true;
                PostTitleLabel.Text = "OUTFIT IDEAS";
                PictureBox1.Visible = true;
                PictureBox1.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\29b3fc35-b558-4ba1-9790-95d31a6ae9b0.jpg");
                PictureBox2.Visible = true;
                PictureBox2.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\6433ec1e-2f38-426e-89f4-2d10379b303f.jpg");
                PostText.Visible = true;
                PostText.Text = "-bluza EXIT the new Entrance, MOCHA – marimea S\n+ link: https://bit.ly/2MJoMHf \n" +
                        "-fusta H & M, marimea XS\n" +
                        "link: https://bit.ly/3rFYDb8 \n" +
                        "-camasa alba Tommy Hilfiger, marimea S\n" + " link: https://bit.ly/3jA0efP \n" +
                        "-bocanci Dr.Martens, marimea 38\n" +
                        "link: https://bit.ly/2Osx4Uj";
                    
            }
            else if (categorie == "BEAUTY")
            {
                PostTitleLabel.Visible = true;
                PostTitleLabel.Text = "RUTINA DE SKINCARE";
                PictureBox1.Visible = true;
               //PictureBox1.Size = new System.Drawing.Size(100, 261);
               //PictureBox1.BorderStyle = BorderStyle.Fixed3D;
                PictureBox1.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\skincare.jpg");
                PictureBox2.Visible = true;
                PictureBox2.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\alpha.jpg");
                PostText.Visible = true;
                PostText.AutoSize = true;
                PostText.Text = "🤍 Rutina de skin-care este oricand un semn de iubire de sine.\n " +
                        "Eu am inceput sa acord o atentie sporita acestui lucru, \n" +
                        "de aproape 2 ani. Mi s-a parut ceva foarte complicat, va \n" +
                        "zic sincer, pentru ca de fel sunt genul care citeste toate \n" +
                        "etichetele, iar in cazul asta… Multe produse, multe ingrediente\n" +
                        ", fiecare cu utilitatea lui. Acum ca mi-am facut foarte clar\n" +
                        "punctul de vedere, pot sa va sugerez sa faceti ca mine: \n" +
                        "incepeti cu NEVOIA, apoi incercati sa va concentrati pe \n" +
                        "REZULTAT. Spre exemplu, eu sunt foarte placut impresionata\n" +
                        " de masca aceasta de la ALPA-H , este pentru curatare si \n" +
                        "detox, potrivita pentru tenul meu, mai ales cand are parte\n" +
                        "de mici “surprize” neplacute. Pe langa asta, reduce inflamatia \n" +
                        "si calmeaza, datorita ingredientului de Aloe Vera.";
            }
            else if (categorie=="FOOD")
            {
                PostTitleLabel.Visible = true;
                PostTitleLabel.Text = "MAKE GREEN SMOOTHIE WITH ME";
                PictureBox1.Visible = true;
                //PictureBox1.Size = new System.Drawing.Size(100, 261);
                //PictureBox1.BorderStyle = BorderStyle.Fixed3D;
                PictureBox1.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\1-1-480x384.png");
                PictureBox2.Visible = true;
                PictureBox2.Image = Image.FromFile(@"C:\Users\TonyMontana\Desktop\VS\paw\ViuletCosmina_ProiectPAW_Blog\2-1.png");
                PostText.Visible = true;
                PostText.AutoSize = true;
                PostText.Text = "Cu totii stim cat de multe beneficii au legumele si fructele verzi,\n" +
                    " in combinatie cu seminte si lapte bogat in proteine. Astazi \n" +
                    "vreau sa va arat reteta mea speciala de Green Smoothie si\n" +
                    " va invit sa il" +
                    "preparati si voi acasa deoarece are multe \n" +
                    "proprietati benefice organismului," +
                    " mai ales daca este servit dimineata, la mic dejun.\n" +
                    " Reteta mea de Green Smoothie este personalizata si am\n" +
                    " ales ingredientele care imi plac mie cel mai mult:\n" +
                    "- broccoli\n+" +
                    "- banana\n+" +
                    "- mango\b+" +
                    "- spirulina\n+" +
                    "- seminte de chia\n+" +
                    "-lapte de migdale";
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var comment = new AddCommentForm();
        //    comment.ShowDialog();
        //}
    }
}
