public class TaskService
{
    public void AddTask(Task task)
    {
        using (var db = new WorkDbContext())
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }
    }
    public void UpdateTask(int id, string newTitle = null, string newDescription = null, bool? newStatus = null, DateTime? newDate = null, int? newCategoryId = null)
    {
        using (var db = new WorkDbContext())
        {
            var task = db.Tasks.Find(id);
            if(newTitle != null) { task.Title = newTitle; }
            if (newDescription != null) { task.Description = newDescription; }
            if (newStatus != null) { task.Status = newStatus.Value; }
            if (newDate != null) { task.Date = newDate.Value; }
            if (newCategoryId != null) { task.CategoryId = newCategoryId.Value; }

            db.SaveChanges();
        }
    }
    public void DeleteTask(int id)
    {
        using (var db = new WorkDbContext())
        {
            var task = db.Tasks.Find(id);
            db.Tasks.Remove(task);

            db.SaveChanges();
        }
    }
    public void PrintTasks()
    {
        using (var db = new WorkDbContext())
        {
            var tasks = db.Tasks.ToList();
            foreach(var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
    public Task FindTask(int id)
    {
        using (var db = new WorkDbContext())
        {
            var task = db.Tasks.Find(id);
            Console.WriteLine(task);
            return task;
        }
    }
}

public class CategoryService
{
    public void AddCategory(Category category)
    {
        using (var db = new WorkDbContext())
        {
            db.Categorys.Add(category);
            db.SaveChanges();
        }
    }
    public void UpdateTask(int id, string newTitle = null, string newDescription = null)
    {
        using (var db = new WorkDbContext())
        {
            var category = db.Categorys.Find(id);
            if (newTitle != null) { category.Title = newTitle; }
            if (newDescription != null) { category.Description = newDescription; }

            db.SaveChanges();
        }
    }
    public void DeleteCategory(int id)
    {
        using (var db = new WorkDbContext())
        {
            var category = db.Categorys.Find(id);
            db.Categorys.Remove(category);

            db.SaveChanges();
        }
    }
    public void PrintCategorys()
    {
        using (var db = new WorkDbContext())
        {
            var categorys = db.Categorys.ToList();
            foreach (var category in categorys)
            {
                Console.WriteLine(category);
            }
        }
    }
    public Category FindCategory(int id)
    {
        using (var db = new WorkDbContext())
        {
            var category = db.Categorys.Find(id);
            Console.WriteLine(category);
            return category;
        }
    }
}
