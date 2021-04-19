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
                        HighScoreList();
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

            DisplayQuestionTwo();

            DisplayQuestionThree();

            DisplayQuestionFour();

            DisplayQuestionFive();

            DisplayQuestionSix();


            DisplayQuestionSeven();

            DisplayQuestionEight();
           
            DisplayQuestionNine();
            
            DisplayQuestionTen();
            DisplayClosingScreen();
            


            
              
            
        }


       
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
            double Score1;
            
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;
           
            

            DisplayScreenHeader("Question One");
            Console.WriteLine();
            Console.WriteLine("What City in Northern Michigan has its own Castle");
           
            userResponse = Console.ReadLine();
            if (userResponse == "Charlevoix")
            {
                Console.WriteLine("Corect");

                Score1 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score1} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                
                
               
                if (Console.ReadLine() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Also has a lake named after it");
                   
                    if (Console.ReadLine() == "Charlevoix")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score1 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score1} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                   
                    if (Console.ReadLine() == "Charlevoix")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score1 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score1} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       

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
            double Score2;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Two");
            Console.WriteLine("What Island used to have  it's own king?");
            Console.WriteLine("_________________________________________________________________________");
            Console.WriteLine("Fox island |  Beaver island  |  Mackinac island  |  Fishermans island  |");
            Console.WriteLine("_________________________________________________________________________");
            
            userResponse = Console.ReadLine();
            if (userResponse == "Beaver island")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score2 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score2} points to your total keep going");
                DisplayContinuePrompt();

            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
                
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("The people and animals that live on this island love trees");
                    
                    userResponse = Console.ReadLine();
                    if (userResponse == "Beaver island")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score2 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score2} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                    
                    userResponse = Console.ReadLine();

                    if (userResponse == "Beaver island")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score2 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score2} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score3;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Three");
            Console.WriteLine("There is an 11 foot crucific that is located in Lake Michigan never witch City?");
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("Harbor Springs |  North Port  |  Mackinac island  |  Petoskey  |");
            Console.WriteLine("__________________________________________________________________________________");
           
            userResponse = Console.ReadLine();
            if (userResponse == "Petoskey")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score3 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score3} points to your total keep going");
                DisplayContinuePrompt();

            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
               
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's only a stone's throw away from shore");
                    
                    userResponse = Console.ReadLine();
                    if (userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score3 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score3} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                   
                    userResponse = Console.ReadLine();

                    if (userResponse == "Petoskey")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score3 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score3} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                      

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
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;
            double Score4;

            DisplayScreenHeader("Question Four");
            Console.WriteLine();
            Console.WriteLine("What can you find on the beachs on the shore line of lake Michihgan that you cant find any were else in the world?");
            
           
            userResponse = Console.ReadLine();
            if (userResponse == "Petoskey stone" || userResponse == "Petoskey stones")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score4 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score4} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
               
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("You might think that it is just a fossil");
                   
                    userResponse = Console.ReadLine();
                    if (userResponse == "Petoskey stone" || userResponse == "Petoskey stones")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score4 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score4} points to your total keep going");
                        DisplayContinuePrompt();

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
                   
                    userResponse = Console.ReadLine();

                    if (userResponse == "Petoskey stone" || userResponse == "Petoskey stones")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score4 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score4} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score5;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Five");
            Console.WriteLine();
            Console.WriteLine("What is the name of the Microbrewery that is located in Bellaire Michigan?");

            userResponse = Console.ReadLine();
            if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score5 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score5} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
               
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("Short people love this place");
                    
                    userResponse = Console.ReadLine();
                    if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score5 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score5} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                  
                    userResponse = Console.ReadLine();

                    if (userResponse == "Shorts Brewing Company" || userResponse == "Shorts")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score5 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score5} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score6;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Six");
            Console.WriteLine("Which City is more expensive to live in?");
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("A - Petoskey |  B - Charleviox  |  C - Harbor Springs  |  D - Boyne City  |  E - Mackinaw Island  |");
            Console.WriteLine("______________________________________________________________________________________________________");
            Console.WriteLine("PLeas enter a letter for your answer");
           
            userResponse = Console.ReadLine();
            if (userResponse ==  "C" || userResponse == "c" || userResponse == "Harbor Springs")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score6 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score6} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");
               
                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It is located in Little Travers Bay");
                   
                    userResponse = Console.ReadLine();
                    if (userResponse == "C" || userResponse == "c" || userResponse == "Harbor Springs")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score6 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score6} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");
                   
                    userResponse = Console.ReadLine();

                    if (userResponse == "C" || userResponse == "c" || userResponse == "Harbor Springs")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score6 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score6} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score7;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Seven");
            Console.WriteLine("What is Traverse City's biggest export?");
            Console.WriteLine();
             Console.WriteLine("PLeas enter a letter for your answer");
           
            userResponse = Console.ReadLine();
            if (userResponse == "tart cherries")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score7 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score7} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");

                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's very sweet and tart");

                    userResponse = Console.ReadLine();
                    if (userResponse == "tart cherries")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score7 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score7} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");

                    userResponse = Console.ReadLine();

                    if (userResponse == "tart cherries")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score7 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score7} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score8;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Eight");
            Console.WriteLine("What is the deepest inland lake in Michigan?");
            Console.WriteLine();
            Console.WriteLine(" Lake Charleviox |   Six Mile Lake   |   Walloon Lake    |   Torch Laked |");
            Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");

            userResponse = Console.ReadLine();
            if (userResponse == "Torch Lake")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score8 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score8} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");

                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It is realy dark out here do you have a light");

                    userResponse = Console.ReadLine();
                    if (userResponse == "Torch Lake")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score8 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score8} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");

                    userResponse = Console.ReadLine();

                    if (userResponse == "Torch Lake")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score8 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score8} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        

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
            double Score9;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Nine");
            Console.WriteLine("What makes the lakes and great lakes so clear in Michigan?");
           Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");

            userResponse = Console.ReadLine();
            if (userResponse == "Zebra Mussels" ||  userResponse == "zebra mussels" )
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score9 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score9} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");

                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("Not everything is in black and white");

                    userResponse = Console.ReadLine();
                    if (userResponse == "Zebra Mussels" || userResponse == "zebra mussels")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score9 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score9} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");

                    userResponse = Console.ReadLine();

                    if (userResponse == "Zebra Mussels" || userResponse == "zebra mussels")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score9 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score9} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       

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
            double Score10 = 0;
            const double SCOREONE = 1000;
            const double SCOREONHINT = 500;
            const double SCOREONESECOUNDTRY = 750;

            DisplayScreenHeader("Question Ten");
            Console.WriteLine("What is the name of the festival that Charlevoix celbrates every JUly");
            Console.WriteLine();
            Console.WriteLine("PLeas enter a letter for your answer");

            userResponse = Console.ReadLine();
            if (userResponse == "Venetian" || userResponse == "venetian")
            {
                Console.WriteLine("Corect");
                //
                // add to file IO datset
                //
                Score10 = SCOREONE;
                Console.WriteLine($"Very good you have recived {Score10} points to your total keep going");
                DisplayContinuePrompt();


            }
            else
            {
                Console.WriteLine("Incorect");
                Console.WriteLine();
                Console.WriteLine("Would you like a hint [ yes or no] ");

                userResponse = Console.ReadLine();
                if (userResponse == "yes")
                {
                    Console.WriteLine("It's nickname is the festival of water and lights");

                    userResponse = Console.ReadLine();
                    if (userResponse == "Venetian" || userResponse == "venetian")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score10 = SCOREONHINT;
                        Console.WriteLine($"Very good you have recived {Score10} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       
                    }
                }
                else
                {
                    Console.WriteLine("Secound try");

                    userResponse = Console.ReadLine();

                    if (userResponse == "Venetian" || userResponse == "venetian")
                    {
                        Console.WriteLine("corect");
                        //
                        // add to file dataset
                        //
                        Score10 = SCOREONESECOUNDTRY;
                        Console.WriteLine($"Very good you have recived {Score10} points to your total keep going");
                        DisplayContinuePrompt();

                    }
                    else
                    {
                        Console.WriteLine("sorry that is incorect ");
                        Console.WriteLine();
                        DisplayContinuePrompt();
                       
                        

                    }
                }
            }




        }


      
        

     


        

        //
        // this is going to be the score section with in the data.dataSet folder with is a I.O file
        //

        static void DisplayScores(double Score1, double Score2, double Score3, double Score4, double Score5, double Score6, double Score7, double Score8, double Score9, double Score10)
        {
            string userNamer;

            Console.WriteLine("Please Enter your name for the leader board");
            userNamer = Console.ReadLine();
            Console.WriteLine($"OK we have saved {userNamer} as ur user Name");

            double Total;

            Total = Score1 + Score2 + Score3 + Score4 + Score5 + Score6 + Score7 + Score8 + Score9 + Score10;
            Console.WriteLine($"So you total for this round of test is {Total}");

            DisplayContinuePrompt();




        }
        static void HighScoreList()
        {
            
        }

        string list<(string userNamer, double Total)>
        static void WriteINfoData(string userNamer, double Total)
        {
            string dataPAth = @"data/scoresHigh.txt";
            string HighScoreInfo;

            HighScoreInfo = userNamer + "," + Total;

            File.WriteAllText(dataPAth, HighScoreInfo);
        }


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






    }







}

