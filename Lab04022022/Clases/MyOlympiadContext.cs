using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04022022.Clases
{
    class MyOlympiadContext : DbContext
    {
        public MyOlympiadContext():base("ConnStr")
        {
            Database.SetInitializer<MyOlympiadContext>(new MyInitializer());
        }

        public DbSet<Olympiad> Olympiads { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SportView> SportViews { get; set; }
        public DbSet<SportsSetings> SportsSetingss { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<PartyInfo> PartyInfos { get; set; }
    }
    class MyInitializer:DropCreateDatabaseIfModelChanges<MyOlympiadContext>
    {
        protected override void Seed(MyOlympiadContext db)
        {
            //db.Seasons.Add(new Season() { SeasonName = "Summer" });
        }
    }
}
