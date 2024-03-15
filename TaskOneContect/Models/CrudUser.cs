//========
//Contacts
//========
namespace TaskOneContect.Models
{
    internal class CrudUser
    {
        public  void Create()
        {
           
            using (var db = new StorageBroker())
            {
                //Create
                Console.Write("Qo'shiladigan kantaktlar soni: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    var user = new User();
                    Console.Write("Ism:");
                    user.UserName = Console.ReadLine();
                    Console.Write("Tel Raqami:");
                    user.UserPhoneNumber = Console.ReadLine();
                    db.Users.Add(user);
                }
                db.SaveChanges();
            }
        }
        public  void Read()
        {
            Console.Clear();
            using (var db = new StorageBroker())
            {
                //Read
                var users = db.Users.ToList();
                foreach (var u in users)
                {
                    Console.WriteLine($"{u.UserId}.{u.UserName} {u.UserPhoneNumber}");
                }
            }
        }
        public  void Update()
        {
            Console.Clear();
            using (var db = new StorageBroker())
            {
                //Update 
                var users = db.Users.ToList();

                foreach (var u in users)
                {
                    Console.WriteLine($"{u.UserId}.{u.UserName} {u.UserPhoneNumber}");
                }
                Console.WriteLine("Uzgartiriladigan foydalanuvchi Idsini kiriting: ");
                Console.Write("Id=");
                var updateUser = db.Users.First(x => x.UserId == int.Parse(Console.ReadLine()));

                Console.Write("Ism:");
                updateUser.UserName = Console.ReadLine();
                Console.Write("Tel Raqami:");
                updateUser.UserPhoneNumber = Console.ReadLine();
                db.SaveChanges();
            }
        }
        public void Delete()
        {
            Console.Clear();
            using (var db = new StorageBroker())
            {
                var users = db.Users.ToList();
                foreach (var u in users)
                {
                    Console.WriteLine($"{u.UserId}.{u.UserName} {u.UserPhoneNumber}");
                }
                Console.WriteLine("O'chiriladigan foydalanuvchi Idsini kiriting: ");
                Console.Write("Id=");
                var deleteUser = db.Users.First(x => x.UserId == int.Parse(Console.ReadLine()));
                db.Remove(deleteUser);
                db.SaveChanges();
            }
        }
    }
}
