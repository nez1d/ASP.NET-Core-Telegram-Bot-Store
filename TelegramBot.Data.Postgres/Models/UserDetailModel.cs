using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class UserDetailModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public string Phone { get; set; }
    [Required]
    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    [Required]
    public DateTime AccountCreatedDate { get; set; }
    [Required]
    public UserModel User { get; set; }
}

