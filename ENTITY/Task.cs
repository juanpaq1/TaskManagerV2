using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Task
    {
        public Task(int id, string name, string description, DateTime dueDate)
        {
            Id = id;
            Name = name;
            Description = description;
            DueDate = dueDate;
        }
        public Task()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return ($"{Id};{Name};{Description};{DueDate.ToShortDateString()}");
        }

    }
}
