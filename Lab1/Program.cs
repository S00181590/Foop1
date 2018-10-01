using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string grade = "";

            bool higher = true;

            bool Exit = false;

            Console.WriteLine("-------------Menu:-------------");
            Console.WriteLine("1. Find my grade");
            Console.WriteLine("2. Find my points");

            Console.WriteLine("Please enter the number of your choice");
            int menuchoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Higher or Ordinary?");
            string Level = Console.ReadLine();

            while (Exit != true)
            {
                if (menuchoice == 1)
                {
                    if (Level == "Higher" || Level == "higher")
                    {
                        higher = true;
                        GradeScore(grade, higher);
                    }
                    else if (Level == "Ordinary" || Level == "ordinary")
                    {
                        higher = false;
                        GradeScore(grade, higher);
                    }
                }
                else if(menuchoice == 2)
                {

                    if (Level == "Higher" || Level == "higher")
                    {
                        higher = true;
                        GradeScore(grade, higher);
                    }
                    else if (Level == "Ordinary" || Level == "ordinary")
                    {
                        higher = false;
                        GradeScore(grade, higher);
                    }
                }

                Console.WriteLine("Menu:");
                Console.WriteLine("1. Find my grade");
                Console.WriteLine("2. Find my points");

                Console.WriteLine("Please enter the number of your choice");
                menuchoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Higher or Ordinary?");
                Level = Console.ReadLine();
            }

            
        }
        public static string GradeScore(string grade, bool high)
        {

            Console.WriteLine("What is the leaving Certificate Score?");
            int leavingPoints = int.Parse(Console.ReadLine());
            if (high == true)
            {
                if (leavingPoints < 0)
                {
                    grade = "Invalid Score";
                }
                else if (leavingPoints >= 0 && leavingPoints < 30)
                {
                    grade = "H8";
                }
                else if (leavingPoints >= 30 && leavingPoints < 40)
                {
                    grade = "H7";
                }
                else if (leavingPoints >= 40 && leavingPoints < 50)
                {
                    grade = "H6";
                }
                else if (leavingPoints >= 50 && leavingPoints < 60)
                {
                    grade = "H5";
                }
                else if (leavingPoints >= 60 && leavingPoints < 70)
                {
                    grade = "H4";
                }
                else if (leavingPoints >= 70 && leavingPoints < 80)
                {
                    grade = "H3";
                }
                else if (leavingPoints >= 80 && leavingPoints < 90)
                {
                    grade = "H2";
                }
                else if (leavingPoints >= 90 && leavingPoints <= 100)
                {
                    grade = "H1";
                }
                else
                {
                    grade = "Invalid Score";
                }
            }
            else if(high == false)
            {
                if (leavingPoints < 0)
                {
                    grade = "Invalid Score";
                }
                else if (leavingPoints >= 0 && leavingPoints < 30)
                {
                    grade = "O8";
                }
                else if (leavingPoints >= 30 && leavingPoints < 40)
                {
                    grade = "O7";
                }
                else if (leavingPoints >= 40 && leavingPoints < 50)
                {
                    grade = "O6";
                }
                else if (leavingPoints >= 50 && leavingPoints < 60)
                {
                    grade = "O5";
                }
                else if (leavingPoints >= 60 && leavingPoints < 70)
                {
                    grade = "O4";
                }
                else if (leavingPoints >= 70 && leavingPoints < 80)
                {
                    grade = "O3";
                }
                else if (leavingPoints >= 80 && leavingPoints < 90)
                {
                    grade = "O2";
                }
                else if (leavingPoints >= 90 && leavingPoints <= 100)
                {
                    grade = "O1";
                }
                else
                {
                    grade = "Invalid Score";
                }
            }

            Console.WriteLine("Your grade is: " + grade);

            Console.ReadKey();

            return (grade);
        }
        public static void gradePoints(string grade, bool high)
        {

            int points = 0;

            Console.WriteLine("What is the leaving Certificate Score?");
            int leavingPoints = int.Parse(Console.ReadLine());

            if (high == true)
            {
                if (leavingPoints < 0)
                {
                    grade = "Invalid Score";
                }
                else if (leavingPoints >= 0 && leavingPoints < 30)
                {
                    grade = "H8";
                }
                else if (leavingPoints >= 30 && leavingPoints < 40)
                {
                    grade = "H7";
                }
                else if (leavingPoints >= 40 && leavingPoints < 50)
                {
                    grade = "H6";
                }
                else if (leavingPoints >= 50 && leavingPoints < 60)
                {
                    grade = "H5";
                }
                else if (leavingPoints >= 60 && leavingPoints < 70)
                {
                    grade = "H4";
                }
                else if (leavingPoints >= 70 && leavingPoints < 80)
                {
                    grade = "H3";
                }
                else if (leavingPoints >= 80 && leavingPoints < 90)
                {
                    grade = "H2";
                }
                else if (leavingPoints >= 90 && leavingPoints <= 100)
                {
                    grade = "H1";
                }
                else
                {
                    grade = "Invalid Score";
                }
            }
            else if(high == false)
            {
                if (leavingPoints < 0)
                {
                    grade = "Invalid Score";
                }
                else if (leavingPoints >= 0 && leavingPoints < 30)
                {
                    grade = "O8";
                }
                else if (leavingPoints >= 30 && leavingPoints < 40)
                {
                    grade = "O7";
                }
                else if (leavingPoints >= 40 && leavingPoints < 50)
                {
                    grade = "O6";
                }
                else if (leavingPoints >= 50 && leavingPoints < 60)
                {
                    grade = "O5";
                }
                else if (leavingPoints >= 60 && leavingPoints < 70)
                {
                    grade = "O4";
                }
                else if (leavingPoints >= 70 && leavingPoints < 80)
                {
                    grade = "O3";
                }
                else if (leavingPoints >= 80 && leavingPoints < 90)
                {
                    grade = "O2";
                }
                else if (leavingPoints >= 90 && leavingPoints <= 100)
                {
                    grade = "O1";
                }
                else
                {
                    grade = "Invalid Score";
                }
            }
            switch (grade)
            {
                case "H8":
                    {
                        
                        points = 0;
                        Console.WriteLine("Your points are " + points);
                    }
                    break;

                case "H7":
                    points = 37;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H6":
                    points = 46;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H5":
                    points = 56;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H4":
                    points = 66;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H3":
                    points = 77;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H2":
                    points = 88;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "H1":
                    points = 100;
                    Console.WriteLine("Your points are " + points);
                    break;

                case "O8":
                    points = 0;
                    break;

                case "O7":
                    points = 0;
                    break;

                case "O6":
                    points = 12;
                    break;

                case "O5":
                    points = 20;
                    break;

                case "O4":
                    points = 28;
                    break;

                case "O3":
                    points = 37;
                    break;

                case "O2":
                    points = 46;
                    break;

                case "O1":
                    points = 56;
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            Console.ReadKey();
        }
        
    }
}
