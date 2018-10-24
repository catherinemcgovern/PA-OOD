using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using StudentDatabase;

namespace NewStudentDatabase
{
    public class Program
    {
       public static void Main()
        {

            
                   List<Gradstudent> gradstudents = new List<Gradstudent>();
             gradstudents.Add(new Gradstudent("John", new DateTime(2019, 10, 2), 12234, "CIS", 3,"BSc"));
            gradstudents.Add(new Gradstudent("Doe", new DateTime(1971, 5, 22), 12234, "CIS", 3, "BSc"));

//START OF THE MENU STUFF

        CreateMenu(gradstudents);



            //MakeList(gradstudents);

        }


        public static void CreateMenu(List<Gradstudent> gradstudents)

        {
Console.WriteLine("Welcome to the Student Datatbase");
 bool validChoice;
 
 do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {            //Menu Stuff
             validChoice = true;

              

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine( "Commands:");
                Console.WriteLine("g) Full List of GradStudents-Woot!!"); 
                Console.WriteLine("a) Add a GradStudent!!"); 
                Console.WriteLine("s) Search for a GradStudent, then update info for him"); 
 
                Console.WriteLine("--------------------------------------------");

              try
                {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {


                    case "g":
                    MakeList(gradstudents);
                    validChoice = false;
                    break;
                    
                    case "a":
                    AddAGradStudent(gradstudents);
                    validChoice = false;
                    break;

                    case "s":
                  Console.WriteLine("please enter someone's name");
                    string term = Console.ReadLine();
                    SearchGradStudent(gradstudents, term);
                    break;

                         
                    case "e":
                        return;
                    default: 
                        validChoice = false;
                        Console.WriteLine("Unknown command.");
                        break;
                }

                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    validChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (validChoice == false); // Inner loop ends when validChoice is true




        }
    
            //Gradstudent.WriteToConsole();

              public static void MakeList(List<Gradstudent> gradstudents)
              {
                  foreach (var Gradstudent in gradstudents)
                   {
                        Console.WriteLine(Gradstudent);
                    }
                }

            public static void AddAGradStudent(List<Gradstudent> gradstudents)
                {
                    //long newStudID;
                    //string major;
                    //float newGPA;
                    //string newPrevDegree;
                    
                Console.WriteLine("Let's create a new gradstudent");
                Console.WriteLine("Please enter the student's name");
                string newName = (Console.ReadLine());
                Console.WriteLine("Please enter student's date of birth (e.g. 10/22/1987)");
                DateTime NewDateTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student's ID Number");
                long newStudID = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student's major");
                string newMajor = (Console.ReadLine());
                Console.WriteLine("Please enter the student's GPA");
                long newGPA = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student's Previous degree");
                string newPrevDegree = (Console.ReadLine());


                gradstudents.Add(new Gradstudent(newName, NewDateTime, newStudID, newMajor, newGPA,newPrevDegree));


                Console.WriteLine("Let's see if the list changed");

                 foreach (var Gradstudent in gradstudents)
                   {
                        Console.WriteLine(Gradstudent);
                    }






                //"John", new DateTime(2019, 10, 2), 12234, "CIS", 3,"BSc"
                // DateTime dateOfBirth, long studId, string major, float gpa, string previousDegree) : base (studentName, dateOfBirth, studId, major, gpa)

                

    }
    

//THis is the start of the search/update function

            public static void SearchGradStudent(List<Gradstudent> gradstudents, string term)

    // public static List<Gradstudent> FindInGtudent(string term)
    {
    List<Gradstudent> list = new List<Gradstudent>();

    Console.WriteLine($"The method ran!!!!");
        foreach  (var Gradstudent in gradstudents)
            {
               // Console.WriteLine(Gradstudent);
                {
               if (Gradstudent.StudName == term)
                    {
                    
                        Console.WriteLine($"Here's what I found: {Gradstudent.StudName}{Gradstudent.StudId}{Gradstudent.Major}");
                       

                        //switch statement for updates

                        Console.WriteLine("what do you want to update");
                        Console.WriteLine("select m to change the students major");
 bool validChoice;
 
 do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {            //Menu Stuff
             validChoice = true;

              


                         try
                {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {


                    case "m":
                    //MakeList(gradstudents);
                    Console.WriteLine("What is the new major of the student");
                    Gradstudent.Major = Console.ReadLine();
                    Console.WriteLine($"The Entry for the Gradstudent is now {Gradstudent.StudName} {Gradstudent.StudId}{Gradstudent.Major}");
                    CreateMenu(gradstudents);
                    validChoice = false;
                    break;

                         
                    case "e":
                    Main();
                      break; 
                    default: 
                        validChoice = false;
                        Console.WriteLine("Unknown command. Please choose another search/update option or please select e to exite the system ");
                        break;
                }

                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    validChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (validChoice == false); // Inner loop ends when validChoice is true







                        //end switch statements for updates

                       // break; // If you only want to find the first instance a break here would be best for your application
                    } 
                }
            }
        }

    
    }

}