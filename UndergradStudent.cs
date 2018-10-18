using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace StudentDatabase
{ 
    public class Undergradstudent : Student
    {

        private string HighSchool {get; set;}
         private enum Classification { Freshman, Sophomore, Junior, Senior }
        private Classification Classification { get; set; }

            public UnderGradStudent(string studentName, DateTime dateOfBirth, long studId, string major, float gpa, string highSchool, enum classification  : base (studentName, dateOfBirth, studId, major, gpa))

                {
                    Classification = classification;
                
                    HighSchool = highSchool;

                }  

        public string HighSchool {get; set;}
  
    }

}