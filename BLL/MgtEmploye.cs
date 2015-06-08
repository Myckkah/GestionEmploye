using GestionEmployes.Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mime;

namespace GestionEmployes.Application
{
    public class MgtEmploye
    {
        #region Attributs
        private BindingList<Employe> _listeEmploye;

        public BindingList<Employe> EmployesListe
        {
            get { return _listeEmploye; }
            set { _listeEmploye = value; }
        }

        #endregion

        #region "Singleton"
        private static MgtEmploye _instance;

        private MgtEmploye()
        {
            _listeEmploye = new BindingList<Employe>();
        }

        /// <summary>
        /// Méthode permettant de récupérer la seule référence du manager de Employe
        /// </summary>
        /// <returns></returns>
        static public MgtEmploye GetInstance()
        {
            if (_instance == null)
                _instance = new MgtEmploye();

            return _instance;
        }

        #endregion

        #region Fonctions
        #region Ajouter un Employé
        public Employe AjouterEmploye(Employe e)
        {
            EmployesListe.Add(e);
            return e;
        }

        public Employe AjouterEmploye(string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire, Service service, Employe chef)
        {
            Employe e = new Employe(Guid.NewGuid(), nom, prenom, dateNaissance, salaire, dateEmbauche, service, chef);
            EmployesListe.Add(e);
            return e;
        }

        public Employe AjouterEmploye(string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire, Service service, Employe chef, Image photo)
        {
            Employe e = new Employe(Guid.NewGuid(), nom, prenom, dateNaissance, salaire, dateEmbauche, service, chef, photo);
            EmployesListe.Add(e);
            return e;
        }
        #endregion

        #region Modifier un Employé
        public Employe ModifierEmploye(Employe eorigine, string nom = null, string prenom = null, DateTime dateNaissance = default(DateTime), DateTime dateEmbauche = default(DateTime), double salaire = double.MinValue, Service service = null, Employe chef = null)
        {
            return new Employe();
        }
        public Employe ModifierEmploye(int id, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire, int numService, Employe chef)
        {
            return new Employe();
        }
        public Employe ModifierEmploye(int id, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire, int numService, Employe chef, Image photo)
        {
            return new Employe();
        }
        #endregion

        public Employe ObtenirEmploye(int position)
        {
            if (position >= 0 && position <= EmployesListe.Count)
            {
                return EmployesListe.ElementAt(position);
            }
            else
            {
                throw new ApplicationException("La position est incorrecte");
            }
        }

        public Employe ObtenirEmploye(string nom, string prenom)
        {
            Personne.verifNom(nom);
            Employe retourEmploye = null;
            foreach (var employe in EmployesListe.Where(employe => employe.Nom.Equals(nom.ToUpper()) && employe.Prenom.Equals(prenom)))
            {
                retourEmploye = employe;
            }
            return retourEmploye;
        }

        public List<Employe> Rechercher(CritereRechercheEmploye choixRecherche, object valeurRecherche)
        {
            return new List<Employe>();
        }

        public void SupprimerEmploye(Employe employe)
        {
            if (EmployesListe.Contains(employe))
            {
                EmployesListe.Remove(employe);
            }
        }

        public void SupprimerEmploye(string nom, string prenom)
        {
            Employe employe = ObtenirEmploye(nom, prenom);
            if (employe != null)
            {
                SupprimerEmploye(employe);
            }
        }

        public override String ToString()
        {
            return "";
        }

        public void Trier(CritereEmploye choixTri)
        {
        }

        public static void Sauvegarder(string path, BindingList<Employe> listeEmploye)
        {
            BindingList<string> listeSauvegarde = new BindingList<string>();
            foreach (Employe employe in listeEmploye)
            {
                listeSauvegarde.Add(employe.Identifiant+";"+employe.Nom+";"+employe.Prenom+";"+employe.DateNaissance+";"+employe.Salaire+";"+
                    employe.DateEmbauche);
            }
            ModOutils.Ecrire(path, listeSauvegarde);
        }

        public static BindingList<Employe> Charger(string path)
        {
            MgtService mgtService = MgtService.getInstance();
            MgtEmploye mgtEmploye = GetInstance();
            BindingList<Employe> newListEmployes = new BindingList<Employe>();
            foreach (string ligne in ModOutils.Lire(path))
            {
                string[] employe = ligne.Split(';');
                newListEmployes.Add(new Employe(new Guid(employe[0]), employe[1], employe[2], Convert.ToDateTime(employe[3]), Convert.ToDouble(employe[4]), Convert.ToDateTime(employe[5]), mgtService.ObtenirService(employe[6]), mgtEmploye.ObtenirEmploye(employe[7], employe[8])));
            }
            return newListEmployes;
        }

        #region Comparer deux Employés
        public int CompareParDateNaissance(Employe e1, Employe e2) { return 0; }
        public int CompareParNom(Employe e1, Employe e2) { return 0; }
        public int CompareParPrenom(Employe e1, Employe e2) { return 0; }
        public int CompareParSalaire(Employe e1, Employe e2) { return 0; }
        public int CompareParService(Employe e1, Employe e2) { return 0; }
        public int CompareParSalaireBA2NM(Employe e1, Employe e2) { return 0; }
        public int CompareParNM2BA(Employe e1, Employe e2) { return 0; }

        #endregion
        #endregion
    }
}
