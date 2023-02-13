namespace bank.models
{
    public class post
    {
        public int Id { get; set; }
        public string positionTitle { get; set; }

        public LinkedList<employee> employees { get; set; } = new();
    }
}
