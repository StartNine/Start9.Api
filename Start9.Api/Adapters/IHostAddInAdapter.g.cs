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
    
    public class IHostAddInAdapter
    {
        internal static Start9.Views.IHost ContractToViewAdapter(Start9.Api.Contracts.IHostContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IHostViewToContractAddInAdapter))))
            {
                return ((IHostViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IHostContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IHostContract ViewToContractAdapter(Start9.Views.IHost view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IHostContractToViewAddInAdapter)))
            {
                return ((IHostContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IHostViewToContractAddInAdapter(view);
            }
        }
    }
}

