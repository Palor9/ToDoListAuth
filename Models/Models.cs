using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAuth.Models;

[Table("users")]
public class User //Модель для создания пользователя 
{
    [Column("id")]
    public int Id { get; set; }
    [Column("login")]
    public string Login { get; set; }
    [Column("password")]
    public string Password { get; set; }
}
