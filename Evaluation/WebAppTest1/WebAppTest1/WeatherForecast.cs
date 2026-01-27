namespace TaskManagementApi.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskDate { get; set; }
        public string TaskStatus { get; set; }
        public string Remark { get; set; }
    }
}
