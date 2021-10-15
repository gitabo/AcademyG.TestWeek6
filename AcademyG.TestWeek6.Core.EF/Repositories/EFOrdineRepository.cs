using AcademyG.TestWeek6.Core.Interfaces;
using AcademyG.TestWeek6.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyG.TestWeek6.Core.EF.Repositories
{
    public class EFOrdineRepository : IOrdineRepository
    {
        private readonly GestioneOrdiniContext ctx;

        public EFOrdineRepository() : this(new GestioneOrdiniContext()) { }

        public EFOrdineRepository(GestioneOrdiniContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(Ordine newOrder)
        {
            if (newOrder == null)
                return false;
            
            try
            {
                ctx.Ordini.Add(newOrder);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Ordine item)
        {
            if (item == null)
                return false;

            try
            {
                var order = ctx.Ordini.Find(item.Id);

                if (order != null)
                    ctx.Ordini.Remove(order);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ordine> Fetch(Func<Ordine, bool> filter = null)
        {
            try
            {
                if (filter != null)
                    return ctx.Ordini.Where(filter).ToList();
                return ctx.Ordini.Include(o => o.Cliente).ToList();
                //return ctx.Ordini.ToList();
            }
            catch (Exception)
            {
                return new List<Ordine>();
            }
        }

        public Ordine GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Ordini.Include(o => o.Cliente).SingleOrDefault(o => o.Id == id);
        }

        public bool Update(Ordine updatedOrder)
        {
            if (updatedOrder == null)
                return false;

            try
            {
                ctx.Ordini.Update(updatedOrder);
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
