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

        public FieldStub()
        {

            Number = 2;
            Color = Field.Black;
            Even = true;
        }

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

    public class RouletteStub : IRoulette
    {
        // Members
        Field fResult;

        public RouletteStub()
        {
            fResult = new Field(2, Field.Black);
        }

        public void Spin()
        {

        }

        public Field GetResult()
        {
            return (fResult);
        }
    }
}
