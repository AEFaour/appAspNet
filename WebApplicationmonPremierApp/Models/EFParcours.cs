namespace WebApplicationmonPremierApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFParcours : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « EFParcours » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « WebApplicationmonPremierApp.Models.EFParcours » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « EFParcours » dans le fichier de configuration de l'application.
        public EFParcours()
            : base("name=EFParcours")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Parcours> Parcours { get; set; }
        public virtual DbSet<Module> Modules { get; set; }

        public System.Data.Entity.DbSet<WebApplicationmonPremierApp.Models.Indicateur> Indicateurs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}