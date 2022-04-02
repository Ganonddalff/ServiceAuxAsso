using System;

namespace AssoFlex.Models
{
    public class DefaultEvents
    {
        public static void InitializeEvents()
        {
            using (IDal _dal = new Dal())
            {
                _dal.CreateEvenement(
                    _dal.GetAssociation(1),
                    "Eminem", 
                    50, 
                    new DateTime(2022, 12, 30), 
                    new DateTime(2022, 12, 30), 
                    "ACCORD ARENA",
                    "default-spectacle.jpg",
                    "5",
                    90,
                    "Slim Shady, the real Slim Shady. \nPlease, stand up."
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(1),
                    "PNL",
                    50,
                    new DateTime(2022, 12, 30),
                    new DateTime(2022, 12, 30),
                    "ACCORD ARENA",
                    "default-spectacle.jpg",
                    "5",
                    10,
                    "Concert pour collégiens."
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(3),
                    "Eminem", 
                    50,
                    new DateTime(2022, 12, 30),
                    new DateTime(2022, 12, 30),
                    "ACCORD ARENA",
                    "default-spectacle.jpg",
                    "5",
                    100,
                    "Slim Shady, the real Slim Shady. \nPlease, stand up."
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "Concert super",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    "C'est un concert qu'a l'air bien."
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "Red country",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Lille",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    ""
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "High school musical",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    ""
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "DTF",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    ""
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "FAST&FOOD",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "NY",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    ""
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "Daggers",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Londres",
                    "default-spectacle.jpg",
                    "1",
                    5,
                    ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Sunset",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Garage Monster",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Movie cars",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Back to the past",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Yin & Ytwo",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "SaltPeps",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Hara kiri",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Paris Papleure",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Satantine",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Con sert deux l'eau riz",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   ""
                );
            }
        }
    }
}