namespace ATM.Abstracts
{
    public interface IUser
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public decimal Balance { get; set; }

        public string Password { get; set; }

        public List<ILog> Records { get; set; }
    }
}