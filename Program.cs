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

        //Make list of Gradstudents
            List<Gradstudent> gradstudents = new List<Gradstudent>();
            gradstudents.Add(new Gradstudent("John", new DateTime(2019, 01, 01), 12234, "CIS", float.Parse("3.00"),"BSc", "WTAMU", "CS", float.Parse("3.33")));
            gradstudents.Add(new Gradstudent("Doe", new DateTime(1971, 5, 22), 12448, "CIS", float.Parse("3.25"), "BIT", "CSU", "CIS", float.Parse("3.5")));
            gradstudents.Add(new Gradstudent("Alice", new DateTime(1991, 10, 15), 32558, "BA", float.Parse("3.8"), "BAcc", "USCD", "ACC", float.Parse("4.00")));

        //Make list of undergradstudents
            List<Undergradstudent> undergradstudents = new List<Undergradstudent>();
            undergradstudents.Add(new Undergradstudent("Bob", new DateTime(1999, 03, 01), 547857, "CIDM", float.Parse("4.00"), "PHS", 1));
            undergradstudents.Add(new Undergradstudent("Charley", new DateTime(1999, 03, 01), 65888, "CIDM", float.Parse("3.5"), "LHS", 0));
            undergradstudents.Add(new Undergradstudent("Eve", new DateTime(1995, 12, 01), 87785, "CIDM", float.Parse("3.7"), "AHS", 3));

        //Create Menu Method
            CreateMenu(gradstudents, undergradstudents);

        }


        public static void CreateMenu(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents)


        {
        Console.WriteLine("Welcome to the Student Datatbase");
        bool validChoice;
 
            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {  //Writing the menu for the user
             validChoice = true;

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("List View/Edit");
                Console.WriteLine("g) Full List of Graduate Students"); 
                Console.WriteLine("u) Full List of UndergradStudents"); 
                Console.WriteLine("a) Add a GradStudent to the list"); 
                Console.WriteLine("d) Add an Undergraduate Student to the list"); 
                Console.WriteLine(); 
                Console.WriteLine("Search-Update--------------------------------------------");
                Console.WriteLine("Search/Update Grad Student Information:");
                Console.WriteLine("y) Search by name"); 
                Console.WriteLine("s) search by student ID"); 
                Console.WriteLine("Search/Update Undergraduate Student Information:"); 
                Console.WriteLine("z) Search by name"); 
                Console.WriteLine("us) search by student ID"); 
                Console.WriteLine("--------------------------------------------");                
                Console.WriteLine("x) Exit the system"); 
 
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

                    case "u":
                    MakeUgList(undergradstudents);
                    validChoice = false;
                    break;
                    
                    case "a":
                    AddAGradStudent(gradstudents);
                    validChoice = false;
                    break;

                    case "y":
                  Console.WriteLine("please enter someone's name");
                    string term = Console.ReadLine();
                    SearchGradStudent(gradstudents, undergradstudents, term);
                    break;

                    case "z":
                  Console.WriteLine("please enter someone's name");
                    string ugterm = Console.ReadLine();
                    SearchUndergradStudent(gradstudents, undergradstudents, ugterm);
                    break;
 

                    case "x":
                        Quit();
                        break;
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
    
     
        //Here is the UNDERGRAD List Method
              public static void MakeUgList(List<Undergradstudent> undergradstudents)
              {
                  foreach (var Undergradstudent in undergradstudents)
                   {
                        Console.WriteLine(Undergradstudent);
                    }
                }

        //Here is the GRAD List Method
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
                    float newGPA;
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
                newGPA = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student's Previous degree");
                string newPrevDegree = (Console.ReadLine());
                Console.WriteLine("Please enter the student's Previous university");
                string newPrevUniversity = (Console.ReadLine());
                Console.WriteLine("Please enter the student's Undergraduate major");
                string newUndergradMajor = (Console.ReadLine());
                Console.WriteLine("Please enter the student's Undergraduate GPA");
                float newUgGPA = float.Parse(Console.ReadLine());


                gradstudents.Add(new Gradstudent(newName, NewDateTime, newStudID, newMajor, newGPA, newPrevDegree, newPrevUniversity, newUndergradMajor, newUgGPA));


                Console.WriteLine("Let's see if the list changed");

                 foreach (var Gradstudent in gradstudents)
                   {
                        Console.WriteLine(Gradstudent);
                    }






                //"John", new DateTime(2019, 10, 2), 12234, "CIS", 3,"BSc"
                // DateTime dateOfBirth, long studId, string major, float gpa, string previousDegree) : base (studentName, dateOfBirth, studId, major, gpa)

                

    }
    

//THis is the start of the search/update function


//SearchUndergradStudent(gradstudents, undergradstudents, ugterm)




            public static void SearchGradStudent(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents, string term)

            

    // public static List<Gradstudent> FindInGtudent(string term)
    {
    List<Gradstudent> list = new List<Gradstudent>();
    List<Undergradstudent> ulist = new List<Undergradstudent>();

    Console.WriteLine($"The method ran!!!!");
        foreach  (var Gradstudent in gradstudents)
            {
               // Console.WriteLine(Gradstudent);
                {
               if (Gradstudent.StudName == term)
                    {
                    
                        Console.WriteLine($"Here's what I found: {Gradstudent.StudName}{Gradstudent.StudId}{Gradstudent.Major}{Gradstudent.GPA}{Gradstudent.Major}{Gradstudent.Major}");
                    
              

                        //switch statement for updates

                        Console.WriteLine("what do you want to update");
                        Console.WriteLine("select m to change the student's major");
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
                    CreateMenu(gradstudents, undergradstudents);
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

                    }}}

Console.WriteLine("Term could not be found");
                            Console.WriteLine("Please select a menu option");
                            CreateMenu(gradstudents, undergradstudents);



                        //end switch statements for updates

                       // break; // If you only want to find the first instance a break here would be best for your application
                    
                }


//Start of undergraduate search

    

        public static void SearchUndergradStudent(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents, string ugterm)
                    

            // public static List<Gradstudent> FindInGtudent(string term)
            {
            List<Gradstudent> list = new List<Gradstudent>();
            List<Undergradstudent> ulist = new List<Undergradstudent>();

            Console.WriteLine($"The method ran!!!!");
                foreach  (var Undergradstudent in undergradstudents)
                    {
                    // Console.WriteLine(Gradstudent);
                        {
                    if (Undergradstudent.StudName == ugterm)
                            {
                            
                                Console.WriteLine($"Here's what I found: {Undergradstudent.StudName}{Undergradstudent.StudId}{Undergradstudent.Major}{Undergradstudent.GPA}");
                            
                            
                            

                                //switch statement for updates

                                Console.WriteLine("what do you want to update");
                                Console.WriteLine("select m to change the student's major");
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
                            Undergradstudent.Major = Console.ReadLine();
                            Console.WriteLine($"The Entry for the Gradstudent is now {Undergradstudent.StudName} {Undergradstudent.StudId}{Undergradstudent.Major}");
                            CreateMenu(gradstudents, undergradstudents);
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

                        }}}
                    
Console.WriteLine("Term could not be found");
                                    Console.WriteLine("Please select a menu option");
                                    CreateMenu(gradstudents, undergradstudents);

                    
            }
                        //end switch statements for updates

                       // break; // If you only want to find the first instance a break here would be best for your application
                    

//End of undergraduate searc

            
        

           static void Quit()
            //this method runs if no game has been played yet...(or going to be played...) a non-option for reals quit type of thing 
        {
            Environment.Exit(0);
            Console.WriteLine("Application is shutting down");
        }

    }
    }

