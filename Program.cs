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
                Console.WriteLine("y) Search students by name and update information"); 
                Console.WriteLine("z) Search students by StudentID and update information"); //not done yet
                Console.WriteLine("s) search by student ID"); 
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
                    AddAGradStudent(gradstudents, undergradstudents);
                    validChoice = false;
                    break;

                    case "d":
                    AddAnUnderGradStudent(gradstudents, undergradstudents);
                    validChoice = false;
                    break;

                    case "y":
                  Console.WriteLine("please enter someone's name");
                    string term = Console.ReadLine();
                    SearchStudentName(gradstudents, undergradstudents, term);
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

            public static void AddAGradStudent(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents)
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


                Console.WriteLine("Here is the updated list of Grad students");

                 foreach (var Gradstudent in gradstudents)
                   {
                        Console.WriteLine(Gradstudent);
                    }
            CreateMenu(gradstudents, undergradstudents);
                

    }

//This is the add an UNDERGRADUATE student function
                public static void AddAnUnderGradStudent(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents)
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
                Console.WriteLine("Please enter the student's Undergraduate GPA");
                string newPrevHighSchool = (Console.ReadLine());
                Console.WriteLine("Please enter one of the following numbers for the student's classification:");
                Console.WriteLine("1) Freshman, 2) Sophomore, 3) Junior, 4) Senior");
                int newClassification = Convert.ToInt32(Console.ReadLine());

                //Now we update the Undergrad list with the information from the user inputs
                undergradstudents.Add(new Undergradstudent(newName, NewDateTime, newStudID, newMajor, newGPA, newPrevHighSchool, newClassification));

                Console.WriteLine("Here is the updated list of Undergraduate students");

                 foreach (var Undergradstudent in undergradstudents)
                   {
                        Console.WriteLine(Undergradstudent);
                    }

                
CreateMenu(gradstudents, undergradstudents);
    }


//Here ends the add an UNDERGRADUATE student function


//THis is the start of the search/update function using the STUDENT NAME
    public static void SearchStudentName(List<Gradstudent> gradstudents, List<Undergradstudent> undergradstudents, string term)        

    {
    List<Gradstudent> list = new List<Gradstudent>();
    List<Undergradstudent> ulist = new List<Undergradstudent>();

    Console.WriteLine($"The method ran!!!!");

    //Checking for match with gradstudents
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
                        {          
                        validChoice = true;

                         try
                            {
                            Console.Write("> ");
                            var command = Console.ReadLine();
                            switch (command)
                            {

                    case "m":
                    //MakeList(gradstudents);
                    //Now we are going to update the studentinformation
                    Console.WriteLine("What is the new major of the student");
                    Gradstudent.Major = Console.ReadLine();
                    Console.WriteLine($"The Entry for the Gradstudent is now {Gradstudent.StudName} {Gradstudent.StudId}{Gradstudent.Major}");
                    CreateMenu(gradstudents, undergradstudents);
                    validChoice = false;
                    break;
          
                    case "e":
                    CreateMenu(gradstudents, undergradstudents);
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

                    //checking for match with undergraduate students

foreach  (var Undergradstudent in undergradstudents)
                    {
                    // Console.WriteLine(Gradstudent);
                        {
                    if (Undergradstudent.StudName == term)
                            {
                            
                                Console.WriteLine($"Here's what I found: {Undergradstudent.StudName}{Undergradstudent.StudId}{Undergradstudent.Major}{Undergradstudent.GPA}");
                            
                                //switch statement for updates

                                Console.WriteLine("Select M to update the student's information");
                                
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
                            //Updating process
                    //string newPrevDegree;
                    
                Console.WriteLine($"Let's update {Undergradstudent.StudName}'s information");
                //Console.WriteLine("Please update student's name");
                //string StudName = (Console.ReadLine());
                Console.WriteLine("Please update student's date of birth (e.g. 10/22/1987)");
                Undergradstudent.DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Please update the student's ID Number");
                Undergradstudent.StudId = long.Parse(Console.ReadLine());
                Console.WriteLine("Please update the student's major");
                Undergradstudent.Major = (Console.ReadLine());
                Console.WriteLine("Please update the student's GPA");
                Undergradstudent.GPA = float.Parse(Console.ReadLine());
                //Console.WriteLine("Please update the student's Previous highschool");
                //Undergradstudent. = (Console.ReadLine());
                //Console.WriteLine("Please update by entering one of the following numbers for the student's classification:");
                //Console.WriteLine("1) Freshman, 2) Sophomore, 3) Junior, 4) Senior");
                //Undergradstudent.Classification = Convert.ToInt32(Console.ReadLine());

                //Now we update the Undergrad list with the information from the user inputs
                //undergradstudents.Add(new Undergradstudent(StudName, DateTime, StudID, Major, GPA, PrevHighSchool, Classification));

//End updating process
                            Console.WriteLine($"The Entry for the undergradGradstudent is now {Undergradstudent.StudName} {Undergradstudent.StudId}{Undergradstudent.Major}");
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




                    //end matching process

Console.WriteLine("Term could not be found");
                            Console.WriteLine("Please select a menu option");
                            CreateMenu(gradstudents, undergradstudents);

                        //end switch statements for updates                    
                }

           static void Quit()
            //this method runs if no game has been played yet...(or going to be played...) a non-option for reals quit type of thing 
        {
            Environment.Exit(0);
            Console.WriteLine("Application is shutting down");
        }

    }
    }

