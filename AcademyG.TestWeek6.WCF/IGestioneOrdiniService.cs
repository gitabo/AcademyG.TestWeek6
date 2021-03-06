using AcademyG.TestWeek6.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademyG.TestWeek6.WCF
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IGestioneOrdiniService
    {
        [OperationContract]
        IEnumerable<Cliente> FetchAllClients();

        [OperationContract]
        bool AddClient(Cliente newClient);

        [OperationContract]
        bool EditClient(Cliente editedClient);

        [OperationContract]
        bool DeleteClientById(int idClient);


        // TODO: aggiungere qui le operazioni del servizio
    }

   
}
