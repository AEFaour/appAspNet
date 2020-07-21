using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationmonPremierApp.Models
{
    public class Module
    {
        [Key]
        public int id { get; set; }
        public string Nom { get; set; }

        // proprité de Navigation

        public Parcours Parcours { get; set; }
        public virtual ICollection<Indicateur> Indicateurs { get; set; }
    }
}