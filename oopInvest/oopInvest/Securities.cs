using System;
using System.Collections.Generic;
using System.Text;

namespace oopInvest
{
    class Securities
    {
        private int _codeSecurities;
        private int _sumMin;
        private int _score;
        private int _revenueYear;

        public Securities() { }
        public Securities(int CodeSecurities) { _codeSecurities = CodeSecurities; }
        public Securities(int CodeSecurities, int SumMin, int Score, int RevenueYear)
        {
            _codeSecurities = CodeSecurities;
            _sumMin = SumMin;
            _score = Score;
            _revenueYear = RevenueYear;
        }

        public int GetCodeSecurities()
        {
            return _codeSecurities;
        }
        public int GetSumMin()
        {
            return _sumMin;
        }
        public int GetScore()
        {
            return _score;
        }
        public int GetRevenueYear()
        {
            return _revenueYear;
        }
    }
}
