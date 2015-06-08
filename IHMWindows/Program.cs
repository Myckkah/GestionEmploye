using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEmployes.Application;
using GestionEmployes.IHM;
using GestionEmployes.IHM.GestionEmploye;

namespace IHMWindows
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MgtEmploye mgt = MgtEmploye.GetInstance();
            MgtService mgtService = MgtService.getInstance();
            mgtService.AjouterService("RESHU", "Ressources humaines");
            //mgt.AjouterEmploye("Benard", "Mickael", Convert.ToDateTime("30/10/1994"), Convert.ToDateTime("10/12/2014"), Convert.ToDouble(3500) , null, null);
            //mgt.AjouterEmploye("Fillon", "Nicolas", Convert.ToDateTime("10/02/1978"), Convert.ToDateTime("19/02/2014"), Convert.ToDouble(2500), null, null);
            //mgt.AjouterEmploye("Shark", "Nado", Convert.ToDateTime("14/08/1965"), Convert.ToDateTime("14/07/2012"), Convert.ToDouble(1500), null, null);
            Application.Run(new MenuEmploye());
        }
    }
}
