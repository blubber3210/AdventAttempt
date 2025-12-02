using System;
using System.Collections.Generic;
using System.Text;

namespace Advent
{
    public class SafeInput
    {
        public SafeInput(char letter, int number)
        {
            Letter = letter;
            Number = number;
        }

        public char Letter { get; set; }
        public int Number { get; set; }
        
    
    }
}
