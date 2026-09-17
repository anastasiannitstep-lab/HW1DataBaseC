using System;
using System.Collections.Generic;
using System.Text;

namespace HW1DataBaseC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskService ts = new TaskService();
            CategoryService cs = new CategoryService();

            /*cs.DeleteCategory(1);
            cs.DeleteCategory(1);
            cs.DeleteCategory(1);*/

            cs.AddCategory(new Category { Title = "Work and Business Tasks", Description = "Work and Business Tasks" });
            cs.AddCategory(new Category { Title = "Educational and Academic Assignments", Description = "Educational and Academic Assignments" });
            cs.AddCategory(new Category { Title = "Gaming and Entertainment Tasks (Quests)", Description = "Gaming and Entertainment Tasks (Quests)" });

            ts.AddTask(new Task { Title = "Technical Specification (Spec)", Description = "A clear document outlining requirements for the development of a product, website, or design.", Status = true, Date = new DateTime(2008, 5, 1, 8, 30, 52), CategoryId = 1});
            ts.AddTask(new Task { Title = "Business Trip Assignment", Description = "A list of goals and tasks an employee must complete during a work-related trip.", Status = true, Date = new DateTime(2008, 5, 1, 8, 30, 52), CategoryId = 1 });
            ts.AddTask(new Task { Title = "Creative Assignment", Description = "An essay, paper, project, or presentation requiring an individual approach and creativity.", Status = false, Date = new DateTime(2008, 5, 1, 8, 30, 52), CategoryId = 2 });
            ts.AddTask(new Task { Title = "Homework", Description = "Independent work performed by a student outside of school or university to reinforce the material.", Status = false, Date = new DateTime(2008, 5, 1, 8, 30, 52), CategoryId = 2 });
            ts.AddTask(new Task { Title = "Logic Tasks / Riddles", Description = "Intellectual challenges found in real-life escape rooms or board games.", Status = true, Date = new DateTime(2008, 5, 1, 8, 30, 52), CategoryId = 3});

            ts.UpdateTask(1, newCategoryId:4);
            ts.UpdateTask(2, newCategoryId: 4);
            ts.UpdateTask(3, newCategoryId: 5);
            ts.UpdateTask(4, newCategoryId: 5);
            ts.UpdateTask(5, newCategoryId: 6);

            ts.FindTask(4);
            cs.FindCategory(5);

            Console.WriteLine();

            ts.PrintTasks();

            Console.WriteLine();

            cs.PrintCategorys();
        }
    }
}