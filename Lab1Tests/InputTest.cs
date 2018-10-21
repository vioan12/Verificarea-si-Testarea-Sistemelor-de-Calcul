using System;
using Lab1;

namespace Lab1Tests
{
    public class InputTest : Input
    {
        private string[] _inputDates;
        private int _index;

        public InputTest(string[] inputDates)
        {
            _inputDates = inputDates;
            _index = 0;
        }
        public override string ReadDataByLine()
        {
            return _inputDates[_index++];
        }
    }
}