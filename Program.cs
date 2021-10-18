using System;

namespace Demo_Class_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LMS Akash = new LMS();
            Akash.Display();
            Akash.Message();
            Akash.placement_record();


            IAssesment Delhi = Akash;
            Delhi.MCQ_Assesment();
            Delhi.QuestionBank();


        }
    }
}
