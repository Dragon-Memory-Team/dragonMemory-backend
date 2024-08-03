using Backend.Data;
using Backend.Data.Entities;
using Backend.Data.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DeckController(ApplicationDbContext context) { _context = context; }


        [HttpPost("createDeck")]
        public async Task<IActionResult> CreateDeck([FromBody] DeckDTO deck)
        {
            if (deck == null || string.IsNullOrEmpty(deck.Name))
            {
                return BadRequest("Invalid Deck Name");
            }

            var newDeck = MapDeckDTOToDeck(deck);

            _context.Decks.Add(newDeck);
            //_context.Decks.Add(deck);
            await _context.SaveChangesAsync();
            return Ok(deck);
        }

        private Deck MapDeckDTOToDeck(DeckDTO deckDTO)
        {
            return new Deck
            {
                Name = deckDTO.Name,
                // Initialize other properties if needed
            };
        }

    }
}
