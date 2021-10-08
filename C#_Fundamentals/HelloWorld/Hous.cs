namespace HouseFunction
{

    public class House
    {
        private string owner;

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
            }

            public string Micename { get; set; }
    }
}