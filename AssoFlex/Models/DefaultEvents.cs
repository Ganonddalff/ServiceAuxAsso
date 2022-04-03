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
                    "PussycatDolls", 
                    50, 
                    new DateTime(2022, 12, 30), 
                    new DateTime(2022, 12, 30), 
                    "ACCORD ARENA",
                    "jaiho.jpg",
                    "5",
                    90,
                    "When i grow up!. \nJai ho, nananana!.",
                    "https://www.youtube.com/watch?v=Yc5OyXmHD0w"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(1),
                    "PNL",
                    50,
                    new DateTime(2022, 12, 30),
                    new DateTime(2022, 12, 30),
                    "ACCORD ARENA",
                    "PNL.jpg",
                    "5",
                    10,
                    "Concert pour collégiens.",
                    "https://www.youtube.com/watch?v=BtyHYIpykN0"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(3),
                    "Eminem ", 
                    50,
                    new DateTime(2022, 12, 30),
                    new DateTime(2022, 12, 30),
                    "ACCORD ARENA",
                    "eminem.jpg",
                    "5",
                    100,
                    "Slim Shady, the real Slim Shady. \nPlease, stand up.",
                    "https://www.youtube.com/watch?v=_Yhyp-_hX2s"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "Concert super",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "consup.jpg",
                    "1",
                    5,
                    "C'est le concert super attendue, super pas cher, et surtout SUPER.",
                    "https://www.youtube.com/watch?v=DwoIiK68e3o"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "Michael Jackson & Coffee",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Lille",
                    "mj.jpg",
                    "1",
                    5,
                    "Chorégraphie,chant et collation. THIS IS SO BAD",
                    "https://www.youtube.com/watch?v=UNFwkeBopCM"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "High school musical",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "HSM.jpg",
                    "1",
                    5,
                    "ZACK IL EST TROP BEAUUUUU",
                    "https://www.youtube.com/watch?v=0qj67KE5VXI"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "DTF",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Paris",
                    "DTF.png",
                    "1",
                    5,
                    "Moment à ne pas rater avec l'organisation DTF afin de discuter de sujets divers et variés",
                    "https://www.youtube.com/watch?v=ahladr74Kr8"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "FAST&FOOD",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "NY",
                    "logo_fastandfood.jpg",
                    "1",
                    5,
                    "Vérifiez vos huiles moteur parceque l'on a faim!",
                    "https://www.youtube.com/watch?v=4sQB2ZgLYs4"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(2),
                    "DBZ",
                    200,
                    new DateTime(2022, 04, 02),
                    new DateTime(2022, 04, 03),
                    "Londres",
                    "dbz.gif",
                    "1",
                    5,
                    "Dormir Bien ZzzzZ",
                    "https://www.youtube.com/watch?v=sFWki-0yMXY"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Sunny",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "selling.jpg",
                   "1",
                   5,
                   "Offre de logement en promo",
                   "https://www.youtube.com/watch?v=DXdO0Revllc"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Soirée Gare Monster",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "monster.jpg",
                   "1",
                   5,
                   "Il y a un monstre dans le garage",
                   "https://www.youtube.com/watch?v=WFgycBCWxQ8"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Karz",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "karz.jpg",
                   "1",
                   5,
                   "C'est le moment d'échanger vos cars",
                   "https://www.youtube.com/watch?v=ZkDNVGrCpHQ"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Back to the past",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "bttp.jpg",
                   "1",
                   5,
                   "Apprendre les techniques de self defense en LIVE",
                   "https://www.youtube.com/watch?v=O6GfD9A-XAw"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Yin & Ytwo",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "YY.jpg",
                   "1",
                   5,
                   "Yin & Yang ? Nan. Yin & Ytwo, pour vous servir.",
                   "https://www.youtube.com/watch?v=kH0NsmFZzZg"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "SaltPeps",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "saltpepps.jpg",
                   "1",
                   5,
                   "Tu veux du power? Prend ton salt and pepps.",
                   "https://www.youtube.com/watch?v=MxJzWGbG8vo"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Hara kiri",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "kiri.jpg",
                   "1",
                   5,
                   "Un kiri à paris avec toute l'equipe d'HARA",
                   "https://www.youtube.com/watch?v=ZNI5SEUtcjk"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "SPX",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "spx.jpg",
                   "1",
                   30,
                   "SPX est le leader de la découverte spatiale, viens planer la haut!",
                   "https://www.youtube.com/watch?v=-Oox2w5sMcA"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Street Soccer",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "foot2.jpg",
                   "1",
                   5,
                   "Enfile tes crampons et le but, c'est d'en mettre un.",
                   "https://www.youtube.com/watch?v=uStppdeIm5w"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "CTR",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Lyon",
                   "ctr.png",
                   "1",
                   5,
                   "Allumez vos kart, c'est le moment de se passer dessus.",
                   "https://www.youtube.com/watch?v=3Lis_oukze0"
                );
            }
        }
    }
}