using AcademyG.TestWeek6.Core;
using AcademyG.TestWeek6.Core.BusinessLayer;
using AcademyG.TestWeek6.Core.EF.Repositories;
using AcademyG.TestWeek6.Core.Interfaces;
using AcademyG.TestWeek6.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademyG.TestWeek6.WCF
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class GestioneOrdiniService : IGestioneOrdiniService
    {
        IMainBusinessLayer mainBL;

        public GestioneOrdiniService()
        {
            // Configurazione DI
            DependencyContainer.Register<IMainBusinessLayer, MainBusinessLayer>();
            DependencyContainer.Register<IClienteRepository, EFClienteRepository>();
            DependencyContainer.Register<IOrdineRepository, EFOrdineRepository>();

            // Risoluzione
            this.mainBL = DependencyContainer.Resolve<IMainBusinessLayer>();

        }

        public bool AddClient(Cliente newClient)
        {
            if (newClient == null)
                return false;

            return this.mainBL.CreateClient(newClient);
        }

        public bool DeleteClientById(int idClient)
        {
            if (idClient > 0)
                return this.mainBL.DeleteClientById(idClient);

            return false;
        }

        public bool EditClient(Cliente editedClient)
        {
            if (editedClient == null)
                return false;

            return this.mainBL.EditClient(editedClient);
        }

        public IEnumerable<Cliente> FetchAllClients()
        {
            return this.mainBL.FetchClients();
        }
    }
}
