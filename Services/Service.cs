using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.VIP_Menuer;

namespace Event_application.Services
{
    //public class Service : IServicecs
    //{
    ////    private readonly List<Almindelig> _almindeligMenu;
    ////    private readonly List<Vegansk> _veganskMenu;
    ////    private readonly List<Champagne> _ChampagneMenu;


    //    public Service()
    //    {
    //        _almindeligMenu = Catalog.GetMocAlmindelig();
    //        _veganskMenu = Catalog.GetMocVegansk();
    //        _ChampagneMenu = Catalog.GetMocVhampagne();
    //    }

    //    public List<Almindelig> GetAllA()
    //    {
    //        return new List<Almindelig>(_almindeligMenu);
    //    }

    //    public List<Vegansk> GetAllV()
    //    {
    //        return new List<Vegansk>(_veganskMenu);
    //    }

    //    public List<Champagne> GetAllC()
    //    {
    //        return new List<Champagne>(_ChampagneMenu);
    //    }

    //    public Almindelig GetByIdA(int id)
    //    {
    //        Almindelig al = _almindeligMenu.Find(a => a.Id == id);
    //        if (al == null)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        return al;
    //    }

    //    public Almindelig CreateA(Almindelig newAlmindelig)
    //    {

    //        _almindeligMenu.Add(newAlmindelig);

    //        return newAlmindelig;
    //    }

    //    public Almindelig DeleteA(int id)
    //    {
    //        Almindelig al = GetByIdA(id);

    //        _almindeligMenu.Remove(al);

    //        return al;
    //    }

    //    public Almindelig ModifyA(Almindelig modifiedAlmindelig)
    //    {
    //        int ix = _almindeligMenu.FindIndex(a => a.Id == modifiedAlmindelig.Id);
    //        if (ix == -1)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        _almindeligMenu[ix] = modifiedAlmindelig;

    //        return modifiedAlmindelig;
    //    }

    //    public Vegansk GetByIdV(int id)
    //    {
    //        Vegansk ve = _veganskMenu.Find(v => v.Id == id);
    //        if (ve == null)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        return ve;
    //    }

    //    public Vegansk CreateV(Vegansk newVegansk)
    //    {
    //        _veganskMenu.Add(newVegansk);

    //        return newVegansk;
    //    }

    //    public Vegansk DeleteV(int id)
    //    {
    //        Vegansk ve = GetByIdV(id);

    //        _veganskMenu.Remove(ve);

    //        return ve;
    //    }

    //    public Vegansk ModifyV(Vegansk modifiedVegansk)
    //    {
    //        int ix = _veganskMenu.FindIndex(v => v.Id == modifiedVegansk.Id);
    //        if (ix == -1)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        _veganskMenu[ix] = modifiedVegansk;

    //        return modifiedVegansk;
    //    }


    //    public Champagne GetByIdC(int id)
    //    {
    //        Champagne ch = _ChampagneMenu.Find(c => c.Id == id);
    //        if (ch == null)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        return ch;

    //    }


    //    public Champagne CreateC(Champagne newChampagne)
    //    {
    //        _ChampagneMenu.Add(newChampagne);

    //        return newChampagne;
    //    }

    //    public Champagne DeleteC(int id)
    //    {
    //        Champagne ch = GetByIdC(id);

    //        _ChampagneMenu.Remove(ch);

    //        return ch;
    //    }

    //    public Champagne ModifyC(Champagne modifiedChampagne)
    //    {
    //        int ix = _ChampagneMenu.FindIndex(c => c.Id == modifiedChampagne.Id);
    //        if (ix == -1)
    //        {
    //            throw new KeyNotFoundException();
    //        }

    //        _ChampagneMenu[ix] = modifiedChampagne;

    //        return modifiedChampagne;
    //    }
    //}
}
