using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame.Tests
{
    public class FieldStub : IField
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

        public Field Result
        {
            get { return (fResult); }
            set { fResult = value; }
        }
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

    public class BetStub : IBet
    {
        private string playerName;

        private uint amount;

        public BetStub()
        {
            playerName = "User 1";
            amount = 100;
        }

        public string PlayerName
        {
            get { return playerName; }
        }

        public uint Amount
        {
            set { amount = value; }
            get { return amount; }
        }

        public uint WonAmount(IField field)
        {
            return(amount);
        }
    }

    public class UIStub : UI
    {
        // Members
        string sPrintString;

        public string String
        {
            get { return (sPrintString); }
        }
        public override void PrintString(string _str, params object[] args)
        {
            StringBuilder sbStringCombined = new StringBuilder();
            sbStringCombined.AppendFormat(_str, args);
            sPrintString = sbStringCombined.ToString();
            base.PrintString(_str, args);
        }
    }
}
