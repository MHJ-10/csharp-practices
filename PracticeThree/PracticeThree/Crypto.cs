namespace PracticeThree
{
    public class Crypto
    {
        public CoinInfo CoinInfo { get; set; }
        public DISPLAY? DISPLAY { get; set; }
    }

    public class CoinInfo
    {
        public string Name { get; set; }
        public string FullName { get; set; }
    }
    public class DISPLAY
    {
        public USD USD { get; set; }
    }
    public class USD
    {
        public string PRICE { get; set; }
    }





}
