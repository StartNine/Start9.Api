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
    
    public class IModuleAssemblyAddInAdapter
    {
        internal static Start9.Views.IModuleAssembly ContractToViewAdapter(Start9.Api.Contracts.IModuleAssemblyContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IModuleAssemblyViewToContractAddInAdapter))))
            {
                return ((IModuleAssemblyViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IModuleAssemblyContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IModuleAssemblyContract ViewToContractAdapter(Start9.Views.IModuleAssembly view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IModuleAssemblyContractToViewAddInAdapter)))
            {
                return ((IModuleAssemblyContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IModuleAssemblyViewToContractAddInAdapter(view);
            }
        }
    }
}

