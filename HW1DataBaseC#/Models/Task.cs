public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description{ get; set; }
    public bool Status { get; set; }
    public DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public override string ToString()
    {
        return $" Id: {Id}, Title: {Title}, Description: {Description}, Status: {Status}, Date: {Date} ";
    }
}
