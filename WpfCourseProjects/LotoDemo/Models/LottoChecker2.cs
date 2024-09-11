namespace LotoDemo.Models
{
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
