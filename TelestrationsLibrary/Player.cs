using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public class Player
{
    public string Name { get; set; }
    public uint ID { get; }
    
    public Player(string name)
    {
        Name = name;
        ID = (uint)DateTime.Now.GetHashCode();
    }

    public Player(string name, uint id)
    {
        Name = name;
        ID = id;
    }
}
