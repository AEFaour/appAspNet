using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmonPremierApp.Models
{
    public class ModuleView
    {
        public int id { get; set; }
        public string Nom { get; set; }

        public int idParcours { get; set; }
    }
}