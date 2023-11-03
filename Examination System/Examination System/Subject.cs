using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Examination_System
{
    internal class Subject 
    {   
        private int Id { get; set; }
        private string Name { get; set; }
        public  Exam exam { get; set; }

        public Subject() { }
        public Subject(int Id,string Name) { 
        this.Id = Id;
         this.Name = Name;

        }
        public  void CreateExam()
        {
                bool outer0 = false;
                int choose=0;
           
                do
                {
                    Console.Write("please Enter the type of Exam you want to create (1 for Practical and 2 for final): ");
                    outer0 = int.TryParse(Console.ReadLine(), out choose);
                } while (outer0 == false || choose < 1 || choose > 2);
            if (choose == 1)
            {
                bool outer = false;
                bool outer2 = false;
                int time = 0; int Nquestions = 0;
                do
                {
                    Console.Write("Please Enter The Time Of Exam In Minutes: ");
                    outer = int.TryParse(Console.ReadLine(), out time);
                } while (outer == false);

                do
                {
                    Console.Write("Please Enter The Number Of Questions You Wanted To Create: ");
                    outer2 = int.TryParse(Console.ReadLine(), out Nquestions);
                } while (outer2 == false);
                 

                this. exam = new PracticalExam(time, Nquestions);



                Console.Clear();

                QuestionBase.questionarr = new QuestionBase[Nquestions];
                QuestionBase.AnswerList = new Answers[Nquestions];

                QuestionBase[] arrofquestions = new QuestionBase[Nquestions];
                for (int i = 0; i < this.exam.Number_of_questions; i++)
                {



                    Console.Clear();
                    string header = "One Answer Question";
                    Console.WriteLine(header);
                    Console.WriteLine("Enter The body of Question");
                    string Body = Console.ReadLine();
                    int marks = 0;
                    bool test = false;
                    do
                    {
                        Console.WriteLine("Enter The Marks of Question");
                        test = int.TryParse(Console.ReadLine(), out marks);
                    } while (test == false);

                    Console.WriteLine("Choices of Question :");
                    Console.Write("Please Enter The Choice Number 1 : ");
                    string Choice1 = Console.ReadLine();
                    Console.Write("Please Enter The Choice Number 2 : ");
                    string Choice2 = Console.ReadLine();
                    Console.Write("Please Enter The Choice Number 3 : ");
                    string Choice3 = Console.ReadLine();
                    QuestionBase.questionarr[i] = new MCQ(header, Body, marks, Choice1, Choice2, Choice3);

                    bool t;
                    int Rightanswer2 = 0;
                    do
                    {
                        Console.WriteLine("Please Specify The Right Choice of Question : ");
                        t = int.TryParse(Console.ReadLine(), out Rightanswer2);
                    } while (t == false || Rightanswer2 < 1 || Rightanswer2 > 3);
                    if (Rightanswer2 == 1)
                        QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice1);
                    else if (Rightanswer2 == 2)
                        QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice2);
                    else
                        QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice3);

                    Console.Clear();




                }
            }
            else if (choose == 2)
                {
                        bool outer=false;
                        bool outer2 = false;
                        int time =0 ;int Nquestions = 0;
                        do
                        {
                            Console.Write("Please Enter The Time Of Exam In Minutes: ");
                             outer = int.TryParse(Console.ReadLine(), out  time);
                        } while (outer == false);

                        do
                        {
                            Console.Write("Please Enter The Number Of Questions You Wanted To Create: ");
                            outer2 = int.TryParse(Console.ReadLine(), out  Nquestions);
                        } while (outer2 == false);

                       this.exam = new FinalExam(time, Nquestions);

                    bool outer3 = false;
                    int choose2 = 0;
                    Console.Clear();
                
                    QuestionBase.questionarr = new QuestionBase[Nquestions];
                    QuestionBase.AnswerList = new Answers[Nquestions];

                    for (int i = 0; i < this.exam.Number_of_questions; i++)
                    {
                  
                        do
                        {
                            do
                            {
                            Console.WriteLine($"Please Choose The Type Of Question Number {i + 1} (1 for True OR False|| 2 for MCQ)");
                            outer3 = int.TryParse(Console.ReadLine(), out choose2);
                            }while (outer3 == false||choose2<1||choose2>2);
                            if (choose2 == 1)
                            {
                                Console.Clear ();
                                string header = "True or False Question";
                                Console.WriteLine(header);
                                Console.WriteLine("Enter The body of Question");
                                string Body = Console.ReadLine();
                                int marks = 0;
                                bool test = false;
                                do
                                {
                                    Console.WriteLine("Enter The Marks of Question");
                                    test = int.TryParse(Console.ReadLine(), out marks);
                                } while (test == false);

                                QuestionBase.questionarr[i] = new TFQuestion(header, Body, marks,"True","False","");
                            
                                bool test2 = false;
                                int Rightanswer = 0;
                                do
                                {
                                    Console.WriteLine("Please Enter The Right Answer of Question(1 for True and 2 for false)");
                                    test2 = int.TryParse(Console.ReadLine(), out Rightanswer);
                                } while (test2 == false|| Rightanswer<1||Rightanswer>2);
                                if(Rightanswer==1)
                                    QuestionBase.AnswerList[i] = new Answers(Rightanswer,"True");
                                else
                                    QuestionBase.AnswerList[i] = new Answers(Rightanswer, "False");


                                Console.Clear();
                                break;
                            }
                            else if (choose2 == 2)
                            {
                                Console.Clear () ;
                                string header = "One Answer Question";
                                Console.WriteLine(header);
                                Console.WriteLine("Enter The body of Question");
                                string Body = Console.ReadLine();
                                int marks = 0;
                                bool test = false;
                                do
                                {
                                    Console.WriteLine("Enter The Marks of Question");
                                    test = int.TryParse(Console.ReadLine(), out marks);
                                } while (test == false);

                                Console.WriteLine("Choices of Question :");
                                Console.Write("Please Enter The Choice Number 1 : ");
                                string Choice1 =Console.ReadLine();
                                Console.Write("Please Enter The Choice Number 2 : ");
                                string Choice2 = Console.ReadLine();
                                Console.Write("Please Enter The Choice Number 3 : ");
                                string Choice3 = Console.ReadLine();
                                QuestionBase.questionarr[i] = new MCQ(header, Body, marks,Choice1,Choice2,Choice3);

                                bool t;
                                int Rightanswer2 = 0;
                                do
                                {
                                    Console.WriteLine("Please Specify The Right Choice of Question : ");
                                    t = int.TryParse(Console.ReadLine(), out Rightanswer2);
                                } while (t == false || Rightanswer2 < 1 || Rightanswer2 > 3);
                                if (Rightanswer2 == 1)
                                    QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice1);
                                else if(Rightanswer2==2)
                                    QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice2);
                                else 
                                    QuestionBase.AnswerList[i] = new Answers(Rightanswer2, Choice3);

                                Console.Clear();
                                break;
                            }
                        } while (outer3 == false);

                    }

    

             }
            
           
          
        }

    }
}
