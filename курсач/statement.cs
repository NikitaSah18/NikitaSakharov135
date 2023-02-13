namespace bank.models
{
    public class statement

    {
        public int Id { get; set; }
        public DateOnly date { get; set; }
        public int sum { get; set; }
        public string currency { get; set; }
        public int clientId { get; set; }

        public string ViewId  { get; set; }

        public client? clients { get; set; }
        public View? views { get; set; }

        public LinkedList<statement> statements { get; set; } = new();




    }
}
