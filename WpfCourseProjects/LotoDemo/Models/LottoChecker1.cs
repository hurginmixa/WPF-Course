﻿namespace LotoDemo.Models
{
    internal class LottoChecker1 : ILottoChecker
    {
        public LottoChecker1()
        {
        }

        public eCellStatus IsRightNumber(int number)
        {
            int itemIndex = number % 3;

            switch(itemIndex)
            {
                case 0: 
                    return eCellStatus.Good;

                case 1:
                    return eCellStatus.Bad;

                case 2:
                    return eCellStatus.Empty;
            }

            return eCellStatus.Empty;
        }
    }
}
