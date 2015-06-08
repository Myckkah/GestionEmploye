using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployes.Metier
{
    /// <summary>
    /// Cette classe represente les informations à gérer sur la notion d'individu
    /// </summary>
    /// <remarks>Cette classe est abstraite</remarks>
    public abstract class Personne
    {

        #region "Les attributs"
        /**
         * Les attributs 
         */
        private String _nom;
        private String _prenom;
        private DateTime _ddn;

        #endregion

        #region "Les propriétés"
        /**
         * Les propriétés d'accès aux attributs
         */
        public String Nom
        {
            get { return _nom; }
            set {
                /*
                 * Valider les données avant de modifier l'état
                 */
                verifNom(value);
                _nom = value.ToUpper();
            }
        }

        public String Prenom
        {
            get { return _prenom; }
            set { 
                /*
                 * appel à la méthode d'extension
                 */
                _prenom = value.premiereLettreEnMajuscule('-'); 
            }
        }

        public DateTime DateNaissance
        {
            get { return _ddn; }
            set {

                verifDateNaissance(value);
                _ddn = value;
            }
        }
        
        /**
         * propriété en lecture seule
         */
        public int Age
        {
            get { return ModOutils.AnneeDiff(this.DateNaissance, DateTime.Now); }
        }

        /**
         * propriété auto-implémentée
         */
        public Guid Identifiant { get; set; }

        #endregion

        #region "Constructeurs et destructeur"
        /// <summary>
        /// constructeur par défaut de la classe Personne
        /// </summary>
        public Personne()
            : base() //appel au constructeur de la super classe (sous entendu)
        {
            /*
             * code supplémentaire à executer lors de la construction d'un objet Personne
             */
            this.Identifiant = Guid.NewGuid();
        }

        /// <summary>
        /// constructeur surchargé
        /// </summary>
        /// <param name="identifiant"></param>
        public Personne(Guid identifiant)
            : base()
        {
            /*
             * code supplémentaire à executer lors de la construction d'un objet Personne
             */
            this.Identifiant = identifiant;
        }

        /// <summary>
        /// constructeur surchargé
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        public Personne(String nom, String prenom, DateTime dateNaissance)
            :this() //appel explicite au constructeur par défaut de la classe
        {
            /*
             * code supplémentaire à executer lors de la construction d'un objet Personne
             */
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        /// <summary>
        /// constructeur surchargé
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        public Personne(Guid identifiant, String nom, String prenom, DateTime dateNaissance)
            : this(identifiant)
        {
            /*
             * code supplémentaire à executer lors de la construction d'un objet Personne
             */
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        /// <summary>
        /// Destructeur de la classe Personne
        /// Appelé implicitement par le Garbage Collector
        /// </summary>
        ~Personne()
        {
            /*
             * code exécuté implicitement lors de la destruction
             * de l'objet en mémoire par le Garbage collector
             */
        }

        public void dispose()
        {
            /*
            * code à exécuter explicitement lors du déréférencement d'un objet
            */

            /*
             * Signaler au Garbage Collector que le travail à déjà été fait
             * pour cette instance
             */
            GC.SuppressFinalize(this);
        }

        #endregion

        #region "Méthodes privées"

        /// <summary>
        /// Vérifie la validité d'une chaine proposée pour le nom d'uine instance de Personne
        /// </summary>
        /// <param name="nom">chaine à vérifier</param>
        /// <remarks>cette méthode peur devenir static, évolution à partir du cours</remarks>
        public static void verifNom(String nom)
        {
            if (String.IsNullOrEmpty(nom))
                throw new ApplicationException("Le nom ne peut pas être vide ou null");
        }

        /// <summary>
        /// Vérifie la validité de la date proposée en la comparant à la date actuelle.
        /// Pour être valide la date proposée doit être antérieure à la date courante.
        /// En cas de date invalide, la méthode lève une exception.
        /// </summary>
        /// <param name="dateNaissance"></param>
        /// <remarks>cette méthode peur devenir static, évolution à partir du cours</remarks>
        public static void verifDateNaissance(DateTime dateNaissance)
        {
            if (dateNaissance >= DateTime.Now)
                throw new ApplicationException("La date de naissance ne peut pas être supérieure à la date courante.");
        }

        #endregion

        #region "Méthodes publiques"

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual String affichage()
        {
            return this.Nom + " - " + this.Prenom;
        }

        /// <summary>
        /// méthode surchargée et substituable
        /// Proposée une autre façon d'afficher...
        /// </summary>
        /// <param name="avecAge"></param>
        /// <returns></returns>
        public virtual String affichage(Boolean avecAge)
        {
            return this.affichage() + (avecAge ? String.Format(", {0} ans", this.Age) : String.Empty);

        }

        /// <summary>
        /// méthode substituée
        /// Spécialiser le comportement de ToString à la classe Personne
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /*
             * on complete l'action de la méthode ToString de la classe Object
             */
            //return base.ToString() + " : " + this.affichage();
            /*
             * on remplace l'action de la méthode ToString de la classe Object
             */
            return this.affichage();
        }
        #endregion

        #region "Méthodes abstraites"
        /// <summary>
        /// Prototype du service : Comment dire bonjour
        /// </summary>
        /// <returns></returns>
        public abstract string disBonjour();

        #endregion
    }
}
