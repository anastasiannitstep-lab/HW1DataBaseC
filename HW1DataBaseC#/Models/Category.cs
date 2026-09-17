public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }


    public override string ToString()
    {
        return $" Id: {Id}, Title: {Title}, Description: {Description} ";
    }
}
