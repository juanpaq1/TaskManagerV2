using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class TaskRepository
    {
        string fileNme = "task.txt";
       
        public string SaveTask(ENTITY.Task task)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(fileNme, true);
                Writer.WriteLine(task.ToString());
                Writer.Close();
                return "tarea almacenada correctamente";
            }
            catch (Exception ex)
            {
                return ("error al guardar " + ex.Message);
            }
            
        }
        public List<ENTITY.Task> GetAllTask()
        {
            try
            {
                List<ENTITY.Task> tasks = new List<ENTITY.Task>();
                string line;
                StreamReader reader = new StreamReader(fileNme);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    tasks.Add(Map(line));                   
                }
                reader.Close();
                return tasks;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private ENTITY.Task Map(string line)
        {
            ENTITY.Task task = new ENTITY.Task();
            task.Id = int.Parse(line.Split(';')[0]);
            task.Name = line.Split(';')[1];
            task.Description = line.Split(';')[2];
            task.DueDate =DateTime.Parse( line.Split(';')[3]);
            return task;
        }
    }
}
