using System;
using System.Drawing;
using System.Text;

namespace GestionEmployes.Metier
{
    /// <summary>
    /// Classe spécialisant un individu en employé
    /// </summary>
    public class Employe : Personne
    {
        #region "Attributs et propriétés"
        private Double _salaire;
        private DateTime _dateEmbauche;
        private Service _service;
        private Image _photo;
        private Employe _chef;

        public Double Salaire
        {
            get { return _salaire; }
            set
            {
                verifSalaire(value);
                _salaire = value;
            }
        }

        public DateTime DateEmbauche
        {
            get { return _dateEmbauche; }
            set
            {
                verifDate(this.DateNaissance, value);
                _dateEmbauche = value;
            }
        }

        public Service Service
        {
            get { return _service; }
            set { _service = value; }
        }

        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public Employe Chef
        {
            get { return _chef; }
            set { _chef = value; }
        }

        public int Anciennete
        {
            get { return ModOutils.AnneeDiff(this.DateEmbauche, DateTime.Now); }
        }

        #endregion

        #region "Constructeurs"
        /// <summary>
        /// le constructeur par défaut
        /// </summary>
        public Employe()
            : base()
        {
        }

        /// <summary>
        /// construire une instance de Employe initialisée
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="salaire"></param>
        /// <param name="dateEmbauche"></param>
        /// <param name="service"></param>
        public Employe(Guid identifiant, String nom, String prenom, DateTime dateNaissance,
                        Double salaire, DateTime dateEmbauche, Service service = null, Employe chef = null, Image photo = null)
            : base(identifiant, nom, prenom, dateNaissance)
        {
            this.Salaire = salaire;
            this.DateEmbauche = dateEmbauche;
            this.Service = service;
        }


        #endregion

        #region "Comportements publics"

        /// <summary>
        /// Substitution de la méthode affichage de la classe Personne
        /// </summary>
        /// <remarks>Ajouter le mot clé vitual sur la définition de la méthode dans Personne</remarks>
        /// <returns></returns>
        public override string affichage()
        {
            return base.affichage() + " - salaire : " + this.Salaire.ToString("c");
        }

        /// <summary>
        /// Surcharge de la méthode affichage
        /// </summary>
        /// <param name="optionAffichage"></param>
        /// <returns></returns>
        public String affichage(OptionsAffichageEmploye optionAffichage)
        {
            StringBuilder employeString = new StringBuilder();
            switch (optionAffichage)
            {
                case OptionsAffichageEmploye.Tout:
                    employeString.Append(base.affichage(true)).
                        Append(" - ancienneté : ").Append(this.Anciennete).Append(" an(s)").
                        Append(" - salaire : ").Append(this.Salaire.ToString("c"));
                    break;
                case OptionsAffichageEmploye.AvecAge:
                    employeString.Append(base.affichage(true));
                    break;
                case OptionsAffichageEmploye.AvecAnciennete:
                    employeString.Append(base.affichage()).
                        Append(" - ancienneté : ").Append(this.Anciennete).Append(" an(s)");
                    break;
                case OptionsAffichageEmploye.AvecSalaire:
                    employeString.Append(base.affichage()).
                        Append(" - salaire : ").Append(this.Salaire.ToString("c"));
                    break;
                default:
                    employeString.Append(base.affichage());
                    break;
            }
            return employeString.ToString();
        }

        #endregion

        #region "Comportements privés"

        /// <summary>
        /// Le salaire est positif
        /// </summary>
        /// <param name="value"></param>
        private static void verifSalaire(Double value)
        {
            if (value < 0)
                throw new ApplicationException("Le salaire doit être positif.");
        }

        /// <summary>
        /// Une date embauche cohérente par rapport à la date de naissance
        /// une date embauche ne peut peut pas être postérieure à aujourd'hui
        /// l'employe doit être majeur
        /// </summary>
        /// <param name="valueInf"></param>
        /// <param name="valueSup"></param>
        private static void verifDate(DateTime valueInf, DateTime valueSup)
        {
            if (DateTime.Compare(valueInf, valueSup) >= 0)
                throw new ApplicationException("La date d'embauche ne peut pas être antérieure à la date de naissance !");
            else if (valueSup > DateTime.Now)
                throw new ApplicationException("La date d'embauche ne peut pas être postérieure à la date courante !");
            else if (ModOutils.AnneeDiff(valueInf, valueSup) < 18)
                throw new ApplicationException("Employe mineur à la date d'embauche !");
        }
        #endregion

        /// <summary>
        /// implementation obligatoire de la méthode abstraite définie dans Personne
        /// </summary>
        /// <returns></returns>
        public override string disBonjour()
        {
            StringBuilder message = new StringBuilder("Bonjour, je suis un employé. ");
            if (String.IsNullOrEmpty(this.Nom))
                message.Append("Mon nom n'est pas encore renseigné.");
            else
                message.Append("Mon nom est ").Append(this.Nom);
            return message.ToString();
        }
    }

    /// <summary>
    /// Enumérer les options d'affichage d'un employé
    /// </summary>
    public enum OptionsAffichageEmploye
    {
        Simple = 1,
        AvecAge = 2,
        AvecSalaire = 3,
        AvecAnciennete = 4,
        Tout = 5,
        Defaut = 0
    }
}
