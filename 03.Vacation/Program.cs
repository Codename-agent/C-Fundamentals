using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPerson = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            
            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (typeOfPerson)
                    {
                        case "Students":price = 8.45;
                            break;                        
                        case "Business":price = 10.90;
                            break;                        
                        case "Regular":price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfPerson)
                    {
                        case "Students":price = 9.80;
                            break;
                        case "Business":price = 15.60;
                            break;
                        case "Regular":price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfPerson)
                    {
                        case "Students":price = 10.46;
                            break;
                        case "Business":price = 16;
                            break;
                        case "Regular":price = 22.50;
                            break;
                    }
                    break;
            }
            if (typeOfPerson == "Students" && countOfPeople >= 30)
            {
                Console.WriteLine($"Total price: {price * countOfPeople * 0.85:f2}");
            }
            else if (typeOfPerson == "Business" && countOfPeople >= 100)
            {
                Console.WriteLine($"Total price: {(price * countOfPeople) - (price * 10):f2}");
            }
            else if (typeOfPerson == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                Console.WriteLine($"Total price: {price * countOfPeople * 0.95:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {price * countOfPeople:f2}");
            }
        }
    }
}
