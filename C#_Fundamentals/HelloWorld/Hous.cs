namespace HouseFunction //Comments
{

    public class House
    {
        public string owner;

        private string ghost;

        private int roomCount;

        public House()
        {
            owner = "JaMia";
            ghost = "Casper";
            roomCount = 1;
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value + " Owner";
            }
        }
            public string Micename { get; set; }
    }
}