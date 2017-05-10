using ODataService314e;
using System;
using System.Data.Services;
using System.ServiceProcess;

namespace WindowsService314e
{
    public partial class DataService : ServiceBase
    {
        public DataServiceHost serviceHost = null;
       
        public DataService()
        {
            InitializeComponent();
            ServiceName = "DataService314e";
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            Type serviceType = typeof(ODataService);
            Uri baseAddress = new Uri("http://localhost:6000/");
            Uri[] baseAddresses = new Uri[] { baseAddress };

            // Create a new hosting instance for the 314e_Datamart 
            // data service at the specified address. 
            DataServiceHost host = new DataServiceHost(
               serviceType,
               baseAddresses);
            host.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
