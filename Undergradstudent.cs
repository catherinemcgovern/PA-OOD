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

       /*    private enum Classification 
          {
              Freshman, Sophomore, Junior, Senior
          }*/
          

          public Undergradstudent(string studentName, DateTime dateOfBirth, long studId, string major, float gpa, string previousHighSchool) : base (studentName, dateOfBirth, studId, major, gpa)
                  {
                    this.PreviousHighSchool = previousHighSchool;
                    //this.Classification = classification;
                }  
                 public override string ToString() =>
                $"{base.ToString()} {PreviousHighSchool}";

    }
}