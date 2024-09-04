using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task1 = new ENTITY.Task(1, "Tarea 1", "Hacer tarea 1", new DateTime(2024, 2, 3));
            var task2 = new ENTITY.Task(2, "Tarea 2", "Hacer tarea 2", new DateTime(2024, 3, 15));
            var task3 = new ENTITY.Task(3, "Tarea 3", "Hacer tarea 3", new DateTime(2024, 4, 10));
            var task4 = new ENTITY.Task(4, "Tarea 4", "Hacer tarea 4", new DateTime(2024, 5, 20));
            var task5 = new ENTITY.Task(5, "Tarea 5", "Hacer tarea 5", new DateTime(2024, 6, 25));

            DAL.TaskRepository repository = new DAL.TaskRepository();

            //Console.WriteLine(repository.SaveTask(task1));
            //Console.WriteLine(repository.SaveTask(task2));
            //Console.WriteLine(repository.SaveTask(task3));
            //Console.WriteLine(repository.SaveTask(task4));
            //Console.WriteLine(repository.SaveTask(task5));

            var lista = repository.GetAllTask();
            Console.WriteLine("id -------- nombre");
            foreach (var task in lista)
            {
                Console.WriteLine($"{task.Id}     -    {task.Name}");
            }
            Console.ReadKey();
        }
    }
}
