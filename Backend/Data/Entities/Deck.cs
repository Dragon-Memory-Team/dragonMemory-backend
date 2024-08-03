using System.ComponentModel.DataAnnotations;

namespace Backend.Data.Entities
{
    public class Deck
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();
        
        public int CardsAmount { get { return Cards.Count; } }

    }
}
