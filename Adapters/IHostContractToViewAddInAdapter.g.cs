//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Adapters
{
    
    public class IHostContractToViewAddInAdapter : Start9.Views.IHost
    {
        private Start9.Api.Contracts.IHostContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IHostContractToViewAddInAdapter()
        {
        }
        public IHostContractToViewAddInAdapter(Start9.Api.Contracts.IHostContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public void SendMessage(Start9.Views.IMessage message)
        {
            _contract.SendMessage(Start9.Adapters.IMessageAddInAdapter.ViewToContractAdapter(message));
        }
        public void SaveConfiguration(Start9.Views.IModule module)
        {
            _contract.SaveConfiguration(Start9.Adapters.IModuleAddInAdapter.ViewToContractAdapter(module));
        }
        public System.Collections.Generic.IList<Start9.Views.IModule> GetModules()
        {
            return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IModuleContract, Start9.Views.IModule>(_contract.GetModules(), Start9.Adapters.IModuleAddInAdapter.ContractToViewAdapter, Start9.Adapters.IModuleAddInAdapter.ViewToContractAdapter);
        }
        public Start9.Views.IConfiguration GetGlobalConfiguration()
        {
            return Start9.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.GetGlobalConfiguration());
        }
        internal Start9.Api.Contracts.IHostContract GetSourceContract()
        {
            return _contract;
        }
    }
}

