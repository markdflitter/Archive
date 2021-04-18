using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VooDooServiceHost
{
    public interface IVooDooHostServicePlugin
    {
        string Name { get; }
        string Version { get; }
    }
}
