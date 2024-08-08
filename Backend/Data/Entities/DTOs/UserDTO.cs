namespace Backend.Data.Entities.DTOs
{
    public class UserDTO
    {
        public UserDTO(User user)
        {
            
        }

        public string Username { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
    }
}
