using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationmonPremierApp.Models
{
    public class Parcours
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Slogan { get; set; }

        //Logo
        public string Logo { get; set; }
    }
}