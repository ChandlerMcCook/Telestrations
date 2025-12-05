using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public enum ActionType { Draw, Guess, Wait, Create, CreateAndDraw, Finish }
public record ServerAction
(
    ActionType Action,
    string? Guess = null, 
    byte[]? Drawing = null 
);
