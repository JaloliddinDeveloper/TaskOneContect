//========
//Contacts
//========
namespace TaskOneContect.Models
{
    public class InterFase
    {
        public  void OutMetod()
        {
            Console.Clear();
            var crudUser = new CrudUser();
            while (true)
            {
                Console.WriteLine("Kantaktlar ustida qaysi amalni bajarmoqchisiz: ");
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Read");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit");
                string chose = Console.ReadLine();
                while (!TypeCheckInt(chose))
                {
                    Console.WriteLine("Amallarni sonda kiriting(1,2,3,,5):");
                    chose = Console.ReadLine();
                }

                switch (chose)
                {
                    case "1":
                        crudUser.Create();
                        break;
                    case "2":
                        crudUser.Read();
                        break;
                    case "3":
                        crudUser.Update();
                        break;
                    case "4":
                        crudUser.Delete();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }
            static bool TypeCheckInt(String input)
            {
                int number = 0;
                return int.TryParse(input, out number);
            }
        }
    }
}

