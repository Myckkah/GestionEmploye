using System;
using GestionEmployes.Application;
using GestionEmployes.Metier;

namespace GestionEmployes.IHM
{
    public class Menu
    {
        public void AffichageMenu()
        {
            MgtService mgtService = MgtService.getInstance();

            AffichageSqueletteMenu(mgtService);

            ConsoleKeyInfo choixMenu = Console.ReadKey();

            switch (choixMenu.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    AffichageAjout(mgtService);
                    break;
                    
                case ConsoleKey.M:
                    Console.Clear();
                    Affichagemodifier(mgtService);
                    break;

                case ConsoleKey.S:
                    Console.Clear();
                    AffichageSuppression(mgtService);
                    break;

                case ConsoleKey.V:
                    Console.Clear();
                    AffichageViderListe(mgtService);
                    break;

                case ConsoleKey.T:
                    Console.Clear();
                    AffichageTrier(mgtService);
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(1);
                    break;
            }

        }

        public static void AffichageMenu(MgtService mgtService)
        {
            AffichageSqueletteMenu(mgtService);

            ConsoleKeyInfo choixMenu = Console.ReadKey();

            switch (choixMenu.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    AffichageAjout(mgtService);
                    break;

                case ConsoleKey.M:
                    Console.Clear();
                    Affichagemodifier(mgtService);
                    break;

                case ConsoleKey.S:
                    Console.Clear();
                    AffichageSuppression(mgtService);
                    break;

                case ConsoleKey.V:
                    Console.Clear();
                    AffichageViderListe(mgtService);
                    break;

                case ConsoleKey.T:
                    Console.Clear();
                    AffichageTrier(mgtService);
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(1);
                    break;
            }

        }

        private static void AffichageSqueletteMenu(MgtService mgtService)
        {
            Console.WriteLine("--- GESTION DES SERVICES ---");
            for (int i = 1; i <= mgtService.ListeServices.Count; i++)
            {
                foreach (var services in mgtService.ListeServices)
                {
                    Console.WriteLine("{0} : {1} {2}", i, services.Code, services.Libelle);
                    i++;
                }
            }
            Console.WriteLine("MENU -----");
            Console.WriteLine("Service : (A)jouter -- (M)odifier -- (S)upprimer -- (V)ider listes -- (T)rier");
            Console.WriteLine("\nNavigation : Menu (P)rincipal -- (Esc) Quitter");
        }

        private static void AffichageTrier(MgtService mgtService)
        {
            Console.WriteLine(mgtService.ListeServices);
        }

        private static void AffichageViderListe(MgtService mgtService)
        {
            Console.WriteLine("--- Vider toute la liste ---");
            Console.WriteLine("Voulez vous supprimer toute la liste des services ? y/n");
            ConsoleKeyInfo choixYorN = Console.ReadKey();
            if (choixYorN.Key == ConsoleKey.Y)
            {
                mgtService.ListeServices.Clear();
                Console.WriteLine("\nsuppression effectué");
                Console.Clear();
                AffichageMenu(mgtService);
            }
            else
            {
                Console.WriteLine("annulation");
                Console.Clear();
                AffichageMenu(mgtService);
            }


        }

        private static void AffichageSuppression(MgtService mgtService)
        {
            Console.WriteLine("--- Suppression d'un Service ---");
            Console.WriteLine("Recherchez un Service par : (C)ode, (P)osition");
            ConsoleKeyInfo choixService = Console.ReadKey();
            switch (choixService.Key)
            {
                case ConsoleKey.C:
                    Console.Write("ode du service à supprimer : ");
                    string code = Console.ReadLine();
                    mgtService.SupprimerService(code);
                    Console.Clear();
                    AffichageMenu(mgtService);
                    break;

                case ConsoleKey.P:
                    Console.Write("osition du service à supprimer : ");
                    int position = Convert.ToInt32(Console.ReadLine()) - 1;
                    mgtService.SupprimerService(position);
                    Console.Clear();
                    AffichageMenu(mgtService);
                    break;
            } 
        }

        private static void Affichagemodifier(MgtService mgtService)
        {
            Service serviceObtenu = null;
            Console.WriteLine("--- Modifier un Service ---");
            Console.WriteLine("Recherchez un Service par : (C)ode, (P)osition");
            ConsoleKeyInfo choixService = Console.ReadKey();
            switch (choixService.Key)
            {
                case ConsoleKey.C:
                    Console.Write("ode du service recherché : ");
                    string code = Console.ReadLine();
                    serviceObtenu = mgtService.ObtenirService(code);
                    Console.Clear();
                    AffichageMenu(mgtService);
                    break;

                case ConsoleKey.P:
                    Console.Write("osition du service recherché : ");
                    int position = Convert.ToInt32(Console.ReadLine()) - 1;
                    serviceObtenu = mgtService.ObtenirService(position);
                    Console.Clear();
                    AffichageMenu(mgtService);
                    break;
            }

            if (serviceObtenu.Code != null && serviceObtenu.Libelle != null)
            {
                Console.WriteLine("Service :");
                Console.WriteLine("code : {0}",serviceObtenu.Code);
                Console.WriteLine("libelle : {0}", serviceObtenu.Libelle);

                Console.WriteLine("Nouveau libelle : ");
                string newLibelle = Console.ReadLine();

                mgtService.ModifierService(serviceObtenu, newLibelle, serviceObtenu.Code);
                Console.WriteLine("Modification effectuée");
                Console.Clear();
                AffichageMenu(mgtService);

            }
            
            
            
        }

        private static void AffichageAjout(MgtService mgtService)
        {
            Console.WriteLine("--- Ajouter un service ---");
            Console.Write("code : ");
            string code = Console.ReadLine();
            Console.Write("\nlibelle : ");
            string libelle = Console.ReadLine();

            mgtService.AjouterService(code, libelle);

            Console.WriteLine("Ajout Terminé\nRETOUR MENU");
            Console.Clear();
            AffichageMenu(mgtService);
        }
    }
}
