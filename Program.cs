// See https://aka.ms/new-console-template for more information
using Wema.BIT.Models;
namespace Wema.BIT.Program
{
    class Program
    { 
        public static void Main(String[] args)
        {
            List<User> users = new List<User>()
            {
                new User() {Id=1, FirstName="Aluh", LastName="Johnson", Email= "Aluh23@gmail.com" },
                new User() {Id = 2, FirstName = "Omobolanle", LastName = "Makanjuola", Email= "makanjuola1@gmail.com" },
                new User() {Id = 3, FirstName = "Ismail", LastName = "Ogami", Email= "Ismail@gmail.com" },
                new User() {Id = 4, FirstName = "Olanrewaju", LastName = "Samson", Email= "samson@gmail.com" },
                new User() {Id = 5, FirstName = "Temi", LastName = "Orekunrin", Email= "temiorekunrin@gmail.com" },
            };

            List<Payment> payments = new List<Payment>();

            foreach (var user in users)
            {
                Random random = new Random();

                Payment pay1 = new Payment() { Id = random.Next(), UserId = user.Id, Amount = random.Next(2000), User = user };
                Payment pay2 = new Payment() { Id = random.Next(), UserId = user.Id, Amount = random.Next(1500), User = user };
                Payment pay3 = new Payment() { Id = random.Next(), UserId = user.Id, Amount = random.Next(5000), User = user };

                payments.Add(pay1);
                payments.Add(pay2);
                payments.Add(pay3);
            }
            foreach (var payment in payments)
            {
                Console.WriteLine($"User Id: {payment.UserId}\nAmount: {payment.Amount}\nFirstName: {payment.User.FirstName}\nLastName: {payment.User.LastName}\n");
                //Console.WriteLine(payment.UserId + " " + payment.Amount + " " + payment.User.FirstName + " " +payment.User.LastName);
            }

            Console.WriteLine("Calculating Area of a Triangle");
            Console.WriteLine("Option 1: Using the three sides\nOption 2: Using base and height");
            Console.WriteLine("For option 1 enter: 1\nFor option 2 enter 2");
            var userResponse = Console.ReadLine();
            if (userResponse == "1") {
                Console.WriteLine("Enter the length of side 1:");
                double side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of side 2:");
                double side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of side 3:");
                double side3 = Convert.ToDouble(Console.ReadLine());
                double semiperimeter = (side1 + side2 + side3) / 2;
                double Area2 = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
                Console.Write("Area of a Triangle = " + Area2);
                Console.ReadKey();
            }
            else {
                Console.Write("Enter the Base:");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Height:");
                double Height = Convert.ToDouble(Console.ReadLine());
                double Area = (Base * Height) / 2;
                Console.Write("Area of a Triangle = " + Area);
                Console.ReadKey();
            }
        }
    }
}
