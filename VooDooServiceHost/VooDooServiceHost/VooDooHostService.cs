using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VooDooServiceHost
{
    public partial class VooDooHostService : ServiceBase
    {
        public VooDooHostService()
        {
            InitializeComponent();
        }

        public void StartVooDooHostService()
        {
        }

        public void StopVooDooHostService()
        {
        }

        protected override void OnStart(string[] args)
        {
            StartVooDooHostService();
        }

        protected override void OnStop()
        {
            StopVooDooHostService();
        }
    }
}
