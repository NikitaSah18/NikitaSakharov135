namespace bank.models
{
    public class View
    {
        public int Id { get; set; }
        public string TypeOfLoan { get; set; }

        public string percent { get; set;}

        public LinkedList<statement> statements { get; set; } = new();
    }
}
