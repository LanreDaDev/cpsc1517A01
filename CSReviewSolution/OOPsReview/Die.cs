using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    // Classes are private by default if public is not specified
    // Fully Qualified Name when ever you spell out the full name " System.Collections.Generic.List"\
    // namespaces allows us to organize our classes
    // Classes are data types just like int, string, list and so on.

    public class Die
    {
        // Data Members '_Name'
        // This is the physical storage area for data values 
        // These  are usually private

        private int _Sides;
        private string _Color;
        private int _Facevalue;

        //Properties
        // Properties  are public
        // is used as an interface for the class user to access 
        //      a data member
        // accessing a data member can include a get and set
        // a get returns the value of the data member to the user
        // a set accepts a value and assigns the value 
        //   to  the data member.
        // a property returns a specific datatype 
        // a property does NOT have a parameter list.




        //Fully Implemented Property
        public int Side
        {
            get
            {
                //returns the current value of the data member
                return _Sides;
            }
            set
            {
                //can be private 
                //It accepts a value and assigns it to the data member
                // The value is stored in a key word: value
                // the datatype of value is the return datatype of the property
                //validatoin can be done on the value 
                if(value >= 6 && value <=20)
                {
                    _Sides = value;
                }
                else
                {
                    throw new Exception("Die cannot have " + value.ToString() + "sides. Die can have 6 to 20 sides.");
                }
                
            }
        }



        //Auto Implemented Property

    }
}
