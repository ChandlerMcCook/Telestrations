using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public class Player
{
    public string Name { get; set; }
    public string IP { get; set; }
    public uint ID { get; }
    
    public Player(string name)
    {
        Name = name;
        ID = (uint)DateTime.Now.GetHashCode();
        IP = "In Progress";
    }
}
