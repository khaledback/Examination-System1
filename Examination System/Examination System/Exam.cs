using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Exam
    {
 
        public  int Time { get; set; }
        public int Number_of_questions { get; set; }

        public Exam() { }
        public Exam(int Time,int Number_of_questions)
        { 
        this.Time = Time;
        this.Number_of_questions = Number_of_questions;
        }
        public virtual void ShowExam() { 
        
        }
        
    }
}
