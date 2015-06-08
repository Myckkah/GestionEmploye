using GestionEmployes.Metier;
using System;
using System.ComponentModel;
using System.Linq;

namespace GestionEmployes.Application
{
    public class MgtService
    {

        private BindingList<Service> listeServices;

        #region "Singleton"

        static private MgtService instance;

        private MgtService()
        {
            listeServices = new BindingList<Service>();
        }

        /// <summary>
        /// Méthode permettant de récupérer la seule référence du manager de Service
        /// </summary>
        /// <returns></returns>
        static public MgtService getInstance()
        {
            if (instance == null)
                instance = new MgtService();

            return instance;
        }

        #endregion

        public BindingList<Service> ListeServices
        {
            get
            {
                return listeServices;
            }
            set { listeServices = value; }
        }

        public void AjouterService(string code, string libelle)
        {
            if (this.ObtenirService(code) != null)
            {
                throw new ApplicationException(String.Format("Le code ({0}) existe déjà.", code));
            }
            else
            {
                // Vérification si le libellé n'existe pas :
                if (!IsDoublonLibelle(libelle))
                {
                    Service service = new Service(code, libelle);
                    listeServices.Add(service);
                }
            }
        }

        /// <summary>
        /// Retour False si le libellé n'est pas trouvé, ou lève une
        /// ApplicationException dans le cas contraire.
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns></returns>
        private Boolean IsDoublonLibelle(String libelle)
        {
            Boolean retour = ListeServices.Any(item => item.Libelle.ToUpper().Equals(libelle.ToUpper()));
            if (retour)
                throw new ApplicationException(String.Format("Le libelle ({0}) existe déjà.", libelle));

            return false;
        }


        public Service ObtenirService(String code)
        {
            // Vérification de la validité du code : 
            Service.verifCode(code);
            // Pas d'exception, on recherche le service : 
            Service retourService = null;
            foreach (Service item in ListeServices)
            {
                if (item.Code.Equals(code.ToUpper()))
                    retourService = item;
            }

            return retourService;

        }

        public Service ObtenirService(int position)
        {
            if (position >= 0 && position < listeServices.Count())
                return listeServices.ElementAt(position);
            else
                throw new ApplicationException("La position est incorrecte");
        }


        public void SupprimerService(String code)
        {
            // Recherche du service : 
            Service s = this.ObtenirService(code);

            if (s != null)
                this.SupprimerService(s);
            else
                throw new ApplicationException("Le code est incorrecte");
        }

        public void SupprimerService(Service s)
        {
            if (listeServices.Contains(s))
                listeServices.Remove(s);
            else
                throw new ApplicationException("Le service n'existe plus.");
        }

        public void SupprimerService(int position)
        {
            if (position >= 0 && position < listeServices.Count())
                listeServices.RemoveAt(position);
            else
                throw new ApplicationException("La position est incorrecte");
        }

        public void ModifierService(Service s, String libelle, String code = null)
        {
            if (listeServices.Contains(s))
            {
                // Vérification code
                if (code != null && !s.Code.Equals(code.ToUpper()) && ObtenirService(code) != null)
                    throw new ApplicationException("Le code existe déjà.");
                else
                {
                    // Vérification de l'existance du libellé si on décide de le modifier
                    if (s.Libelle != libelle)
                        IsDoublonLibelle(libelle);

                    string oldLibelle = s.Libelle;
                    try
                    {
                        s.Libelle = libelle;
                        if (code != null)
                            s.Code = code;
                    }
                    catch (Exception ex)
                    {
                        s.Libelle = oldLibelle;
                        throw ex;
                    }
                }
            }
            else
                throw new ApplicationException("Le service n'existe plus.");
        }

        public static void Sauvegarder(string path, BindingList<Service> liste)
        {
            BindingList<string> listeSauvegardee = new BindingList<string>();

            foreach (var service in liste)
            {
                listeSauvegardee.Add(service.Code+";"+service.Libelle);
            }

            ModOutils.Ecrire(path, listeSauvegardee);
        }


        public BindingList<Service> Importer(string path)
        {
            var newListeService = new BindingList<Service>();
            foreach (var ligne in ModOutils.Lire(path))
            {
                string[] service = ligne.Split(';');
                newListeService.Add(new Service(service[0], service[1]));
            }

            return newListeService;
        }
    }
}
