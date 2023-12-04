using FirstAppWithDB.Context;
using FirstAppWithDB.Models;
using Microsoft.VisualBasic;

class Program
{
    public static void Main(string[] args)
    {
        using (VBContext context = new VBContext(@"data source=(localdb)\mssqllocaldb;database=efblogdbtest;trusted_connection=true"))
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("code first db approach done.");
            //var data = context.Emp.ToList();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id + "  " + item.Name + "  " + item.Address);
            //}


            ////Emp emp = new Emp {  Name = "EF Demo", Address = "EF Demo" };

            ////context.Emp.Add(emp);
            ////context.SaveChanges();//This mehtod will save in db

            //Console.WriteLine("===================================");

            //var data1 = context.Emp.ToList();

            //foreach (var item in data1)
            //{
            //    Console.WriteLine(item.Id + "  " + item.Name + "  " + item.Address);
            //}
            //Console.WriteLine("==============DELETE=====================");
            //var dataEmp = context.Emp.Find(8);

            ////dataEmp.Name = "New EF Core";
            //context.Emp.Remove(dataEmp);
            //context.SaveChanges();
            //Console.WriteLine(dataEmp.Id+ "   "+dataEmp.Name+"    "+dataEmp.Address);
            Console.ReadLine();
        }
    }
}