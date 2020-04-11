using System;
using System.Linq;

namespace MaximumGeneric
{
    public class MaximumNumber
    {
        //MAIN METHOD
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Generics");
            Console.ReadKey();
        }
        public class GenericClass<anyDataType>
        {
            //VARIABLE DECLARE
            anyDataType element1, element2, element3;

            //PARAMETERISED CONSTRUCTOR INITIALIZE VARIABLES
            public GenericClass(anyDataType element1, anyDataType element2, anyDataType element3)
            {
                this.element1 = element1;
                this.element2 = element2;
                this.element3 = element3;
            }

            //METHOD CALLED INTERNALLY
            public anyDataType testMaximum()
            {
                return testMaximum(element1, element2, element3);
            }

            //METHOD FOR FINDING MAXIMUM ELEMENT
            public static anyDataType testMaximum(anyDataType element1, anyDataType element2, anyDataType element3)
            {
                //ARRAY DECALRE
                anyDataType[] array = { element1, element2, element3 };

                //FIND MAXIMUM ELEMENT
                anyDataType MaximumValue = array.Max();
                return MaximumValue;
            }
        }
    }
}

