using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MCQ : QuestionBase
    {
      
     


        public MCQ() { }
        public MCQ(string Header, string Body, int Mark,string Choice1,string Choice2,string Choice3) : base(Header, Body, Mark,Choice1,Choice2,Choice3)
        {

        }
    }
}
