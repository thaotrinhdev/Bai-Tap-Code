
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;

            do
            {
                Console.Write("ENTER NUMBER : ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0 && a > 999)
                {
                    Console.WriteLine("do again ");
                }
                else
                {
                    if (a >= 0 && a <= 10)
                    {
                        switch (a)
                        {
                            case 0:
                                Console.WriteLine(" zero ");
                                break;
                            case 1:
                                Console.WriteLine(" one ");
                                break;
                            case 2:
                                Console.WriteLine(" two ");
                                break;
                            case 3:
                                Console.WriteLine(" three ");
                                break;
                            case 4:
                                Console.WriteLine(" four ");
                                break;
                            case 5:
                                Console.WriteLine(" five ");
                                break;
                            case 6:
                                Console.WriteLine(" six ");
                                break;
                            case 7:
                                Console.WriteLine(" seven ");
                                break;
                            case 8:
                                Console.WriteLine(" eight ");
                                break;
                            case 9:
                                Console.WriteLine(" nine ");
                                break;
                            case 10:
                                Console.WriteLine(" ten ");
                                break;
                        }
                    }
                    else if (a > 10 && a <= 999)
                    {
                        if (a == 11 || a == 12)
                        {
                            if (a == 11) Console.WriteLine(" eleven ");
                            else Console.WriteLine(" twelve ");
                        }
                        else
                        {
                            //abc
                            int first, second, third;
                            first = a / 100;
                            if (first > 0) second = (a % (first * 100)) / 10;
                            else second = a / 10;
                            third = a - (first * 100 + second * 10);
                            Console.WriteLine(first + " " + second + " " + third);

                            switch (first)
                            {
                                case 0:
                                    Console.Write("");
                                    break;
                                case 1:
                                    Console.Write(" one hundred ");
                                    break;
                                case 2:
                                    Console.Write(" two hundred ");
                                    break;
                                case 3:
                                    Console.Write(" three hundred ");
                                    break;
                                case 4:
                                    Console.Write(" four hundred ");
                                    break;
                                case 5:
                                    Console.Write(" five hundred ");
                                    break;
                                case 6:
                                    Console.Write(" six hundred ");
                                    break;
                                case 7:
                                    Console.Write(" seven hundred ");
                                    break;
                                case 8:
                                    Console.Write(" eight hundred ");
                                    break;
                                case 9:
                                    Console.Write(" nine hundred ");
                                    break;
                            }
                            if (first > 0)
                            {
                                Console.Write("and ");
                            }
                            if (second == 1)
                            {
                                //abc
                                //12 twelve , 112 one hundred and twelve
                                int z = second * 10 + third;
                                switch (z)
                                {
                                    case 11:
                                        Console.Write(" eleven ");
                                        break;
                                    case 12:
                                        Console.Write(" twelve ");
                                        break;
                                    case 13:
                                        Console.Write(" thirteen ");
                                        break;
                                    case 14:
                                        Console.Write(" fourteen ");
                                        break;
                                    case 15:
                                        Console.Write(" fifteen ");
                                        break;
                                    case 16:
                                        Console.Write(" sixteen ");
                                        break;
                                    case 17:
                                        Console.Write(" seventeen ");
                                        break;
                                    case 18:
                                        Console.Write(" eighteen ");
                                        break;
                                    case 19:
                                        Console.Write(" nineteen ");
                                        break;
                                        //abc
                                        //twenty
                                        //thirty
                                        //fourty
                                        //fifty
                                        //sixty
                                }
                            }
                            else
                            {
                                switch (second)
                                {
                                    case 2:
                                        Console.Write(" twenty ");
                                        break;
                                    case 3:
                                        Console.Write(" thirty ");
                                        break;
                                    case 4:
                                        Console.Write(" forty ");
                                        break;
                                    case 5:
                                        Console.Write(" fifty ");
                                        break;
                                    case 6:
                                        Console.Write(" sixty ");
                                        break;
                                    case 7:
                                        Console.Write(" seventy ");
                                        break;
                                    case 8:
                                        Console.Write(" eighty ");
                                        break;
                                    case 9:
                                        Console.Write(" ninety ");
                                        break;
                                        //ab
                                }
                            }
                            if (second != 1)
                            {
                                switch (third)
                                {
                                    case 0:
                                        Console.WriteLine(" zero ");
                                        break;
                                    case 1:
                                        Console.WriteLine(" one ");
                                        break;
                                    case 2:
                                        Console.WriteLine(" two ");
                                        break;
                                    case 3:
                                        Console.WriteLine(" three ");
                                        break;
                                    case 4:
                                        Console.WriteLine(" four ");
                                        break;
                                    case 5:
                                        Console.WriteLine(" five ");
                                        break;
                                    case 6:
                                        Console.WriteLine(" six ");
                                        break;
                                    case 7:
                                        Console.WriteLine(" seven ");
                                        break;
                                    case 8:
                                        Console.WriteLine(" eight ");
                                        break;
                                    case 9:
                                        Console.WriteLine(" nine ");
                                        break;
                                }
                            }

                        }
                    }
                }
            }
            while (a < 0 && a > 999);
        }
    }
}
