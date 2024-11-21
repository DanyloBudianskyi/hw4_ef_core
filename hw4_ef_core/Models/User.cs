using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace hw4_ef_core.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Models.Task> Tasks { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public override string ToString()
        {
            string result = $"Id: {UserId}, Name: {Name}\nTasks:\n";
            foreach (var item in Tasks.ToList())
            {
                result += "\t" + item.ToString() + "\n";
            }
            return result;
        }
    }
}
