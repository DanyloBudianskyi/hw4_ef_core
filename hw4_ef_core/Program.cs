using hw4_ef_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_ef_core
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TaskManager())
            {
                //// Создание пользователей
                //var user1 = new User { Name = "John Doe", Email = "john@example.com" };
                //var user2 = new User { Name = "Jane Smith", Email = "jane@example.com" };

                //// Создание проектов
                //var project1 = new Project { Name = "Project Alpha" };
                //var project2 = new Project { Name = "Project Beta" };

                //// Добавление пользователей и проектов в контекст
                //context.Users.Add(user1);
                //context.Users.Add(user2);
                //context.Projects.Add(project1);
                //context.Projects.Add(project2);

                //// Сохранение изменений
                //context.SaveChanges();

                //// Создание задач
                //var task1 = new hw4_ef_core.Models.Task
                //{
                //    Title = "Task 1",
                //    Description = "Description for Task 1",
                //    UserId = user1.UserId,
                //    ProjectId = project1.ProjectId
                //};

                //var task2 = new hw4_ef_core.Models.Task
                //{
                //    Title = "Task 2",
                //    Description = "Description for Task 2",
                //    UserId = user2.UserId,
                //    ProjectId = project2.ProjectId
                //};

                //// Добавление задач в контекст
                //context.Tasks.Add(task1);
                //context.Tasks.Add(task2);

                //// Сохранение изменений
                //context.SaveChanges();

                // Чтение и вывод данных
                //var Users = context.Users.ToList();
                //foreach (var user in Users)
                //{
                //    Console.WriteLine(user);
                //}
            }
        }
    }
}
