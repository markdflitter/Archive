using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VooDooService
{
    class VooDooServicePluginCreator : VooDooServiceHost.IVooDooServicePluginCreator
    {
        public VooDooServiceHost.IVooDooHostServicePlugin Create()
        {
            return new VooServicePlugin();
        }
    }
}
