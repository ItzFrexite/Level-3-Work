using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Reference for StreamReader for StreamWriter

namespace ThorsThunderGym
{
    class Program
    {
        static int choice;
        static string choice2;
        static string choice3;
        static string name;
        static string username;
        static string pass = "";
        static string age;
        static string address;
        static string bmi;
        static string height;
        static string weight;
        static string phone;
        static string membership;

        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {
                string choicee;

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" ______  _                     _     ");
                Console.WriteLine("|__  __|| |__     ___   _ __  ( ) ___  ");
                Console.WriteLine("  |  |  | '_  |  | _ | | '__| |/ | __|   ");
                Console.WriteLine("  |  |  | | | | | (_) || |       |__ | ");
                Console.WriteLine("  |__|  |_| |_|  |___| |_|       |___| ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ______  _                         _                 ");
                Console.WriteLine("|__  __|| |__    _   _  _ __    __| |  ___  _ __    ");
                Console.WriteLine("  |  |  | '_  | | | | || '_ |  | _` | | _ || '__|  ");
                Console.WriteLine("  |  |  | | | | | |_| || | | || (_| ||  __|| |    ");
                Console.WriteLine("  |__|  |_| |_| |__,_ ||_| |_| |__,_| |___||_|  ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("   ___    ");
                Console.WriteLine("  | _ | _   _  _ __ ___   ");
                Console.WriteLine(" | |_||| | | || '_ ` _ |    ");
                Console.WriteLine("| |_|| | |_| || | | | | |  ");
                Console.WriteLine("|____|  |__, ||_| |_| |_|    ");
                Console.WriteLine("        |____|              ");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("");
                Console.WriteLine("Are you a");
                Console.WriteLine("[M] - Member");
                Console.WriteLine("[PT] - Personal Trainer");
                Console.WriteLine("[A] - Admin");
                Console.WriteLine(""); // End of choices for what role you are at the gym
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[E] - Exit");
                Console.WriteLine("");
                choicee = Console.ReadLine();

                if (choicee.Equals("M") || choicee.Equals("m")) // members choice
                {
                    Member();

                    if (choice.Equals(6))
                    {
                        break;
                    }
                }

                else if (choicee.Equals("PT") || choicee.Equals("pt")) // trainers choice
                {
                    PT();
                }

                else if (choicee.Equals("A") || choicee.Equals("a")) // admin choice
                {
                    Admin();
                }

                else if (choicee.Equals("E") || choicee.Equals("e")) // exit choice
                {
                    Exit();
                }

                else
                {
                    Console.WriteLine("Wrong");
                }
            }

        }

        static void Member()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                          _____           _           ");
            Console.WriteLine("                         |     |___ _____| |_ ___ ___ ");
            Console.WriteLine("                         | | | | -_|     | . | -_|  _|");
            Console.WriteLine("                         |_|_|_|___|_|_|_|___|___|_|  ");
            Console.WriteLine("                                                      ");



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(""); // member selection menu
            Console.WriteLine("What do you want to do:");
            Console.WriteLine("1 - View an account");
            Console.WriteLine("2 - Quit the program");
            Console.WriteLine("3 - Return to the main menu");
            Console.WriteLine(""); // end of choices
            Console.ForegroundColor = ConsoleColor.White;
            choice = int.Parse(Console.ReadLine());



            if (choice.Equals(1))
            {
                // View
                string userrname;
                Console.WriteLine("Enter Your Username:"); // user enters username
                userrname = Console.ReadLine();
                string line;
                string line2;
                string line3;
                string line4;
                string line5;
                string line6;
                string line7;
                string line8;
                string line9;
                string line10;
                string line11;
                string line12;
                using (StreamReader reader = new StreamReader(userrname + ".txt"))
                {
                    line = reader.ReadLine(); // fetches all of the lines listed up to 12
                    line2 = reader.ReadLine();
                    line3 = reader.ReadLine();
                    line4 = reader.ReadLine();
                    line5 = reader.ReadLine();
                    line6 = reader.ReadLine();
                    line7 = reader.ReadLine();
                    line8 = reader.ReadLine();
                    line9 = reader.ReadLine();
                    line10 = reader.ReadLine();
                    line11 = reader.ReadLine();
                    line12 = reader.ReadLine();
                }
                Console.WriteLine(line); // displays the text
                Console.WriteLine(line2);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line5);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine(line8);
                Console.WriteLine(line9);
                Console.WriteLine(line10);
                Console.WriteLine(line11);
                Console.WriteLine(line12);
                Console.ReadLine();
            }


            else if (choice.Equals(2))
            {
                // Exit
                Console.WriteLine("");
                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
                Exit();
            }
            else if (choice.Equals(3))
            {
                // Return

                Console.WriteLine("");
                Console.WriteLine("Okay");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                MainMenu();




            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry you have entered incorrectly");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }


        }

        static void PT()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("       _____                         _    _____         _             ");
            Console.WriteLine("      |  _  |___ ___ ___ ___ ___ ___| |  |_   _|___ ___|_|___ ___ ___ ");
            Console.WriteLine("      |   __| -_|  _|_ -| . |   | .'| |    | | |  _| .'| |   | -_|  _|");
            Console.WriteLine("      |__|  |___|_| |___|___|_|_|__,|_|    |_| |_| |__,|_|_|_|___|_|  ");
            Console.WriteLine("                                                                 ");


            Console.ForegroundColor = ConsoleColor.Blue;

            string enteredptpassword;
            string enteredptusername;

            Console.WriteLine("Please Enter Username: "); // PT login
            enteredptusername = Console.ReadLine();
            Console.WriteLine("Please Enter Password: ");
            enteredptpassword = Console.ReadLine();
            // options that can be used:
            if (enteredptusername.Equals("PT") && enteredptpassword.Equals("password") || enteredptusername.Equals("pt") && enteredptpassword.Equals("password") || enteredptusername.Equals("Pt") && enteredptpassword.Equals("password"))
            {
                int number;

                // PT menu
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("What do you want to do:");
                Console.WriteLine("1 - Create a goal");
                Console.WriteLine("2 - Edit a goal");
                Console.WriteLine("3 - Log out and return to the main menu");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                number = int.Parse(Console.ReadLine()); // end of choices

                if (number.Equals(1))
                {
                    string usernname;
                    string goal;

                    Console.WriteLine("Enter the username of the user");
                    usernname = Console.ReadLine();

                    Console.WriteLine("Enter a goal for the person");
                    goal = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(usernname + ".txt")) // gets the right text file
                    {
                        //fetches all of the lines of text adding one more to the bottom for the goal
                        writer.WriteLine(name);
                        writer.WriteLine(username);
                        writer.WriteLine(pass);
                        writer.WriteLine(phone);
                        writer.WriteLine(age);
                        writer.WriteLine(address);
                        writer.WriteLine(bmi);
                        writer.WriteLine(height);
                        writer.WriteLine(weight);
                        writer.WriteLine(membership);
                        writer.WriteLine(goal);
                    }
                }

                else if (number.Equals(2))
                {
                    string usernname;
                    string goal2;

                    Console.WriteLine("Enter the username of the user");
                    usernname = Console.ReadLine();

                    Console.WriteLine("Enter a goal for the person");
                    goal2 = Console.ReadLine();

                    var lines = File.ReadAllLines(usernname + ".txt");
                    lines[10] = goal2;
                    File.WriteAllLines(usernname + ".txt", lines); // overwrites current goal for the user


                }


                else if (number.Equals(3))
                {
                    MainMenu();
                }


                else
                {
                    MainMenu();
                }

            }
        }

        static void Admin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                ");
            Console.WriteLine("                          _____   _       _     ");
            Console.WriteLine("                         |  _  |_| |_____|_|___ ");
            Console.WriteLine("                         |     | . |     | |   |");
            Console.WriteLine("                         |__|__|___|_|_|_|_|_|_|");
            Console.WriteLine("                                               ");

            string enteredapassword;
            string enteredausername;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please Enter Username: "); // admin login
            enteredausername = Console.ReadLine();
            Console.WriteLine("Please Enter Password: ");
            enteredapassword = Console.ReadLine();

            // correct choices
            if (enteredausername.Equals("admin") && enteredapassword.Equals("password") || enteredausername.Equals("Admin") && enteredapassword.Equals("password") || enteredausername.Equals("ADMIN") && enteredapassword.Equals("password"))
            {

                int number;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(""); // admin choices
                Console.WriteLine("What do you want to do:");
                Console.WriteLine("1 - Create an account");
                Console.WriteLine("2 - View an account");
                Console.WriteLine("3 - Remove an account");
                Console.WriteLine("4 - Edit an account");
                Console.WriteLine("5 - Add a goal to a user");
                Console.WriteLine("6 - Edit a goal to a user");
                Console.WriteLine("7 - Quit the program");
                Console.WriteLine("8 - Log out and return to the main menu");
                Console.WriteLine(""); // end of choices
                Console.ForegroundColor = ConsoleColor.White;
                choice = int.Parse(Console.ReadLine());

                if (choice.Equals(1))
                {
                    // Create
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    // string view = Directory.GetCurrentDirectory();

                    // string details = Directory.GetCurrentDirectory(); // makes path
                    // string text = System.IO.File.ReadAllText(view + "\\numbers.txt");

                    // Console.WriteLine("Numbers that have been taken: ");
                    // Console.WriteLine(text);
                    //dispaly text file     




                    //var r = new Random();
                    //Console.WriteLine("The users nunmber is: ");
                    //print random integer >= 0 and  < 100;
                    //Console.WriteLine(r.Next(10000));
                    //number = int.Parse(Console.ReadLine());


                    // Console.Write("Please enter a number you wish to use: ");
                    //number = int.Parse(Console.ReadLine());


                    // allows a new member to be added
                    Console.Write("Please enter the full name of the user: ");
                    name = Console.ReadLine();
                    Console.Write("Please enter a username for the user: ");
                    username = Console.ReadLine();

                    Console.Write("Enter the password for the user: ");
                    pass = Console.ReadLine();


                    //ConsoleKeyInfo key;

                    //do
                    //{
                    //    key = Console.ReadKey(true);

                    // Backspace Should Not Work
                    //    if (key.Key != ConsoleKey.Backspace)
                    //    {
                    //        pass += key.KeyChar;
                    //        Console.Write("*");
                    //    }
                    //    else
                    //    {
                    //        Console.Write("\b");
                    //    }
                    //}
                    // Stops Receving Keys Once Enter is Pressed
                    //while (key.Key != ConsoleKey.Enter);



                    Console.Write("Please enter the phone number of the user: ");
                    phone = Console.ReadLine();

                    Console.Write("Please enter the Age of the user: ");
                    age = Console.ReadLine();

                    Console.Write("Please enter the Address of the user: ");
                    address = Console.ReadLine();

                    Console.Write("Please enter the BMI of the user: ");
                    bmi = Console.ReadLine();

                    Console.Write("Please enter the height of the user: ");
                    height = Console.ReadLine();

                    Console.Write("Please enter the Weight of the user: ");
                    weight = Console.ReadLine();

                    Console.WriteLine("Please enter the Membership type of the user: ");
                    Console.WriteLine("Weekly, Monthly or Yearly");
                    membership = Console.ReadLine();

                    Console.Write("Please press enter to continue");
                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    using (StreamWriter writer = new StreamWriter(username + ".txt")) // writes it all to a text file
                    {
                        writer.WriteLine(name);
                        writer.WriteLine(username);
                        writer.WriteLine(pass);
                        writer.WriteLine(phone);
                        writer.WriteLine(age);
                        writer.WriteLine(address);
                        writer.WriteLine(bmi);
                        writer.WriteLine(height);
                        writer.WriteLine(weight);
                        writer.WriteLine(membership);
                    }

                    //TextWriter tw = new StreamWriter("numbers.txt");

                    // write a line of text to the file
                    //tw.WriteLine(number +Environment.NewLine);
                    //File.AppendAllText("numbers.txt", number.ToString());

                    // close the stream
                    //tw.Close();

                    //File.AppendAllText("numbers.txt", number.ToString() + Environment.NewLine);

                }

                else if (choice.Equals(2))
                {
                    // View
                    string userrname;
                    Console.WriteLine("Enter Your Username:");
                    userrname = Console.ReadLine();
                    string line;
                    string line2;
                    string line3;
                    string line4;
                    string line5;
                    string line6;
                    string line7;
                    string line8;
                    string line9;
                    string line10;
                    string line11;
                    string line12;
                    using (StreamReader reader = new StreamReader(userrname + ".txt"))
                    {
                        line = reader.ReadLine(); //fetches all of the text lines
                        line2 = reader.ReadLine();
                        line3 = reader.ReadLine();
                        line4 = reader.ReadLine();
                        line5 = reader.ReadLine();
                        line6 = reader.ReadLine();
                        line7 = reader.ReadLine();
                        line8 = reader.ReadLine();
                        line9 = reader.ReadLine();
                        line10 = reader.ReadLine();
                        line11 = reader.ReadLine();
                        line12 = reader.ReadLine();
                    }
                    Console.WriteLine(line); // displays all of the lines
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);
                    Console.WriteLine(line4);
                    Console.WriteLine(line5);
                    Console.WriteLine(line6);
                    Console.WriteLine(line7);
                    Console.WriteLine(line8);
                    Console.WriteLine(line9);
                    Console.WriteLine(line10);
                    Console.WriteLine(line11);
                    Console.WriteLine(line12);
                    Console.ReadLine();


                }

                else if (choice.Equals(3))
                {

                    string uusername;

                    Console.WriteLine("Enter the user's username");
                    uusername = Console.ReadLine();

                    if (System.IO.File.Exists(uusername + ".txt"))
                    {
                        System.IO.File.Delete(uusername + ".txt");
                    }

                    else
                    {
                        Console.WriteLine("Sorry its wrong");
                    }

                }

                else if (choice.Equals(4))
                {
                    int choicee;

                    // Edit
                    //Choices available
                    Console.WriteLine("What would you like to edit:");
                    Console.WriteLine("1 - User's full name");
                    Console.WriteLine("2 - User's username");
                    Console.WriteLine("3 - User's password");
                    Console.WriteLine("4 - User's phone number");
                    Console.WriteLine("5 - User's age");
                    Console.WriteLine("6 - User's address");
                    Console.WriteLine("7 - User's BMI");
                    Console.WriteLine("8 - User's height");
                    Console.WriteLine("9 - User's weight");
                    Console.WriteLine("10 - User's membership type");
                    Console.WriteLine("11 - User's goal");
                    choicee = int.Parse(Console.ReadLine()); // end of choices

                    if (choice.Equals(1))
                    {
                        string us1;
                        string namme2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new 'full' name; ");
                        namme2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[0] = namme2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();

                    }

                    else if (choicee.Equals(2))
                    {
                        string us1;
                        string us2;

                        Console.WriteLine("What is the user's existing username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new usernname; ");
                        us2 = Console.ReadLine();

                        System.IO.File.Move(us1 + ".txt", us2 + ".txt");


                        var lines = File.ReadAllLines(us2 + ".txt");
                        lines[1] = us2;
                        File.WriteAllLines(us2 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();



                    }

                    else if (choice.Equals(3))
                    {
                        string us1;
                        string pass1;
                        string pass2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's existing password;");
                        pass1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new password; ");
                        pass2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[2] = pass2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(4))
                    {

                        string us1;
                        string pho2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();


                        Console.WriteLine("What is the user's new phone number; ");
                        pho2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[3] = pho2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();

                    }

                    else if (choice.Equals(5))
                    {
                        string us1;
                        string age2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new age; ");
                        age2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[4] = age2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(6))
                    {
                        string us1;
                        string add2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new address; ");
                        add2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[5] = add2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(7))
                    {
                        string us1;
                        string bmi2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new address; ");
                        bmi2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[6] = bmi2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(8))
                    {
                        string us1;
                        string hei2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new height; ");
                        hei2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[7] = hei2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(9))
                    {
                        string us1;
                        string wei2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new weight; ");
                        wei2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[8] = wei2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(10))
                    {
                        string us1;
                        string mem2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new membership type; ");
                        mem2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[9] = mem2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else if (choice.Equals(11))
                    {
                        string us1;
                        string goa2;

                        Console.WriteLine("What is the user's username;");
                        us1 = Console.ReadLine();

                        Console.WriteLine("What is the user's new goal; ");
                        goa2 = Console.ReadLine();

                        var lines = File.ReadAllLines(us1 + ".txt");
                        lines[10] = goa2;
                        File.WriteAllLines(us1 + ".txt", lines); // Edits desired line

                        Console.ReadLine();
                        MainMenu();
                    }

                    else
                    {
                        MainMenu();
                    }



                }

                else if (choice.Equals(5))
                {
                    string usernname;
                    string goal;

                    Console.WriteLine("Enter the username of the user");
                    usernname = Console.ReadLine();

                    Console.WriteLine("Enter a goal for the person");
                    goal = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(usernname + ".txt"))
                    {
                        writer.WriteLine(name);
                        writer.WriteLine(username);
                        writer.WriteLine(pass);
                        writer.WriteLine(phone);
                        writer.WriteLine(age);
                        writer.WriteLine(address);
                        writer.WriteLine(bmi);
                        writer.WriteLine(height);
                        writer.WriteLine(weight);
                        writer.WriteLine(membership);
                        writer.WriteLine(goal); // adds a new line at the bottom for the users goal
                    }

                }

                else if (choice.Equals(6))
                {
                    string usernname;
                    string goal2;

                    Console.WriteLine("Enter the username of the user");
                    usernname = Console.ReadLine();

                    Console.WriteLine("Enter a goal for the person");
                    goal2 = Console.ReadLine();

                    var lines = File.ReadAllLines(usernname + ".txt");
                    lines[10] = goal2;
                    File.WriteAllLines(usernname + ".txt", lines); // overwrites the vurrent goal with a new one
                }

                else if (choice.Equals(7))
                {
                    Exit();
                }

                else if (choice.Equals(8))
                {

                }


                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry you have entered incorrectly");
                    Console.WriteLine("Press Enter to continue"); // returnes to the main menu
                    Console.ReadLine();
                    MainMenu();
                }



            }


        }

        static void Exit()
        {
            Environment.Exit(0);
        }



    }

}

