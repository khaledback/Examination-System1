using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class QuestionBase
    {
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
       public string Choice3 { get; set; }
        public string Header { get; set; }
        public string Body{ get; set; }
        public  int Mark { get; set; }
      public static  QuestionBase[] questionarr ;
        public static Answers[] AnswerList;

        public QuestionBase() { }
        public QuestionBase(string Header,string Body,int Mark,string Choice1,string Choice2, string  Choice3) {
            this.Header = Header;
            this.Body = Body;   
            this.Mark = Mark;   
            this.Choice1 = Choice1;
            this.Choice2 = Choice2;
            this.Choice3 = Choice3;
        }
    }
}
