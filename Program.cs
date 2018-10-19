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

            MakeList(gradstudents);

        }
    
            //Gradstudent.WriteToConsole();

              public static void MakeList(List<Gradstudent> gradstudents)
              {
                  foreach (var Gradstudent in gradstudents)
                   {
        Console.WriteLine(Gradstudent);
    }
   
//List<Gradstudent>.ForEach(Gradstudent => Console.Write(Gradstudent.Major));
    }   
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



    

        
