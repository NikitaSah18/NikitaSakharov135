namespace bank.models
{
    public class employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int postId { get; set; }

        public post? post { get; set; }

        public LinkedList<numberOfcontract> numberOfcontracts { get; set; } = new();
    }
}
