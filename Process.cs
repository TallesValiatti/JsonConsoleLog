namespace WorkerApp
{
  class Process
    {
        public Guid Id { get; set; }
        public bool hasAllTheNecessaryInfo { get; set; }
        public Process(bool hasAllTheNecessaryInfo)
        {
            this.Id = Guid.NewGuid();
            this.hasAllTheNecessaryInfo = hasAllTheNecessaryInfo;
        }

        internal void Execute()
        {
            // Some business logic
        }
    }
}