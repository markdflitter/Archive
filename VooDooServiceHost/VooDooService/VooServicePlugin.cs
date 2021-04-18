using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VooDooService
{
    class VooServicePlugin : VooDooServiceHost.IVooDooHostServicePlugin
    {
        public string Name
        {
            get { return "VooServicePlugin"; }
        }

        public string Version
        {
            get { return "1.0.0.0"; }
        }
    }
}
