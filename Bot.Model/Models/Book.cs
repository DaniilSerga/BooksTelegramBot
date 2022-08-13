using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bot.Model.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
    }
}
