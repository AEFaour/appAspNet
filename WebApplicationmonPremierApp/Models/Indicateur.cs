using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationmonPremierApp.Models
{
    public class Indicateur
    {
        [Key]
        public int IdIndicateur { get; set; }
        public string Libelle { get; set; }
        public int Valeur { get; set; }
        public DateTime DateEvaluation { get; set; }

        public Module Module { get; set; }

    }
}