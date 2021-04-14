using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NorthernMIQuizlet
{

    // **********************************************************************************************
    //
    // Title: CapStone _ NorthernMIQuizlet - S4
    // Description: This is an application like quiz let that uses most of the skills used this year each 
    // question has a dettermind score the user will have two chances to get the correct answer if not it will
    // go to the next question. At the end the score will be totaled then show to the user.
    // Application Type: Console
    // Author: Pearl, Natham
    // Dated Created: 4/4/2021
    // Last Modified: 4/10/2021
    //
    // **********************************************************************************************




    class Program
    {



        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

           
            do
            {
                DisplayScreenHeader("Main Screen");
                Console.WriteLine("\ta) Flash Quiz");
                Console.WriteLine("\tb) Score Board");
                Console.WriteLine("\tc) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        DisplayFlashQuiz();
                        break;

                    case "b":
                        DisplayScores();
                        break;
                    case "c":
                        DisplayClosingScreen();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

       

        //
        // This is where the bulk of the program is going to take place more or less
        //

        static void DisplayFlashQuiz()
        {


            DisplayQuestionOne(); 
            
              
            
        }


        #region Qusstions
        //
        // summary
        // this is where all of the question and hint static void will be so i can just will into the quiz area
        //

        static void DisplayQuestionOne()
        {
            //
            // Charlevoix castell
            // Question 1 what city in northern michigan has its own castle
            //
            string userResponse;
            double Score;

            DisplayScreenHeader("Question One");
            Console.WriteLine();
            Console.WriteLine("What City in Northern Michigan has its own Castle");
            Console.WriteLine();
            userResponse = Console.ReadLine();

            if (userResponse == "Charlevoix")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("Also has a lake named after it");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Charlevoix")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionTwo();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Charlevoix")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionTwo();

                    }
                }

            }
        }
          

            static  void DisplayQuestionTwo()
        {
            //
            // Question 2
            // What island used to have its own king 
            //
            string userResponse;
            double Score;
           
            DisplayScreenHeader("Question Two");
            Console.WriteLine("What Island used to have  it's own king?");
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Fox island |  Beaver island  |  Mackinac island  |  Fishermans island  |");
            Console.WriteLine("_________________________________________________________________________");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Beaver island")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("The people and animals that live on this island love trees");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Beaver island")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionThree();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Beaver island")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionThree();

                    }
                }
            }

        }

            static void DisplayQuestionThree()
        {
            //
            // Question 3 
            // There is an 11 foot crucific that is located in Lake Michigan never witch City?
            // A = Petoskey
            //

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Three");
            Console.WriteLine("There is an 11 foot crucific that is located in Lake Michigan never witch City?");
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("Harbor Springs |  North Port  |  Mackinac island  |  Petoskey  |");
            Console.WriteLine("__________________________________________________________________________________");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Petoskey")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's only a stone's throw away from shore");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionFour();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionFour();

                    }
                }
            }



        }

            static void DisplayQuestionFour()
        {
            //
            // Question 4 
            // What can you find on the beachs on the shore line of lake Michihgan that you cant find any were else in the world?
            // A = Petoskey stones

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Four");
            Console.WriteLine();
            Console.WriteLine("What can you find on the beachs on the shore line of lake Michihgan that you cant find any were else in the world?");
            
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Petoskey stone" || userResponse == "Petoskey stones")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("You might think that it is just a fossil");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Petoskey stone" || userResponse == "Petoskey stones")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionFive();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionFive();

                    }
                }
            }



        }

             static void DisplayQuestionFive()
        {
            //
            // Questin 5 
            // What is the name of the Microbrewery that is located in Bellaire Michigan?
            // a = Shorts Brewing Company
            //

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Five");
            Console.WriteLine();
            Console.WriteLine("What is the name of the Microbrewery that is located in Bellaire Michigan?");

            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("Short people love this place");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionSix();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionSix();

                    }
                }
            }



        }

       static void DisplayQuestionSix()
        {
            //
            // Question 6
            // Which City is more expensive to live in? A - Petoskey B - Charleviox C - Harbor Springs D - Boyne City E - Mackinaw Island
            // a = C - Harbor Springs
            //

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Six");
            Console.WriteLine("Which City is more expensive to live in?");
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("A - Petoskey |  B - Charleviox  |  C - Harbor Springs  |  D - Boyne City  |  E - Mackinaw Island  |");
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("PLeas enter a letter for your answer");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse ==  "A" || userResponse == "a" || userResponse == "Petoskey")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It is located in Little Travers Bay");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "A" || userResponse == "a" || userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionSeven();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "A" || userResponse == "a" || userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionSeven();

                    }
                }
            }



        }

        static void DisplayQuestionSeven()
        {
            //
            // Question 7
            // what is traverse City biggest export?
            // a = tart cherries
            //

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Seven");
            Console.WriteLine("What is Traverse City's biggest export?");
            Console.WriteLine();
             Console.WriteLine("PLeas enter a letter for your answer");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "tart cherries")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's very sweet and tart");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "tart cherries")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionEight();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "tart cherries")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionEight();

                    }
                }
            }



        }

        static void DisplayQuestionEight()
        {
            //
            // Question 8
            // What is the deepest inland lake in Michigan?
            // a = Torch Lake
            //


            string userResponse;
            double Score;

            DisplayScreenHeader("Question Eight");
            Console.WriteLine("What is the deepest inland lake in Michigan?");
            Console.WriteLine();
            Console.WriteLine(" Lake Charleviox |   Six Mile Lake   |   Walloon Lake    |   Torch Laked |");
            Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Torch Lake")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It is realy dark out here do you have a light");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Torch Lake")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionNine();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Torch Lake")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionNine();

                    }
                }
            }



        }

        static void DisplayQuestionNine()
        {
            //
            // Question 9
            // what makes the lakes and great lakes so clear in Michigan?
            // a = Zebra Mussels
            //

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Nine");
            Console.WriteLine("What makes the lakes and great lakes so clear in Michigan?");
           Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Zebra Mussels" ||  userResponse == "zebra mussels" )
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("Not everything is in black and white");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Zebra Mussels" || userResponse == "zebra mussels")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionTen();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Zebra Mussels" || userResponse == "zebra mussels")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayQuestionTen();

                    }
                }
            }




        }

        static void DisplayQuestionTen()
        {
            //
            // Question 10 
            // 

            string userResponse;
            double Score;

            DisplayScreenHeader("Question Ten");
            Console.WriteLine("What is the name of the festival that Charlevoix celbrates every JUly");
            Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");
            Console.ReadLine();
            userResponse = Console.ReadLine();
            if (userResponse == "Venetian" || userResponse == "venetian")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //



            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                Console.ReadLine();
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's nickname is the festival of water and lights");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();
                    if (userResponse == "Venetian" || userResponse == "venetian")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayClosingScreen();
                        DisplayMenuScreen();
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    Console.ReadLine();
                    userResponse = Console.ReadLine();

                    if (userResponse == "Venetian" || userResponse == "venetian")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //


                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        DisplayClosingScreen();
                        DisplayMenuScreen();
                        

                    }
                }
            }




        }





        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tWelcome To Quizlet");
            Console.WriteLine();
            Console.WriteLine("\t\tThis is based on the Norther Mi area");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using this quiz have a nice day!");
            Console.WriteLine();
            Console.WriteLine("\t\tYou will now be redirected to the main screen");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }
        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }
        #endregion



        #region Data scores IO

        //
        // this is going to be the score section with in the data.dataSet folder with is a I.O file
        //

        static void DisplayScores()
        {







        }


        #endregion





    }







}

