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

Console.WriteLine("Welcome to the Student Datatbase");
 bool validChoice;
 
 do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {            //Menu Stuff
             validChoice = true;

              

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine( "Commands:");
                Console.WriteLine("m) Full List of GradStudents-Woot!!"); 
                Console.WriteLine("a) Add a GradStudent!!"); 
 
                Console.WriteLine("--------------------------------------------");

              try
                {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {


                    case "m":
                    MakeList(gradstudents);
                    validChoice = false;
                    break;
                    
                    case "a":
                    AddAGradStudent(gradstudents);
                    validChoice = false;
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




//END OF THE MENU STUFF

        /* Console.WriteLine("Welcome to the Student Datatbase");
 bool validChoice;
 
 do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {            //Menu Stuff
             validChoice = true;

              

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine( "Commands:");
                Console.WriteLine("l) Full List of GradStudents-Woot!!"); 
                Console.WriteLine("a) Add a GradStudent!!"); 
 
                Console.WriteLine("--------------------------------------------");

              try
                {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {


                    case "m":
                    Commands.MakeList();
                    validChoice = false;
                    break;
                    
                    case "a":
                    Commands.AddGradStudent();
                    validChoice = false;
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

 */


            //MakeList(gradstudents);

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


                Console.WriteLine("Let's see if the list change");

                 foreach (var Gradstudent in gradstudents)
                   {
                        Console.WriteLine(Gradstudent);
                    }






                //"John", new DateTime(2019, 10, 2), 12234, "CIS", 3,"BSc"
                // DateTime dateOfBirth, long studId, string major, float gpa, string previousDegree) : base (studentName, dateOfBirth, studId, major, gpa)

                

    }
   
//List<Gradstudent>.ForEach(Gradstudent => Console.Write(Gradstudent.Major));
    }   
    }
    
    
       // Console.WriteLine({theGradList.}StudName + "  " + theGradList.StudId);  
   



            

                       /*   
                        },
                    new Gradstudent()
                        {
                        var GradStudent = new List<gradStudent>
                        studentName = "John",
                        dateOfBirth = 05/22/71,
                        studId = 12448,
                        major = CIS,
                        gpa = 3.25,
                        previousDegree = "BIT"
                        },
                }*/
        
        
        
        

        

    // Output:  
    //  Tadpole  400  
    //  Pinwheel  25  
    //  Milky Way  0  
    //  Andromeda  3  


            
            
            
            
            
           /*  Console.WriteLine("Welcome");
//GradStudent gradStudent
       ListAllGradStudents.ListAllGradStudents();
      



           /*
           
           foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
{
    string name=descriptor.Name;
    object value=descriptor.GetValue(obj);
    Console.WriteLine("{0}={1}",name,value);
} */

        

          // studentName,dateOfBirth, studId, major, gpa, previousDegree
          //



    

        
