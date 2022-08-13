using System.ComponentModel.DataAnnotations;

namespace Bot.Model.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }
    }
}
