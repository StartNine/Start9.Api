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
    
    public class IReceiverEntryAddInAdapter
    {
        internal static Start9.Views.IReceiverEntry ContractToViewAdapter(Start9.Api.Contracts.IReceiverEntryContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IReceiverEntryViewToContractAddInAdapter))))
            {
                return ((IReceiverEntryViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IReceiverEntryContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IReceiverEntryContract ViewToContractAdapter(Start9.Views.IReceiverEntry view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IReceiverEntryContractToViewAddInAdapter)))
            {
                return ((IReceiverEntryContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IReceiverEntryViewToContractAddInAdapter(view);
            }
        }
    }
}

