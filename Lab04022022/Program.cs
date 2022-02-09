using Lab04022022.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04022022
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            using (MyOlympiadContext db =new MyOlympiadContext())
            {
               /* db.Seasons.Add(new Season() { SeasonName = "Summer" });
                db.Seasons.Add(new Season() { SeasonName = "Winter" });
                db.Countrys.Add(new Country() { CountryName = "Ukraine" });
                db.Countrys.Add(new Country() { CountryName = "Russia" });
                db.Countrys.Add(new Country() { CountryName = "Rome" });
                db.SportViews.Add(new SportView() { SportName = "Swimming" });
                db.SportViews.Add(new SportView() { SportName = "Boxing" });
                db.SportViews.Add(new SportView() { SportName = "Wrestling" });
                db.SportViews.Add(new SportView() { SportName = "Running" });
                db.PartyInfos.Add(new PartyInfo() {FullName="Ivan Ivanov",DateBirth=DateTime.Now });
                db.SaveChanges();*/
            }





        }




    }
}
