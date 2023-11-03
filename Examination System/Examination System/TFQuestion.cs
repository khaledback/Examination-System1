using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class TFQuestion:QuestionBase
    {
        public TFQuestion(string Header ,string Body,int Mark,string Choice1="True",string Choice2="False",string Choice3=""): base (Header,Body,Mark,Choice1,Choice2,Choice3)
        {
        
        }
    }
}
