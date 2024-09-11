namespace LotoDemo.Models
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

    internal class LottoChecker2 : ILottoChecker
    {
        public LottoChecker2()
        {
        }

        public eCellStatus IsRightNumber(int number)
        {
            int itemIndex = number % 6;

            switch(itemIndex)
            {
                case 0: 
                case 1: 
                    return eCellStatus.Good;

                case 2:
                case 3:
                    return eCellStatus.Bad;

                case 4:
                case 5:
                    return eCellStatus.Empty;
            }

            return eCellStatus.Empty;
        }
    }
}
