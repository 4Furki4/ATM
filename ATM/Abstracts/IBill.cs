namespace ATM.Abstracts
{
    public interface IBill
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public decimal BillAmount { get; set; }
    }
}