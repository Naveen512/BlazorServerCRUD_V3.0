using System.Collections.Generic;
using BlazorServer.CRUDApp.Entities;
namespace BlazorServer.CRUDApp.Logics
{
    public interface IGadgetLogic
    {
        Gadget UpdateGadget(Gadget gadget);
        Gadget AddGadget(Gadget gadget);
        IList<Gadget> GetAll();
        void Delete(Gadget gadget);
    }
}