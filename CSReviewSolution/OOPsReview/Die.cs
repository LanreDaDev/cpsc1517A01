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
        //use the System.Random class for my random generator
        // the instance will be statuc so all instances of Die will use
        // the same generator
        // the instance of random will be created when the first instance 
        // of Die is create and be destroyed when the last instance
        // of die is destroyed
        public static Random _rnd = new Random();
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
        public int Sides
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
                if (value >= 6 && value <= 20)
                {
                    _Sides = value;
                    Roll();
                }
                else
                {
                    throw new Exception("Die cannot have " + value.ToString() + "sides. Die can have 6 to 20 sides.");
                }

            }
        }

        public string Color
        {
            get
            {
                return _Color;

            }
            set
            {
                //value == "" test? empty string 
                // value == null test? no string exists
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Cannot be an empty string");

                }
                else
                {
                    _Color = value;
                }

            }
        }



        //Auto Implemented Property
        // there is no defined data member for this property
        // the system creates an internal storage area of the 
        //   property datatype and manages the area for your code.
        // typically this typ[e of property is commonly used when no 
        // validation is required for the data
        public int FaceValue { get; private set; }

        // Constructors are optional
        // if you do not include a contructor for your class then when an
        // instance of the class is created, the system will assign 
        // the normal default values of that datatype to the 
        // appropriate data member.

        // if your declare a constructor within your class definition
        // then, you are responsible for the class
        // constuctors are NOT called directly by the user of the class
        // the constructor will be called when you ask the system to create
        // an instance of the class


        // syntax public classname([list of parameters]) {Coding body}


        // default constructor 
        // this is similar to having a system constructor
        // it has no parameters
        public Die()
        {
            // typically this constructor will have no code, that is, use 
            // the system defaults

            // you could assign your own defaults
            _Sides = 6;
            Color = "White";
            Roll();
        }

        // greedy constructor
        // takes in value for each of your data members/ auto properties
        // this allows the outside "User" wants to specify the values at time
        // of creation for the instance.
        public Die(int sides, string color)
        {
            Sides = sides;
            Color = color;
            Roll();
        }
        // Behaviours (Methods)
        //a method will allow the user to
        //a) manipulate the data of the instance
        //b) use the data of the instance to generate some other information

        public void Roll()
        {
            // will generate a random value for Facevalue
            FaceValue = _rnd.Next(1, Sides + 1);
        }

    }
}

