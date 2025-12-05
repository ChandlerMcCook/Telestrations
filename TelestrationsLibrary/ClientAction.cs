using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TelestrationsLibrary;
public record ClientAction
(
    string? Guess = null,
    byte[]? Drawing = null
);
