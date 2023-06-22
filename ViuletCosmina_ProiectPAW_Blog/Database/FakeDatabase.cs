using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViuletCosmina_ProiectPAW_Blog.Entities;

namespace ViuletCosmina_ProiectPAW_Blog.Database
{
    public static class FakeDatabase
    {
        public static List<Categorie> categorii = new List<Categorie>()
        {
            new Categorie()
            {
                Id=Guid.NewGuid(),
                IsBeauty=true,
                IsFood=false,
                IsStyle=false,
            },
            new Categorie()
            {
                Id=Guid.NewGuid(),
                IsBeauty=false,
                IsFood=true,
                IsStyle=false,
            },
            new Categorie()
            {
                Id=Guid.NewGuid(),
                IsBeauty=false,
                IsFood=false,
                IsStyle=true,
            }
        };

        public static List<Postare> postari = new List<Postare>();
        //{
        //    new Postare()
        //    {
        //        Id=Guid.NewGuid(),
        //        IsStyle=true,
        //       // IsBeauty=false,
        //       // IsFood=false,
        //        Titlu="Casual Outfits",
        //        Text="TINUTA 1\n: -bluza EXIT the new Entrance, " +
        //        "MOCHA – marimea S\n " +
        //        "-fusta H&M, marimea XS\n " +
        //        "-camasa alba Tommy Hilfiger, marimea S\n" +
        //        " -bocanci Dr. Martens, marimea 38",
        //        nrVizualizari=40,
        //        nrComentarii=13
        //    },
        //    new Postare()
        //    {
        //        Id=Guid.NewGuid(),
        //       // IsStyle=false,
        //        IsFood=true,
        //       // IsBeauty=false,
        //        Titlu="Make Green Smoothie With Me",
        //        Text="Reteta mea de Green Smoothie este personalizata si am ales ingredientele care imi plac mie cel mai mult:\n " +
        //        "-broccoli\n " +
        //        "-banana\n" +
        //        "-mango\n" +
        //        "-spirulina\n" +
        //        "-seminte de chia\n" +
        //        "-lapte de migdale\n" ,
        //        nrVizualizari=50,
        //        nrComentarii=10
        //    }
        //};

        public static List<AbonatNou> abonati = new List<AbonatNou>();
        public static List<Comentariu> comentarii = new List<Comentariu>();
    }
}
