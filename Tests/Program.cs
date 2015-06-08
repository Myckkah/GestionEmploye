using GestionEmployes.Application;
using GestionEmployes.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //testPersonne();
            //testEmploye();

            

            //testCRUDService();

            //Console.ReadKey();
        }

        private static void testCRUDService()
        {

            MgtService mgt = MgtService.getInstance();

            Console.WriteLine("Création de service :");

            mgt.AjouterService("dirge", "Direction Générale");

            try
            {
                Service s = mgt.ObtenirService("dirge");

                Console.WriteLine(String.Format("Service {0} {1}", s.Code, s.Libelle));
                     }
            catch (ApplicationException ex)
            {

                Console.WriteLine(ex.Message);
            }
            try
            {
                mgt.AjouterService("COMPT", "comptabilité");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                mgt.AjouterService("test5", "comptabilité");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                // Test ajout avec code identique
                mgt.AjouterService("dirge", "Test Exception");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Service s = mgt.ObtenirService("NONEX");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                mgt.SupprimerService("dirge");
                Service s = mgt.ObtenirService("dirge");
                if (s != null)
                {
                    throw new Exception();
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                mgt.SupprimerService(90);
                Service s = mgt.ObtenirService("dirge");
                if (s != null)
                {
                    throw new Exception();
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        private static void testPersonne()
        {
            ///*
            // * Variable objet
            // */
            //Personne p = null; 
            ///*
            // * Instanciation d'un objet en mémoire
            // * Utilisation du constructeur par défaut
            // * L'objet est référencé par la variable objet
            // */
            //p = new Personne();
            ///*
            // * L'objet peut être utilisé
            // */
            //p.Nom = "HADDOCK";
            //p.Prenom = "Archibal";
            //p.DateNaissance = new DateTime(1924,2,25);
            //Console.WriteLine(p.Nom);
            ///*
            // * Héritage implicite avec la classe Object
            // */
            //Console.WriteLine(p.GetHashCode() + " - " + p.GetType().Name + " - " + p.ToString());
            ///*
            // * Déréférencer l'objet : l'objet est détruisable par le Garbage Collector
            // */
            //p = null;


            //p = new Personne();
            //p.Nom = "tournesol";
            //Console.WriteLine(p.Nom);

            //p = new Personne("tournesol", "Tryphon", new DateTime(1920, 6, 20));
            //Console.WriteLine("{0} {1} {2}",p.Identifiant, p.Nom,p.Prenom);


            //try
            //{
            //    p.Nom = "";
            //}
            //catch (ApplicationException ae)
            //{
            //    Console.WriteLine(ae.Message);
            //}
            ///*
            // * l'état de l'objet p n'a pas changé
            // */
            //Console.WriteLine("{0} {1} {2}", p.Identifiant, p.Nom, p.Prenom);


            //Console.WriteLine(p.affichage());
            //Console.WriteLine(p.affichage(true));

            //p = new Personne("Rackham", "le-rouge", new DateTime(1926, 12, 21));
            //Console.WriteLine(p.affichage());


        }

        private static void testEmploye()
        {
            Employe e = new Employe();
            Console.WriteLine(e.disBonjour());

            e.Nom = "durand";
            e.Prenom = "jean-paul";

            e.DateNaissance = DateTime.Parse("8/05/1987");
            e.Identifiant = Guid.NewGuid();


            Console.WriteLine("Informations de l'objet Employe :");
            Console.WriteLine(e.affichage(OptionsAffichageEmploye.AvecAge));
            Console.WriteLine();

            try
            {
                Employe e2 = new Employe(Guid.NewGuid(), "toto", "albert", DateTime.Parse("12/7/1985"), 25462D, DateTime.Parse("12/6/2005"));
                Console.WriteLine(e2.affichage(OptionsAffichageEmploye.Tout));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                DateTime.Parse("8/05/1987");
            }
            catch (FormatException)
            {
                Console.WriteLine("erreur sur format de la date");
            }
            catch (Exception)
            {
                Console.WriteLine("erreur de date");
            }

            try
            {
                e.DateNaissance = DateTime.Parse("8/05/1987");
                e.DateEmbauche = DateTime.Parse("01/02/2011");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                e.DateNaissance = DateTime.Parse("01/02/2011");
                e.DateEmbauche = DateTime.Parse("8/05/1987");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                e.DateNaissance = DateTime.Parse("8/05/1987");
                e.DateEmbauche = DateTime.Parse("04/01/2012");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                e.DateNaissance = DateTime.Parse("4/1/1994");
                e.DateEmbauche = DateTime.Parse("03/01/2012");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                e.Salaire = 0D;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                e.Salaire = -1D;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
