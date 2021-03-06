//------------------------------------------------------------------------------
// <auto-generated>
//     Questo codice è stato generato da uno strumento.
//
//     Le modifiche apportate a questo file possono causare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientiService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/AcademyG.TestWeek6.Core.Model")]
    public partial class Cliente : object
    {
        
        private string CodiceClienteField;
        
        private string CognomeField;
        
        private int IdField;
        
        private string NomeField;
        
        private System.Collections.Generic.List<ClientiService.Ordine> OrdiniField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodiceCliente
        {
            get
            {
                return this.CodiceClienteField;
            }
            set
            {
                this.CodiceClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cognome
        {
            get
            {
                return this.CognomeField;
            }
            set
            {
                this.CognomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ClientiService.Ordine> Ordini
        {
            get
            {
                return this.OrdiniField;
            }
            set
            {
                this.OrdiniField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ordine", Namespace="http://schemas.datacontract.org/2004/07/AcademyG.TestWeek6.Core.Model")]
    public partial class Ordine : object
    {
        
        private ClientiService.Cliente ClienteField;
        
        private string CodiceOrdineField;
        
        private string CodiceProdottoField;
        
        private System.DateTime DataOrdineField;
        
        private int IdField;
        
        private decimal ImportoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientiService.Cliente Cliente
        {
            get
            {
                return this.ClienteField;
            }
            set
            {
                this.ClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodiceOrdine
        {
            get
            {
                return this.CodiceOrdineField;
            }
            set
            {
                this.CodiceOrdineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodiceProdotto
        {
            get
            {
                return this.CodiceProdottoField;
            }
            set
            {
                this.CodiceProdottoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataOrdine
        {
            get
            {
                return this.DataOrdineField;
            }
            set
            {
                this.DataOrdineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Importo
        {
            get
            {
                return this.ImportoField;
            }
            set
            {
                this.ImportoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientiService.IGestioneOrdiniService")]
    public interface IGestioneOrdiniService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestioneOrdiniService/FetchAllClients", ReplyAction="http://tempuri.org/IGestioneOrdiniService/FetchAllClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClientiService.Cliente>> FetchAllClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestioneOrdiniService/AddClient", ReplyAction="http://tempuri.org/IGestioneOrdiniService/AddClientResponse")]
        System.Threading.Tasks.Task<bool> AddClientAsync(ClientiService.Cliente newClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestioneOrdiniService/EditClient", ReplyAction="http://tempuri.org/IGestioneOrdiniService/EditClientResponse")]
        System.Threading.Tasks.Task<bool> EditClientAsync(ClientiService.Cliente editedClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestioneOrdiniService/DeleteClientById", ReplyAction="http://tempuri.org/IGestioneOrdiniService/DeleteClientByIdResponse")]
        System.Threading.Tasks.Task<bool> DeleteClientByIdAsync(int idClient);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IGestioneOrdiniServiceChannel : ClientiService.IGestioneOrdiniService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class GestioneOrdiniServiceClient : System.ServiceModel.ClientBase<ClientiService.IGestioneOrdiniService>, ClientiService.IGestioneOrdiniService
    {
        
        /// <summary>
        /// Implementare questo metodo parziale per configurare l'endpoint servizio.
        /// </summary>
        /// <param name="serviceEndpoint">Endpoint da configurare</param>
        /// <param name="clientCredentials">Credenziali del client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GestioneOrdiniServiceClient() : 
                base(GestioneOrdiniServiceClient.GetDefaultBinding(), GestioneOrdiniServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IGestioneOrdiniService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestioneOrdiniServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(GestioneOrdiniServiceClient.GetBindingForEndpoint(endpointConfiguration), GestioneOrdiniServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestioneOrdiniServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GestioneOrdiniServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestioneOrdiniServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GestioneOrdiniServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GestioneOrdiniServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClientiService.Cliente>> FetchAllClientsAsync()
        {
            return base.Channel.FetchAllClientsAsync();
        }
        
        public System.Threading.Tasks.Task<bool> AddClientAsync(ClientiService.Cliente newClient)
        {
            return base.Channel.AddClientAsync(newClient);
        }
        
        public System.Threading.Tasks.Task<bool> EditClientAsync(ClientiService.Cliente editedClient)
        {
            return base.Channel.EditClientAsync(editedClient);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClientByIdAsync(int idClient)
        {
            return base.Channel.DeleteClientByIdAsync(idClient);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestioneOrdiniService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGestioneOrdiniService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:7713/");
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GestioneOrdiniServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IGestioneOrdiniService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GestioneOrdiniServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IGestioneOrdiniService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IGestioneOrdiniService,
        }
    }
}
