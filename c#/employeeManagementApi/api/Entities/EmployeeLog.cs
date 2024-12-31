namespace API.Entities
{
    public class EmployeeLog
    {
        public int Id { get; set; }
        public string PartitionKey { get; set; } = "EmployeeLog";
        public string RowKey { get; set; } = Guid.NewGuid().ToString();
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.UtcNow;
        public ActionType ActionType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Extension { get; set; }
        public string WorkEmail { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
    }

    public enum ActionType
    {
        Created,
        Updated,
        Deleted
    }
}