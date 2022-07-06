namespace BugTrackerTest.Models
{
    public class Ticket
    {
        public int Id{ get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Work Work { get; set; }
        public int WorkId { get; set; }

        public Developer Developer { get; set; }

        public int DeveloperId { get; set; }

        public Priority Priority { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }


    }

    public enum Priority
    {
        Low,
        Medium,
        High,
    }
}
