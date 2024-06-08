namespace TuiTrackerCMS.Models
{
    public enum JobStatus
    {
        Preparing,
        Ready,
        InProgress,
        Blocked,
        Finished,
        Invoiced,
        Paid
    }

    public struct StatusMilestone
    {
        public DateTime CompletedDate { get; set; }
        public JobStatus Status { get; set; }
    }


    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double QuotedPrice { get; set; } = 00.00;
        public Business Business { get; set; } = new Business();
        public Contact Contact { get; set; } = new Contact();
        public Service[] Services { get; set; } = Array.Empty<Service>();
        public Material[] Materials { get; set; } = Array.Empty<Material>();
        public JobStatus Status { get; set; } = JobStatus.Preparing;

        public StatusMilestone[] StatusMilestones { get; set; } = Array.Empty<StatusMilestone>();
    }
}