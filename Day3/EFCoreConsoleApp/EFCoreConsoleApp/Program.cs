using EFCoreConsoleApp.Data;

namespace EFCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            var db = new OrganizationDbContext();
            var allOrgniazaionInUk = db.Organizations.ToList();

            var filteredList= allOrgniazaionInUk.Where(x => x.Description.Equals("UK")); 






            Console.WriteLine("end");
        }

        private static void CaseStudy1()
        {
            var db = new OrganizationDbContext();
            db.Organizations.Add(new Entity.Organization
            {
                Name = "Koenig2",
                Description = "Mumbai2"
            });

            db.SaveChanges();
        }
    }
}