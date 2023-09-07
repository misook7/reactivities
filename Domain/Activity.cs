namespace Domain
{
    public class Activity // class name relates to a table
    {
        // properties relates to a column in the table
        // Entity Framework will recognize this should be the primary key of database tale

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        
    }
}