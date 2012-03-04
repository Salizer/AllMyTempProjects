using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame.Tests
{
    class FieldStub : IField
    {
        // Members
        uint number;
        uint color;
        bool even;

        public uint Number
        {
            get { return (number); }
            set { number = value; }
        }

        public uint Color
        {
            get { return (color); }
            set { color = value; }
        }

        public bool Even
        {
            get { return (even); }
            set { even = value; }
        }
    }  
}
