namespace DataAccessLibrary.Models;

public class GameModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Started { get; set; }
    public DateTime CreatedAt { get; set; }
    public int HostId { get; set; }
}