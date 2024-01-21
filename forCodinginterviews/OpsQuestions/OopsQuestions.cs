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

        //implementation
        public class DerivedClass : Baseclass
        {
            public override void  Print()
            {
                Console.WriteLine("ovriding the print method in base class");
            }
        }   
    }

    //create a astract class shape that cal area and perimeter
    // create a class rect and square  taht implements that class


}

