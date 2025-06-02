namespace forCodinginterviews.OpsQuestions
{
    public class OopsQuestions
    {
        //implement method overding
        public class Baseclass
        {
            public virtual void Print()
            {
                Console.WriteLine("Base class print method");
            }

        }
        public class DerivedClass : Baseclass
        {
            public override void  Print()
            {
                Console.WriteLine("ovriding the print method in base class");
            }
        }   
    }




}

