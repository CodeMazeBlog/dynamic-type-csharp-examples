namespace DynamicTypeExamples.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public WorkStatus WorkStatus { get; set; }

        public Employee()
        {
            WorkStatus = WorkStatus.NotWorking;
        }

        public WorkStatus GetWorkStatus()
        {
            return WorkStatus;
        }
    }

    public enum WorkStatus
    {
        OnABreak,
        Working,
        NotWorking
    }
}
