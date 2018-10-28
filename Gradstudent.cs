using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;



using System.Text;

namespace StudentDatabase
{ 
    public class Gradstudent : Student
    {

            public string PreviousDegree {get; set;}
            public string PreviousUniversity {get; set;}

            public string UndergradMajor {get; set;}

            public float UgGPA {get; set;}

            public Gradstudent(string studentName, DateTime dateOfBirth, long studId, string major, float gpa, string previousDegree, string previousUniversity, string undergradMajor, float ugGPA) : base (studentName, dateOfBirth, studId, major, gpa)

                {
                    this.PreviousDegree = previousDegree;
                    this.PreviousUniversity = previousUniversity;
                    this.UndergradMajor = undergradMajor;
                    this.UgGPA = ugGPA;
                }  

     

                public override string ToString() =>
                $"{base.ToString()} {PreviousDegree}";

    



                }

              }