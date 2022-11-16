namespace ATM.Abstracts
{
    public interface ILog
    {
        public Guid Id { get; set; }

        public List<IUser> Users { get; set; }

        public string TransectionType { get; set; }

        public decimal TransectionAmount { get; set; }

        public decimal LastBalance { get; set; }


        public void Log(string message);

        public string ReadLog();

    }
}