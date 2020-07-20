using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmonPremierApp.Models
{
    public class Parcours
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Slogan { get; set; }

        //Logo
        public string Logo { get; set; }
    }
}