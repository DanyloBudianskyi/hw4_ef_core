using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace hw4_ef_core.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public ICollection<Models.Task> Tasks { get; set; }
        public ICollection<Models.User> Users { get; set; }
        public override string ToString()
        {
            string result = $"Id: {ProjectId}, Name: {Name}\nTasks:\n";
            foreach (var item in Tasks.ToList())
            {
                result += "\t" + item.ToString() + "\n";
            }
            return result ;
        }
    }
}
