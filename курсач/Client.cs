namespace bank.models
{
    public class client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }


        public LinkedList<statement> statements { get; set; } = new();
    }
}
