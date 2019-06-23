using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARK_1_NEXZA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HELLO, WHAT YOUR NAME =");
            String NAME = Console.ReadLine();

            if (NAME == "navod")
            {
                Console.WriteLine("\nHello sir, How about Today\nIS GOOD OR BAD SIR");
                String day = Console.ReadLine();

                if (day == "good")
                {
                    Console.WriteLine("Like to hear that sir.\nNow we can go to work sir. Do you want watch list of what can i do sir(Yes or No)");
                    String work = Console.ReadLine();

                    if (work == "yes")
                    {
                        Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                        int wnum =Convert.ToInt32(Console.ReadLine());

                        if (wnum == 1)
                        {
                            DateTime now = DateTime.Now;
                            Console.WriteLine(now.ToString("F"));
                        }
                        else if (wnum == 2)
                        {
                            Console.Write("\nEnter First number:");
                            double num1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Operater (+,-,/,*) :");
                            string op = Console.ReadLine();

                            Console.Write("Enter second number:");
                            double num2 = Convert.ToDouble(Console.ReadLine());


                            if (op == "+")
                            {
                                Console.Write("Answer is =" + (num1 + num2));

                            }
                            else if (op == "-")
                            {
                                Console.Write("Answer is =" + (num1 - num2));

                            }

                            else if (op == "*")
                            {
                                Console.Write("Answer is =" + (num1 * num2));

                            }
                            else if (op == "/")
                            {
                                Console.Write("Answer is =" + (num1 / num2));

                            }
                            else
                            {
                                Console.Write("Sorry Wrong Operater. Cheack Again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                            Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            String day1 = Console.ReadLine();
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("\nEnter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter second number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                        }
                        Console.ReadLine();

      

                    }else if(work == "no")
                    {
                        Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Plese Enteryes or no sir\n I'M IN EXPERIMANT LEAVEL SIR");
                        Console.WriteLine("We can try again sir, Plse enter yes or no");
                        String work1 = Console.ReadLine();
                        if (work1 == "yes")
                        {
                            Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            int wnum = Convert.ToInt32(Console.ReadLine());
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("\nEnter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter second number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                String day1 = Console.ReadLine();
                                if (wnum == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum == 2)
                                {
                                    Console.Write("\nEnter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");//
                                    string op = Console.ReadLine();

                                    Console.Write("Enter second number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                            }
                            Console.ReadLine();
                        }
                        else if (work1 == "no")
                        {
                            Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                            Console.ReadLine();
                        }

                    }
                }
                else if(day == "bad")
                {
                    Console.WriteLine("Don't Worry Sir. You are my creater. You know sir.. \nYou are the best man i know in my life.\n Anyway forget today sir\n We can work togather for your futher");
                    Console.WriteLine("\n Now we can go to work sir. Do you want watch list of what can i do sir(Yes or No)");
                    String work = Console.ReadLine();
                    if (work == "yes")
                    {
                        Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                        int wnum = Convert.ToInt32(Console.ReadLine());
                        if (wnum == 1)
                        {
                            DateTime now = DateTime.Now;
                            Console.WriteLine(now.ToString("F"));
                        }
                        else if (wnum == 2)
                        {
                            Console.Write("\nEnter First number:");
                            double num1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Operater (+,-,/,*) :");
                            string op = Console.ReadLine();

                            Console.Write("Enter second number:");
                            double num2 = Convert.ToDouble(Console.ReadLine());


                            if (op == "+")
                            {
                                Console.Write("Answer is =" + (num1 + num2));

                            }
                            else if (op == "-")
                            {
                                Console.Write("Answer is =" + (num1 - num2));

                            }

                            else if (op == "*")
                            {
                                Console.Write("Answer is =" + (num1 * num2));

                            }
                            else if (op == "/")
                            {
                                Console.Write("Answer is =" + (num1 / num2));

                            }
                            else
                            {
                                Console.Write("Sorry Wrong Operater. Cheack Again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                            Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            String day1 = Console.ReadLine();
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("\nEnter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter second number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                        }
                        Console.ReadLine();

                    }
                    else if (work == "no")
                    {
                        Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Plese Enteryes or no sir\n I'M IN EXPERIMANT LEAVEL SIR");
                        Console.WriteLine("We can try again sir, Plse enter yes or no");
                        String work1 = Console.ReadLine();
                        if (work1 == "yes")
                        {
                            Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            int wnum = Convert.ToInt32(Console.ReadLine());
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("Enter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter First number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                String day1 = Console.ReadLine();
                                if (wnum == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum == 2)
                                {
                                    Console.Write("Enter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");
                                    string op = Console.ReadLine();

                                    Console.Write("Enter First number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                            }
                            Console.ReadLine();

                        }
                        else if (work1 == "no")
                        {
                            Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                            Console.ReadLine();
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Plese Enter Good Or Bad sir\n I'M IN EXPERIMANT LEAVEL SIR");
                    Console.WriteLine("We can try again sir, How about Today\n  IS GOOD OR BAD SIR");
                    String day1 = Console.ReadLine();

                    if (day1 == "good")
                    {
                        Console.WriteLine("Like to hear that sir.\n Now we can go to work sir. Do you want watch list of what can i do sir(Yes or No)");
                        String work = Console.ReadLine();
                        if (work == "yes")
                        {
                            Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            int wnum = Convert.ToInt32(Console.ReadLine());
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("Enter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter First number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                int wnum5 = Convert.ToInt32(Console.ReadLine());
                                if (wnum5 == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum5 == 2)
                                {
                                    Console.Write("Enter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");
                                    string op = Console.ReadLine();

                                    Console.Write("Enter First number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                            }
                            Console.ReadLine();


                        }
                        else if (work == "no")
                        {
                            Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Plese Enteryes or no sir\n I'M IN EXPERIMANT LEAVEL SIR");
                            Console.WriteLine("We can try again sir, Plse enter yes or no");
                            String work1 = Console.ReadLine();
                            if (work1 == "yes")
                            {
                                Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                int wnum = Convert.ToInt32(Console.ReadLine());
                                if (wnum == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum == 2)
                                {
                                    Console.Write("Enter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");
                                    string op = Console.ReadLine();

                                    Console.Write("Enter First number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                    Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                    int wnum2 = Convert.ToInt32(Console.ReadLine());
                                    if (wnum2 == 1)
                                    {
                                        DateTime now = DateTime.Now;
                                        Console.WriteLine(now.ToString("F"));
                                    }
                                    else if (wnum2 == 2)
                                    {
                                        Console.Write("Enter First number:");
                                        double num1 = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter Operater (+,-,/,*) :");
                                        string op = Console.ReadLine();

                                        Console.Write("Enter First number:");
                                        double num2 = Convert.ToDouble(Console.ReadLine());


                                        if (op == "+")
                                        {
                                            Console.Write("Answer is =" + (num1 + num2));

                                        }
                                        else if (op == "-")
                                        {
                                            Console.Write("Answer is =" + (num1 - num2));

                                        }

                                        else if (op == "*")
                                        {
                                            Console.Write("Answer is =" + (num1 * num2));

                                        }
                                        else if (op == "/")
                                        {
                                            Console.Write("Answer is =" + (num1 / num2));

                                        }
                                        else
                                        {
                                            Console.Write("Sorry Wrong Operater. Cheack Again");
                                        }
                                    }
                                }
                                Console.ReadLine();

                            }
                            else if (work1 == "no")
                            {
                                Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                                Console.ReadLine();
                            }

                        }
                    }
                    else 
                    {
                        Console.WriteLine("Don't Worry Sir. You are my creater. You know sir.. \nYou are the best man i know in my life.\n Anyway forget today sir\n We can work togather for your futher");
                        Console.WriteLine("Like to hear that sir.\n Now we can go to work sir. Do you want watch list of  what can i do sir(Yes or No)");
                        String work = Console.ReadLine();
                        if (work == "yes")
                        {
                            Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                            int wnum = Convert.ToInt32(Console.ReadLine());
                            if (wnum == 1)
                            {
                                DateTime now = DateTime.Now;
                                Console.WriteLine(now.ToString("F"));
                            }
                            else if (wnum == 2)
                            {
                                Console.Write("Enter First number:");
                                double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter Operater (+,-,/,*) :");
                                string op = Console.ReadLine();

                                Console.Write("Enter First number:");
                                double num2 = Convert.ToDouble(Console.ReadLine());


                                if (op == "+")
                                {
                                    Console.Write("Answer is =" + (num1 + num2));

                                }
                                else if (op == "-")
                                {
                                    Console.Write("Answer is =" + (num1 - num2));

                                }

                                else if (op == "*")
                                {
                                    Console.Write("Answer is =" + (num1 * num2));

                                }
                                else if (op == "/")
                                {
                                    Console.Write("Answer is =" + (num1 / num2));

                                }
                                else
                                {
                                    Console.Write("Sorry Wrong Operater. Cheack Again");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                int wnum3 =Convert.ToInt32(Console.ReadLine());
                                if (wnum3 == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum3 == 2)
                                {
                                    Console.Write("Enter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");
                                    string op = Console.ReadLine();

                                    Console.Write("Enter First number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                            }
                            Console.ReadLine();

                        }
                        else if (work == "no")
                        {
                            Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Plese Enteryes or no sir\n I'M IN EXPERIMANT LEAVEL SIR");
                            Console.WriteLine("We can try again sir, Plse enter yes or no");
                            String work1 = Console.ReadLine();
                            if (work1 == "yes")
                            {
                                Console.Write("(1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                int wnum = Convert.ToInt32(Console.ReadLine());
                                if (wnum == 1)
                                {
                                    DateTime now = DateTime.Now;
                                    Console.WriteLine(now.ToString("F"));
                                }
                                else if (wnum == 2)
                                {
                                    Console.Write("Enter First number:");
                                    double num1 = Convert.ToDouble(Console.ReadLine());

                                    Console.Write("Enter Operater (+,-,/,*) :");
                                    string op = Console.ReadLine();

                                    Console.Write("Enter First number:");
                                    double num2 = Convert.ToDouble(Console.ReadLine());


                                    if (op == "+")
                                    {
                                        Console.Write("Answer is =" + (num1 + num2));

                                    }
                                    else if (op == "-")
                                    {
                                        Console.Write("Answer is =" + (num1 - num2));

                                    }

                                    else if (op == "*")
                                    {
                                        Console.Write("Answer is =" + (num1 * num2));

                                    }
                                    else if (op == "/")
                                    {
                                        Console.Write("Answer is =" + (num1 / num2));

                                    }
                                    else
                                    {
                                        Console.Write("Sorry Wrong Operater. Cheack Again");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Plese Enter NUMBER 1 OR 2 = sir\n I'M IN EXPERIMANT LEAVEL SIR");
                                    Console.Write("We can try again sir, (1)Today Date And time\n(2)Calcuation of two numbers\n Sir Input the number:");
                                    int wnum3 = Convert.ToInt32(Console.ReadLine());
                                    if (wnum3 == 1)
                                    {
                                        DateTime now = DateTime.Now;
                                        Console.WriteLine(now.ToString("F"));
                                    }
                                    else if (wnum3 == 2)
                                    {
                                        Console.Write("Enter First number:");
                                        double num1 = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter Operater (+,-,/,*) :");
                                        string op = Console.ReadLine();

                                        Console.Write("Enter First number:");
                                        double num2 = Convert.ToDouble(Console.ReadLine());


                                        if (op == "+")
                                        {
                                            Console.Write("Answer is =" + (num1 + num2));

                                        }
                                        else if (op == "-")
                                        {
                                            Console.Write("Answer is =" + (num1 - num2));

                                        }

                                        else if (op == "*")
                                        {
                                            Console.Write("Answer is =" + (num1 * num2));

                                        }
                                        else if (op == "/")
                                        {
                                            Console.Write("Answer is =" + (num1 / num2));

                                        }
                                        else
                                        {
                                            Console.Write("Sorry Wrong Operater. Cheack Again");
                                        }
                                    }
                                }
                                Console.ReadLine();



                            }
                            else if (work1 == "no")
                            {
                                Console.Write("Ok sir, I Think you can't work now sir.\n We can work another day.\n Bye Sir");
                                Console.ReadLine();

                            }

                        }
                    }
                    Console.ReadLine();
                }


            }
            else 
            {
                Console.WriteLine("You don't have permission to access this computer. Please Go AWAY!.\n I DIAL 119 IN 5 MINUTES");
                Console.ReadLine();
            }
        }
    }
}
