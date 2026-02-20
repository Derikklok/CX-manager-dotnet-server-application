using System;
// Folder for your code
namespace TaskManagementSystem.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set;} = string.Empty;
    
    public DateTime CtreatedAt {get;set;} = DateTime.UtcNow;

    // Relationships - EF core list 
    // One user can have many projects
    public ICollection<Project> Projects {get;set;} = new List<Project>();
}
