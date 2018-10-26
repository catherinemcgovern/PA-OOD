using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;



using System.Text;

namespace StudentDatabase
{ 
    public class Undergradstudent : Student
    {

          private string PreviousHighSchool  {get; set;}

          private enum Classifications 
          {
              Freshman, Sophomore, Junior, Senior
          }

          private Classifications Classification {get; set;}
          

          public Undergradstudent(string studentName, DateTime dateOfBirth, long studId, string major, float gpa, string previousHighSchool, int classification) : base (studentName, dateOfBirth, studId, major, gpa)
                  {
                    this.PreviousHighSchool = previousHighSchool;
                 
                }  
                 public override string ToString() =>
                $"{base.ToString()} {PreviousHighSchool}";
               

    }
}