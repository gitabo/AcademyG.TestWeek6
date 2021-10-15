using AcademyG.TestWeek6.Core.Interfaces;
using AcademyG.TestWeek6.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyG.TestWeek6.Core.BusinessLayer
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IClienteRepository clientRepo;
        private readonly IOrdineRepository orderRepo;

        public MainBusinessLayer()
        {
            this.clientRepo = DependencyContainer.Resolve<IClienteRepository>();
            this.orderRepo = DependencyContainer.Resolve<IOrdineRepository>();
        }


        public MainBusinessLayer(IClienteRepository repoClient, IOrdineRepository repoOrder)
        {
            this.clientRepo = repoClient;
            this.orderRepo = repoOrder;
        }

        public bool CreateClient(Cliente newClient)
        {
            if (newClient == null)
                return false;

            return clientRepo.Add(newClient);
        }

        public bool CreateOrder(Ordine newOrder)
        {
            if (newOrder == null)
                return false;

            return orderRepo.Add(newOrder);
        }

        public bool DeleteClientById(int idClient)
        {
            if (idClient <= 0)
                return false;

            Cliente client = this.clientRepo.GetById(idClient);

            if (client != null)
                return clientRepo.Delete(client);

            return false;
        }

        public bool DeleteOrderById(int idOrder)
        {
            if (idOrder <= 0)
                return false;

            Ordine order = this.orderRepo.GetById(idOrder);

            if (order != null)
                return orderRepo.Delete(order);

            return false;
        }

        public bool EditClient(Cliente editedClient)
        {
            if (editedClient == null)
                return false;

            return clientRepo.Update(editedClient);
        }

        public bool EditOrder(Ordine editedOrder)
        {
            if (editedOrder == null)
                return false;

            return orderRepo.Update(editedOrder);
        }

        public Cliente FetchClientById(int id)
        {
            if (id <= 0)
                return null;

            return clientRepo.GetById(id);
        }

        public IEnumerable<Cliente> FetchClients(Func<Cliente, bool> filter = null)
        {
            if (filter != null)
                return clientRepo.Fetch().Where(filter);

            return clientRepo.Fetch();
        }

        public Ordine FetchOrderById(int id)
        {
            if (id <= 0)
                return null;

            return orderRepo.GetById(id);
        }

        public IEnumerable<Ordine> FetchOrders(Func<Ordine, bool> filter = null)
        {
            if (filter != null)
                return orderRepo.Fetch().Where(filter);

            return orderRepo.Fetch();
        }
    }
}
