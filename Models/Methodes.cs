
using System;
using System.Collections.Generic;
using System.Linq;
using Pomelo;


namespace ServiceBilletterie.Models {
public class Methodes : IDisposable
{

    private eventContext _eventContext;

    public void ViderBDDEvent()
    {
        _eventContext.Database.EnsureDeleted();
        _eventContext.Database.EnsureCreated();
    }
    
    public Methodes()
    {
        _eventContext = new eventContext();
    }

    public List<Evenements> ObtenirEvent()
    {
        return _eventContext.Evenements.ToList();
    }


public int CreerEvenement(string orga,string nomEvent, string lieu, string cat,DateTime datedebut, DateTime datefin, int nbtickets, bool statut)
{
 //eventContext evctxt = new eventContext();
    Evenements nouvelEvenement = new Evenements(){
    Organisateur = orga,
    NomEvent = nomEvent,
    DateDebutEvent = datedebut,
    DateFinEvent = datefin,
    NbTickets = nbtickets,
    LieuEvent = lieu,
    Statut = statut,
    CategorieEvent = cat
 };
 _eventContext.Evenements.Add(nouvelEvenement);
 _eventContext.SaveChanges();
 return nouvelEvenement.IdEvent;
}

public void ModifierEvent(int id, string nom, string lieu)
{
    Evenements eventToChange = _eventContext.Evenements.Find(id);

    if (eventToChange != null)
    {
        eventToChange.LieuEvent = lieu;
        eventToChange.NomEvent = nom;
        _eventContext.SaveChanges();
    }


}

public void ModifierEvent(Evenements eventUpD)
{
    if (eventUpD != null)
    {
        _eventContext.Evenements.Update(eventUpD);
        _eventContext.SaveChanges();
    }
}
public void Dispose()
{
    _eventContext.Dispose();
}
}
}
