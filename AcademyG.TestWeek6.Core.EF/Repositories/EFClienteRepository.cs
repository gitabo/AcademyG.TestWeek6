using AcademyG.TestWeek6.Core.Interfaces;
using AcademyG.TestWeek6.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyG.TestWeek6.Core.EF.Repositories
{
    public class EFClienteRepository : IClienteRepository
    {
        private readonly GestioneOrdiniContext ctx;

        public EFClienteRepository() : this(new GestioneOrdiniContext()) { }

        public EFClienteRepository(GestioneOrdiniContext ctx)
        {
            this.ctx = ctx;
        }


        public bool Add(Cliente newClient)
        {
            if (newClient == null)
                return false;

            try
            {
                ctx.Clienti.Add(newClient);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Cliente item)
        {
            if (item == null)
                return false;

            try
            {
                var client = ctx.Clienti.Find(item.Id);

                if (client != null)
                    ctx.Clienti.Remove(client);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cliente> Fetch(Func<Cliente, bool> filter = null)
        {
            try
            {
                if (filter != null)
                    return ctx.Clienti.Where(filter).ToList();

                return ctx.Clienti.ToList();
            }
            catch (Exception)
            {
                return new List<Cliente>();
            }
        }

        public Cliente GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Clienti.Find(id);
        }

        public bool Update(Cliente updatedClient)
        {
            if (updatedClient == null)
                return false;

            try
            {
                ctx.Clienti.Update(updatedClient);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
