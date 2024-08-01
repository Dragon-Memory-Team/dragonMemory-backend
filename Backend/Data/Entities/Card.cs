using System.ComponentModel.DataAnnotations;

namespace Backend.Data.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; } 
        public string FrontCard { get; set; }

        public string BackCard { get; set; }
    }
}
