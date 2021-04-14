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
            string userRespsonse;
            bool validResponse;

            
            
            
            
            
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
            Console.WriteLine("What can you find on the beachs on the shore line of lake Michihgan that you cant find any were else in the world?");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("Harbor Springs |  North Port  |  Mackinac island  |  Petoskey  |");
            Console.WriteLine("____________________________________________________________________________________________________________________");
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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
                        Console.WriteLine("press any key to go to the next question");
                        Console.ReadKey();
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



        }

            static void DisplayQuestionSix()
        {
            //
            // Question 6
            // Which City is more expensive to live in? A - Petoskey B - Charleviox C - Harbor Springs D - Boyne City E - Mackinaw Island
            // a = C - Harbor Springs
            //

        }

             static void DisplayQuestionSeven()
        {
            //
            // Question 7
            // what is traverse City biggest export?
            // a = tart cherries
            //




        }

            static void DisplayQuestionEight()
        {
            //
            // Question 8
            // What is the deepest inland lake in Michigan?
            // a = Torch Lake
            //





        }

            static void DisplayQuestionNine()
        {
            //
            // Question 9
            // what makes the lakes and great lakes so clear in Michigan?
            // a = Zebra Mussels
            //





        }

            static void DisplayQuestionTen()
        {
            //
            // Question 10 
            // 






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

