using System.ComponentModel.DataAnnotations;

namespace API;

public class AppUser
{
    [Key]
    public int id { get; set; }
    public string UserName { get; set; }
}
