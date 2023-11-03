using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam:Exam
    {
        public FinalExam() { }
        public FinalExam(int Time, int Number_of_questions):base(Time, Number_of_questions) 
        {

        }
       
        public  override void ShowExam()
        {

           
            int Totalmarks = 0;
            int yourmarks = 0;
            Console.Clear();
            for (int i = 0; i < QuestionBase.questionarr.Length; i++)
            { 
                int flag = 0, flag2=0 ;
                bool check = false; int choice = 0;
                bool check2 = false; int choice2 = 0;
                if (QuestionBase.questionarr[i].Header == "True or False Question")
                {
                    Console.WriteLine(QuestionBase.questionarr[i].Header + $"    Mark({QuestionBase.questionarr[i].Mark})");
                    Console.WriteLine(QuestionBase.questionarr[i].Body);
                    Console.WriteLine($"1.  {QuestionBase.questionarr[i].Choice1}              2.   {QuestionBase.questionarr[i].Choice2}");
                    Console.WriteLine("--------------------------------------------------------------");
                     check = false;  choice = 0;
                    do
                    {   if(flag>0)
                        Console.WriteLine("pls enter 1 or 2");
                        check = int.TryParse(Console.ReadLine(), out choice);
                        flag++;
                    } while (check == false||choice<1||choice>2);

                    
                    if (i != QuestionBase.questionarr.Length-1) {
                        Console.WriteLine("==============================================================\n");
                    }
                 
                    if (choice == QuestionBase.AnswerList[i].AnswerId)
                    {
                        yourmarks += QuestionBase.questionarr[i].Mark;
                    }
                    Totalmarks += QuestionBase.questionarr[i].Mark;
                    if (choice == 1)
                    {
                        QuestionBase.AnswerList[i].AnswerText = "True";
                        QuestionBase.AnswerList[i].AnswerId = 1;
                    }
                    else if (choice == 2)
                    {
                        QuestionBase.AnswerList[i].AnswerText = "False";
                        QuestionBase.AnswerList[i].AnswerId = 2;
                    }

                }
                else
                {
                    Console.WriteLine(QuestionBase.questionarr[i].Header + $"    Mark({QuestionBase.questionarr[i].Mark})");
                    Console.WriteLine(QuestionBase.questionarr[i].Body);
                    Console.WriteLine($"1.   {QuestionBase.questionarr[i].Choice1}                2.   {QuestionBase.questionarr[i].Choice2}              3.  {QuestionBase.questionarr[i].Choice3}");
                    Console.WriteLine("--------------------------------------------------------------");
                     check2 = false;  choice2 = 0;
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
                    //QuestionBase.UserAnswerList = new Answers[QuestionBase.questionarr.Length];
                  
                    if (choice2 == QuestionBase.AnswerList[i].AnswerId)
                    {
                        yourmarks += QuestionBase.questionarr[i].Mark;
                        
                    }
                    
                    Totalmarks += QuestionBase.questionarr[i].Mark;
                    if (choice2 == 1)
                    {
                        QuestionBase.AnswerList[i] = new Answers(choice2, QuestionBase.questionarr[i].Choice1);
                    }
                    else if (choice2 == 2)
                    {
                        QuestionBase.AnswerList[i] = new Answers(choice2, QuestionBase.questionarr[i].Choice2);
                    }
                    else if (choice2 == 3)
                    {
                        QuestionBase.AnswerList[i] = new Answers(choice2, QuestionBase.questionarr[i].Choice3);
                    }
                }


            }
            Console.Clear();
            Console.WriteLine("Your Answers:");

            for (int j = 0; j < QuestionBase.questionarr.Length; j++)
            {
                Console.WriteLine($"Q{j + 1})     {QuestionBase.questionarr[j].Body}: {QuestionBase.AnswerList[j].AnswerText}");

            }
            Console.WriteLine($"Your Exam Grade is {yourmarks} from {Totalmarks} ");
        }
    }
}
