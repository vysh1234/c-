using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_Implementation
{
    partial class LMS : IAssesment
    {
        string name;
        int SNo;
        long MobileNo;
        string Email;
        public void Display()
        {
            Console.WriteLine("Implementation Void");
        }

        void IAssesment.MCQ_Assesment()
        {
            Console.WriteLine("this implementation from LMS");
        }

        void IAssesment.QuestionBank()
        {
            Console.WriteLine("retuening value from quetion bank");
        }
    }
    partial class LMS : placement, IAssesment
    {
        public void Message()
        {
            Console.WriteLine("This message is coming from second imp");
        }
    }
    abstract class placement
    {
        string Name_of_company;
        int No_of_student_placed;
        DateTime Year_of_placement;

        public void placement_record()
        {
            Console.WriteLine("This method will show the record of placement");
        }
    }
    public interface IAssesment
    {
        public void MCQ_Assesment();
        public void QuestionBank();

    }
}
