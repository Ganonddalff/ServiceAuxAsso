using System;

namespace AssoFlex.Models
{
    public class DefaultCrowdfunding
    {
        public static void InitializeCrowdfunding()
        {
            using (IDal _dal = new Dal())
            {
                _dal.CreateCrowdfunding(
                    "Jackson",
                    10000,
                    "Montreuil",
                    "1", 
                    new DateTime(2022, 04, 22),
                    new DateTime(2023, 04, 21),
                    _dal.GetAssociation(1), 
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    "Pour jackson svp"
                );
                _dal.CreateCrowdfunding(
                    "Jefferson",
                    30000,
                    "Dallas", 
                    "2",
                    new DateTime(2022, 06, 27),
                    new DateTime(2023, 05, 30),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    "Pour Jefferson svp"
                );
                _dal.CreateCrowdfunding(
                    "Nguyen",
                    80000,
                    "Vietnam",
                    "3",
                    new DateTime(2022, 09, 22),
                    new DateTime(2023, 05, 01),
                    _dal.GetAssociation(2),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    "Pour Nguyen svp"
                );
                _dal.CreateCrowdfunding(
                    "Benjamin",
                    450000,
                    "Montpellier",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    "Pour Benjamin svp"
                );
                _dal.CreateCrowdfunding(
                    "LesdemonsdelaTR",
                    450000,
                    "Montpellier",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Plus vite que jamais",
                    450000,
                    "Marseille",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "LinkedinLink",
                    450000,
                    "Metropolis",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "seizsoupapes",
                    450000,
                    "Viry chatillon",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Departpour100",
                    450000,
                    "Montluçon",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "ChangeMyride",
                    450000,
                    "Houston",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "EmptyUrMind",
                    450000,
                    "Hong Kong",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Fountain KENtEK",
                    450000,
                    "Dubaï",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Les bails sont doux",
                    450000,
                    "Dubaï",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "JAVA au puits thon",
                    450000,
                    "Paris",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Trois frères",
                    450000,
                    "Paris",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Etoiles AC",
                    450000,
                    "Montpellier",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Pas de secret et pas d'histoires",
                    450000,
                    "Aix en provence",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Trop de polémiques",
                    450000,
                    "Toulouse",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Triple F",
                    450000,
                    "Guyane",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Izerdanlevaisso",
                    450000,
                    "Ottawa",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Rasso Sud",
                    450000,
                    "Montpellier",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Pleins Nord",
                    450000,
                    "Melun",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
                _dal.CreateCrowdfunding(
                    "Momertuis",
                    450000,
                    "Evry",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "crowdfunding.jpg",
                    ""
                );
            }
        }
    }
}