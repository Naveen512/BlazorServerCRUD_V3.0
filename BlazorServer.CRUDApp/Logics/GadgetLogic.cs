using System.Collections.Generic;
using System.Linq;
using BlazorServer.CRUDApp.Data;
using BlazorServer.CRUDApp.Entities;

namespace BlazorServer.CRUDApp.Logics
{
    public class GadgetLogic : IGadgetLogic
    {
        public readonly MyWorldDbContext _myWorldDbContext;

        public GadgetLogic(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        public void Delete(Gadget gadget)
        {
            _myWorldDbContext.Gadgets.Remove(gadget);
            _myWorldDbContext.SaveChanges();
        }
        public Gadget UpdateGadget(Gadget gadget)
        {
            _myWorldDbContext.Gadgets.Update(gadget);
            _myWorldDbContext.SaveChanges();
            return gadget;
        }
        public Gadget AddGadget(Gadget gadget)
        {
            _myWorldDbContext.Gadgets.Add(gadget);
            _myWorldDbContext.SaveChanges();
            return gadget;
        }

        public IList<Gadget> GetAll()
        {
            IList<Gadget> gadgets = _myWorldDbContext.Gadgets.ToList();
            return gadgets;
        }
    }
}