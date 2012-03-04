using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame
{
    public interface IRoulette
    {
        void Spin();
        Field GetResult();
    }

    public class RouletteStub : IRoulette
    {
        RouletteStub()
        {

        }

        void Spin()
        {

        }

        Field GetResult()
        {
            return 
        }

    }

    public class Roulette : IRoulette
    {

        private List<Field> _fields;
        private Field _result;

        public Roulette()
        {
            _fields = new List<Field>();
            _fields.Add(new Field(0, Field.Green));
            _fields.Add(new Field(1, Field.Red));
            _fields.Add(new Field(2, Field.Black));
            _fields.Add(new Field(3, Field.Red));
            _fields.Add(new Field(4, Field.Black));
            _fields.Add(new Field(5, Field.Red));
            _fields.Add(new Field(6, Field.Black));
            _fields.Add(new Field(7, Field.Red));
            _fields.Add(new Field(8, Field.Black));
            _fields.Add(new Field(9, Field.Red));
            _fields.Add(new Field(10, Field.Black));
            _fields.Add(new Field(11, Field.Black));
            _fields.Add(new Field(12, Field.Red));
            _fields.Add(new Field(13, Field.Black));
            _fields.Add(new Field(14, Field.Red));
            _fields.Add(new Field(15, Field.Black));
            _fields.Add(new Field(16, Field.Red));
            _fields.Add(new Field(17, Field.Black));
            _fields.Add(new Field(18, Field.Red));
            _fields.Add(new Field(19, Field.Red));
            _fields.Add(new Field(20, Field.Black));
            _fields.Add(new Field(21, Field.Red));
            _fields.Add(new Field(22, Field.Black));
            _fields.Add(new Field(23, Field.Red));
            _fields.Add(new Field(24, Field.Black));
            _fields.Add(new Field(25, Field.Red));
            _fields.Add(new Field(26, Field.Black));
            _fields.Add(new Field(27, Field.Red));
            _fields.Add(new Field(28, Field.Black));
            _fields.Add(new Field(29, Field.Black));
            _fields.Add(new Field(30, Field.Red));
            _fields.Add(new Field(31, Field.Black));
            _fields.Add(new Field(32, Field.Red));
            _fields.Add(new Field(33, Field.Black));
            _fields.Add(new Field(34, Field.Red));
            _fields.Add(new Field(35, Field.Black));
            _fields.Add(new Field(36, Field.Red));

            _result = _fields[0];
        }

        public void Spin()
        {
            var n = (uint) new System.Random().Next(0,37);
            _result = _fields[(int) n];
        }

        public Field GetResult()
        {
            return _result;
        }
    }
}
