using SSS_2022_projekat.Model;
using SSS_2022_projekat.Windows;
using System.ComponentModel;

namespace SSS_2022_projekat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            FitnesCentar.Instance.UcitajAdrese();
            FitnesCentar.Instance.UcitajPlatnuKarticu();
            FitnesCentar.Instance.UcitajAdmina();
            FitnesCentar.Instance.UcitajTrenera();
            FitnesCentar.Instance.UcitajKlijenta();
            FitnesCentar.Instance.UcitajTrening();
            FitnesCentar.Instance.UcitajOcene();        
            FitnesCentar.Instance.UcitajFitnesCentar();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
                       


        }
    }
}