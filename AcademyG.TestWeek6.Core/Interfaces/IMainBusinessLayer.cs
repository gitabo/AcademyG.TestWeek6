using AcademyG.TestWeek6.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyG.TestWeek6.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        #region Cliente

        IEnumerable<Cliente> FetchClients(Func<Cliente, bool> filter = null);
        Cliente FetchClientById(int id);
        bool CreateClient(Cliente newClient);
        bool EditClient(Cliente editedClient);
        bool DeleteClientById(int idClient);

        #endregion


        #region Ordine

        IEnumerable<Ordine> FetchOrders(Func<Ordine, bool> filter = null);
        Ordine FetchOrderById(int id);
        bool CreateOrder(Ordine newOrder);
        bool EditOrder(Ordine editedOrder);
        bool DeleteOrderById(int idOrder);

        #endregion
    }
}
