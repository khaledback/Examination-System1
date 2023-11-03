using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam:Exam
    {
      
        public PracticalExam(int Time, int Number_of_questions):base(Time, Number_of_questions) 
        { 

        }
        public override void ShowExam()
        {


            Console.Clear();

            for (int i = 0; i < QuestionBase.questionarr.Length; i++)
            {
                int  flag2 = 0;
                bool check2 = false; int choice2 = 0;
               
                
                    Console.WriteLine(QuestionBase.questionarr[i].Header + $"    Mark({QuestionBase.questionarr[i].Mark})");
                    Console.WriteLine(QuestionBase.questionarr[i].Body);
                    Console.WriteLine($"1.   {QuestionBase.questionarr[i].Choice1}                2.   {QuestionBase.questionarr[i].Choice2}              3.  {QuestionBase.questionarr[i].Choice3}");
                    Console.WriteLine("--------------------------------------------------------------");
                    check2 = false; choice2 = 0;
                    do
                    {
                        if (flag2 > 0)
                            Console.WriteLine("pls enter 1 or 2 or 3");
                        check2 = int.TryParse(Console.ReadLine(), out choice2);
                        flag2++;
                    } while (check2 == false || choice2 < 1 || choice2 > 3);
                    if (i != QuestionBase.questionarr.Length - 1)
                    {
                        Console.WriteLine("==============================================================\n");
                    }
                   
                


            }
            Console.Clear();
            Console.WriteLine("Right Answers:");
            for (int j = 0; j < QuestionBase.AnswerList.Length; j++)
            {
                Console.WriteLine($"Q{j + 1})     {QuestionBase.questionarr[j].Body}: {QuestionBase.AnswerList[j].AnswerText}");


            }

        }

    }
}
