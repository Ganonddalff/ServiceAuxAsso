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
                    "Slim Shady, the real Slim Shady. \nPlease, stand up.",
                    "https://www.youtube.com/watch?v=eI5qEYaa-4A"
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
                    "Concert pour collégiens.",
                    "https://www.youtube.com/watch?v=0UNycii3lSw"
                );
                _dal.CreateEvenement(
                    _dal.GetAssociation(3),
                    "Eminem 2", 
                    50,
                    new DateTime(2022, 12, 30),
                    new DateTime(2022, 12, 30),
                    "ACCORD ARENA",
                    "default-spectacle.jpg",
                    "5",
                    100,
                    "Slim Shady, the real Slim Shady. \nPlease, stand up.",
                    "https://www.youtube.com/watch?v=eI5qEYaa-4A"
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
                    "C'est un concert qu'a l'air bien.",
                    "https://www.youtube.com/watch?v=DwoIiK68e3o"
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
                    "A l'ancienne tmtc",
                    "https://www.youtube.com/watch?v=mOYZaiDZ7BM"
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
                    "ZACK IL EST TROP BEAUUUUU",
                    "https://www.youtube.com/watch?v=nKMJ9CVVabY"
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
                    "Dans ton fion",
                    "https://www.youtube.com/watch?v=KoSxEtNmO9I"
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
                    "Ca s'écoute sans se manger",
                    "https://www.youtube.com/watch?v=t_6xShx9Mxo"
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
                    "Le nouvel album, en concert",
                    "https://www.youtube.com/watch?v=ssYNyKth0bI"
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
                   "Ca veut dire couché de soleil",
                   "https://www.youtube.com/watch?v=SCmERpC4lPo"
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
                   "Il y a un monstre dans le garage",
                   "https://www.youtube.com/watch?v=qCyr-fGibVI"
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
                   "Mieux que le salon de l'auto",
                   "https://www.youtube.com/watch?v=SbXIj2T-_uk"
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
                   "Orchestre basé sur le célèbre film",
                   "https://www.youtube.com/watch?v=MPphWCr4ba8"
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
                   "Yin & Yang ? Nan. Yin & Ytwo, pour vous servir.",
                   "https://www.youtube.com/watch?v=yxgzfl1yctU"
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
                   "Poivré & salé à la fois. Gare aux éternuments.",
                   "https://www.youtube.com/watch?v=MxJzWGbG8vo"
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
                   "Retour sur l'histoire de la célèbre de revue qui a indigné la bourgeoisie dans les années 80",
                   "https://www.youtube.com/watch?v=ZNI5SEUtcjk"
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
                   "Serj Tankian performing at Red Bull Sound Space At KROQ 2012",
                   "https://www.youtube.com/watch?v=OeBcnoOIfyQ"
                );
                _dal.CreateEvenement(
                   _dal.GetAssociation(2),
                   "Zelensky's speech",
                   200,
                   new DateTime(2022, 04, 02),
                   new DateTime(2022, 04, 03),
                   "Paris",
                   "default-spectacle.jpg",
                   "1",
                   5,
                   "Volodymyr Zelensky, the president of Ukraine, is addressing British politicians in the House of Commons via video link as his country continues to battle the Russian invasion.",
                   "https://www.youtube.com/watch?v=JAdUXFoLJYQ"
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
                   "Lorie chante son album sur scène pour la croix rouge.",
                   "https://www.youtube.com/watch?v=kL3hBiiLuAk"
                );
            }
        }
    }
}