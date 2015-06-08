using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployes
{
    public abstract class ModOutils
    {
        /// <summary>
        /// Renvoie la différence en nombre d'années complètes entre deux dates.
        /// </summary>
        /// <param name="DateDebut">date de début de la période</param>
        /// <param name="DateFin">date de fin de la période</param>
        /// <returns>Entier représentant la différence en nombre d'années</returns>
        public static int AnneeDiff(DateTime DateDebut, DateTime DateFin)
        {
            int anneeDiff;
            if (DateFin.DayOfYear < DateDebut.DayOfYear) {
                anneeDiff = DateFin.Year - DateDebut.Year - 1;
            }
            else {
                anneeDiff = DateFin.Year - DateDebut.Year;
            }
            return anneeDiff;

        }

        public static void Ecrire(string path, BindingList<string> liste)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var ligne in liste)
            {
                file.WriteLine(ligne);
            }
            file.Close();
        }

        public static BindingList<string> Lire(string path)
        {
            string ligne;
            var liste = new BindingList<string>();
            StreamReader file = new StreamReader(path);
            while ((ligne = file.ReadLine()) != null)
            {
                liste.Add((ligne));
            }

            file.Close();
            return liste;
        }
    }

   /// <summary>
   /// Classe permettant de définir les Extensions
   /// </summary>
   public static class Extensions
   {
       /// <summary>
       /// Methode d'extension de la classe String
       /// Mettre la première lettre de chaque mot en majuscule. Le délimiteur
       /// de chaque mot est précisé.
       /// </summary>
       /// <param name="texte"></param>
       /// <param name="delimiteur"></param>
       /// <returns></returns>
       /// <remarks>La classe doit être static</remarks>
       public static String premiereLettreEnMajuscule(this String texte, char delimiteur)
       {
           Boolean maj = true;
           String nouveauTexte = "";
           for (int i = 0; i < texte.Length; i++)
           {
               if (maj)
                   nouveauTexte = nouveauTexte + char.ToUpper(texte.ElementAt(i));
               else
                   nouveauTexte = nouveauTexte + char.ToLower(texte.ElementAt(i));
               maj = (texte.ElementAt(i) == delimiteur);
           }

           return nouveauTexte;
       }
   }
}
