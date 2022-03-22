using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page23
{
    class Card
    {
        // private fields for backing storage 
       
        // constructors (2) :  
        public Card(int number)
        {
          // what goes here
        }
        public Card(int faceValue,
                    int suit,
                    bool facing)
        {
            // what goes here
        }
        // public properties
        int Value
        {
            get 
            {
                // what should this really return?
                return 0; 
            }
        }
        int Suit
        {
            get
            {
                // what should this really return?
                return 0;
            }
        }
        bool Facing
        {
            get
            {
                // what should this really return?
                return false;
            }
        }
        // methods 
        public void Flip()
        {
            // what goes here
        }
        public void Reveal()
        {
            // what goes here
        }
        public void Hide()
        {
            // what goes here
        }
        public override string ToString()
        {
            // this method is actually implemented correctly


            // condition?true-stuff:false-stuff;

            // facing is the condition: 
            //   it is either true (show)
            //   or false (hide)
            // "A23456789TJQK"[Value] is the 
            //   character to return 
            //   if facing is true
            // '?' is the character to 
            //   return if facing is false

            // similar thing for suit

            char v = Facing
                     ? "A23456789TJQK"[Value]
                     : '?';
            char s = Facing
                     ? "CDHS"[Suit]
                     : '?';

            return $"{v}{s}";
        }

    }



}

