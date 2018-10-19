using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;



using System.Text;

namespace StudentDatabase
{ 
    public class Gradstudent : Student
    {

            private string PreviousDegree {get; set;}

            public Gradstudent(string studentName, DateTime dateOfBirth, long studId, string major, float gpa, string previousDegree) : base (studentName, dateOfBirth, studId, major, gpa)

                {
                
                    this.PreviousDegree = previousDegree;

                }  

            //public string PreviousDegree 
               // {get; set;}
    

                public override string ToString() =>
                $"{base.ToString()} {PreviousDegree}";

                //var gradstudents = new[]{ 



                }

              }
/* 
              public static void WriteToConsole<T>(this IList<T> GradStudent)
              {
                int count = GradStudent.Count();
                for(int i = 0;  i < count; ++i)
                    {
                        Console.Write("{0}\t", collection[i].ToString(), delimiter);
                    }
                    Console.WriteLine();
                }
    
                
    



  //must list all grad and undergrad students students for the assignment
    


/*
public static void IterateThroughList()  
{  
    var theGradstudents = new List<Gradstudent>  
    {
        new Gradstudent()
            {
            var GradStudent = new List<gradStudent>
                {
                    new Gradstudent()
                        {
                        studentName = "John",
                        dateOfBirth = 01/01/81
                        studId = 12234,
                        major = CIS,
                        gpa = 3.00,
                        previousDegree = "BSc",
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
                }

                 foreach (Gradstudent theGradList in GradStudent)  
    {  
        Console.WriteLine(theGradList.studentName + "  " + theGradList.studId);  
    }   


            }
    }

    public static void MakeList()
{
      foreach (Gradstudent theGradList in GradStudent)  
    {  
        Console.WriteLine(theGradList.studentName + "  " + theGradList.studId);  
    }   */


/*private static void IterateThroughList()  
{  
    var theGalaxies = new List<Galaxy>  
        {  
            new Galaxy() { Name="Tadpole", MegaLightYears=400},  
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},  
            new Galaxy() { Name="Milky Way", MegaLightYears=0},  
            new Galaxy() { Name="Andromeda", MegaLightYears=3}  
        };  

    foreach (Galaxy theGalaxy in theGalaxies)  
    {  
        Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);  
    }   */

    
    
    
    //newgradStudent = new GradStudent("John", 12234, 01/01/81, "CIS", 3.00, "BSc" );
      //  GradStudent gradStudent = new GradStudent("Doe", 12448, 05/22/71, "CIDM", 3.25, "BIT"  );
      
/* 

    public static ListAllGradStudents()
    {
                foreach gradStudent in GradStudent
            {
                Console.Writeline
                
            }
    }

}
*/