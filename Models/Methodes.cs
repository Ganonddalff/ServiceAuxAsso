
using System;
using System.Collections.Generic;
using System.Globalization;
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


public int CreerEvenement(string orga,string nomEvent, string lieu, string cat, DateTime datedebut, DateTime datefin, int nbtickets, bool statut)
{

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

public int ModifierEvent(int id, string nom, string lieu, DateTime datedebut, DateTime datefin)
{
    Evenements eventToChange = _eventContext.Evenements.Find(id);

    if (eventToChange != null)
    {
        eventToChange.LieuEvent = lieu;
        eventToChange.NomEvent = nom;
        eventToChange.DateDebutEvent = datedebut;
        eventToChange.DateFinEvent = datefin;
        _eventContext.SaveChanges();
    }

    return eventToChange.IdEvent;
}

public void ModifierEvent(Evenements eventUpD)
{
    if (eventUpD != null)
    {
        _eventContext.Evenements.Update(eventUpD);
        _eventContext.SaveChanges();
    }
}

public Evenements GetEvent (int id)
{
    Evenements eventToGet = _eventContext.Evenements.Find(id);
    return eventToGet;
}

public void deleteEvent(int id)
{
    Evenements eventToDelete = _eventContext.Evenements.Find(id);
    if (eventToDelete != null)
    {
        _eventContext.Evenements.Remove(eventToDelete);
        _eventContext.SaveChanges();
    }
}

public void Dispose()
{
    _eventContext.Dispose();
}
}
}