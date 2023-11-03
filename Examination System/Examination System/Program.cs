using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Subject  Sub1 = new Subject(10,"C#");
            Sub1.CreateExam();
            Console.Clear();

            // i have validated this code to prevent exceptions  
            Console.WriteLine("Do You Want To Start The Exam (y | n): ");
            int flag = 0;
            char choose;
            bool check = false;
            
            do
            {
                if (flag > 0)
                {
                    Console.WriteLine("enter y | n only");
                }

                check = char.TryParse(Console.ReadLine(),out choose);
                if (choose == 'n')
                {
                    Console.WriteLine("okay , come when you are ready");
                    break;

                }
                flag++;

                
            }while(choose!='y');
            if (choose == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Sub1.exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}