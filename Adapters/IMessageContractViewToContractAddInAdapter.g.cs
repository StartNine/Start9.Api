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
    
    public class IMessageContractViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageContractContract
    {
        private Start9.Views.IMessageContract _view;
        public IMessageContractViewToContractAddInAdapter(Start9.Views.IMessageContract view)
        {
            _view = view;
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IMessageEntryContract> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Start9.Views.IMessageEntry, Start9.Api.Contracts.IMessageEntryContract>(_view.Entries, Start9.Adapters.IMessageEntryAddInAdapter.ViewToContractAdapter, Start9.Adapters.IMessageEntryAddInAdapter.ContractToViewAdapter);
            }
        }
        internal Start9.Views.IMessageContract GetSourceView()
        {
            return _view;
        }
    }
}

