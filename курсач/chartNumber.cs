namespace bank.models 
{
    public class chartNumber
    {
        public int ChartNumber { get; set; }
        public DateTime dateOfchart { get; set; }
        public string procent { get; set; }

        public decimal debt { get; set; }

        public LinkedList<numberOfcontract> numberOfcontracts { get; set; } = new();
    }
}
