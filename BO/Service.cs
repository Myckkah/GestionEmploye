using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestionEmployes.Metier
{
    public class Service
    {
        #region "Attributs et propriétés"

        private String _code;
        private String _libelle;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>non vide, 5 caractères et en majuscules.</remarks>
        public String Code
        {
            get { return _code; }
            set
            {
                verifCode(value);
                _code = value.ToUpper();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>non vide et première lettre de chaque mot en maj.</remarks>
        public String Libelle
        {
            get { return _libelle; }
            set
            {
                verifLibelle(value);
                _libelle = value.premiereLettreEnMajuscule(' ');
            }
        }
        #endregion

        #region "Constructeurs"
        /// <summary>
        /// construire une instance de Service initialisée
        /// </summary>
        /// <param name="code"></param>
        /// <param name="libelle"></param>
        public Service(String code, String libelle)
        {
            this.Code = code;
            this.Libelle = libelle;
        }
        #endregion

        #region "Comportements publics"
        /// <summary>
        /// Afficher l'état d'une instance de Service
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} {1}", this.Code, this.Libelle);
        }

        /// <summary>
        /// Verifie que le code ne contient ni plus ni moins de 5 caractères.
        /// Et qu'il ne contient que des caractères alphanumériques et " ", "-" et "_"
        /// </summary>
        /// <param name="value"></param>
        public static void verifCode(String value)
        {
            if (String.IsNullOrEmpty(value) || value.Length != 5)
                throw new ApplicationException("Le code doit contenir 5 caractères");
            String regexString = @"^([a-zA-Z0-9]|\s|-|_)+$";
            Regex regex = new Regex(regexString);
            if (!regex.IsMatch(value))
                throw new ApplicationException("Le code ne peut contenir que des caractère alphanumérique, des espaces, et les caractères '-' et '_'");
        }
        #endregion

        #region "Comportements privés"


        /// <summary>
        /// Verifie que le libellé est non vide et qu'il contient 30 caractères maximum.
        /// </summary>
        /// <param name="value"></param>
        private static void verifLibelle(String value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ApplicationException("Le libelle ne peut être vide ou null");
            if (value.Length > 30)
                throw new ApplicationException("Le libelle ne peut contenir plus de 30 caractères");
        }

        #endregion
    }
}
