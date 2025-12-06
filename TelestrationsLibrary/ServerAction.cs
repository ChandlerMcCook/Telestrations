using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public enum ActionType { 
    Draw = 0,
    Guess = 1,
    Wait = 2,
    Create = 3,
    CreateAndDraw = 4,
    Finish = 5
}
public record ServerAction
(
    ActionType Action,
    string? Guess = null, 
    byte[]? Drawing = null 
);
