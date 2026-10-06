namespace Topic_4_assignment
{
    internal class Program
    {

         public static void part1()
        {
            string name;
            string lastName;
            int age;
            double income;


            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!" + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            Console.WriteLine("So, you're " + age + " ,Eh? That's not old at all! How much do you make, " + name + "?");
            Double.TryParse(Console.ReadLine(), out income);
            Console.WriteLine(income.ToString("C") + " Hope that's per hour and not per year!");
            Console.WriteLine("Press Enter to continue to Part 2");
            Console.ReadLine();
            Console.Clear();
        }

        public static void part2()
        {
            string firstName;
            string lastName;
            string login;
            int grade;
            int studentID;

            double gradeAverage;

            Console.WriteLine("Please enter the following information so I can sell it for profit" + "!");
            Console.Write("Name:");
            firstName = Console.ReadLine();
            Console.Write("Last Name:");
            lastName = Console.ReadLine();
            Console.Write("Grade" + "(9-12):");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student ID:");
            Int32.TryParse(Console.ReadLine(), out studentID);
            Console.Write("Login:");
            login = Console.ReadLine();
            Console.Write("Grade Average" + ":");
            Double.TryParse(Console.ReadLine(), out gradeAverage);
            Console.Clear();
            Console.WriteLine("Your information:");
            Console.WriteLine("\t Login:" + login);
            Console.WriteLine("\t ID:" + studentID);
            Console.WriteLine("\t Name:" + lastName + ", " + firstName);
            Console.WriteLine("\t Average:" + gradeAverage + "%");
            Console.WriteLine("\t Grade:" + grade);
            Console.WriteLine("Press Enter to continue to Part 3");
            Console.ReadLine();
            Console.Clear();
        }

        public static void part3()
        {
            string name;
            int age;

            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "!" + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old?" + " And five years ago you were " + (age - 5) + "!" + " Imagine that!");
            Console.WriteLine("Press Enter to continue to Part 4");
            Console.ReadLine();
            Console.Clear();
        }
        public static void part4()
        {
            double number;
            double number2;
            double number3;

            Console.WriteLine("Hello, I am a calculator. Pick 3 numbers");
            Console.WriteLine("Pick your first number:");
            double.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Pick your second number:");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Pick your third number:");
            double.TryParse(Console.ReadLine(), out number3);
            Console.WriteLine((number + number2 + number3) / 2);
            Console.WriteLine("Press Enter to continue to Part 5");
            Console.ReadLine();
            Console.Clear();

        }
        public static void part5()
            {
            string itemName1;
            string itemName2;

            double itemPrice1;
            double itemPrice2;

           
            Console.WriteLine("What is your first item");
            itemName1 = Console.ReadLine();
            Console.WriteLine("What is the price of " + itemName1 + "?");
            double.TryParse(Console.ReadLine(), out itemPrice1);
            Console.WriteLine("What is your 2nd item");
            itemName2 = Console.ReadLine();
            Console.WriteLine("What is the price of " + itemName2 + "?");
            double.TryParse(Console.ReadLine(), out itemPrice2);
            Console.WriteLine();

            double totalCost =itemPrice1 + itemPrice2;
            double discount = totalCost * 0.2;
            double subTotal = totalCost - discount;
            double tax = subTotal * 0.13;
            double total = subTotal + tax;

            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine("Item 1: " + itemName1);
            Console.WriteLine("Price: " + itemPrice1.ToString("C"));
            Console.WriteLine("Item 2: " + itemName2);
            Console.WriteLine("Price: " + itemPrice2.ToString("C"));
            Console.WriteLine("=====================");
            Console.WriteLine(totalCost.ToString("C"));
            Console.WriteLine("Discount (20%): " + discount.ToString("C"));
            Console.WriteLine("Subtotal: " + subTotal.ToString("C"));
            Console.WriteLine("Tax (13%): " + tax.ToString("C"));
            Console.WriteLine("=====================");
            Console.WriteLine("Total Cost: " + total.ToString("C"));
        }
        static void Main(string[] args)
        {
            part1();
            part2();
            part3();
            part4();
            part5();

        }
    }
}
