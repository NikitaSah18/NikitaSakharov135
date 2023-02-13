namespace bank.models
{
    public class numberOfcontract
    {
        public int Id { get; set; }
        public int statementId { get; set; }
        public DateTime dateOfcontract { get; set; }
        public int employeeId { get; set; }
        public int ChartNumber { get; set; }
        public statement? statement { get; set; }

        public employee? employee { get; set; }

        public chartNumber? chartNumber { get; set; }

        


    }
}
