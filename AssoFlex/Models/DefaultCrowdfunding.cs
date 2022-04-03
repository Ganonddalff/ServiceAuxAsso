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
                    "WICLUB Agritech",
                    10000,
                    "Balma (31)",
                    "1", 
                    new DateTime(2022, 04, 22),
                    new DateTime(2023, 04, 21),
                    _dal.GetAssociation(1), 
                    _dal.CreateCollecte(),
                    "Agritech.jpg",
                    "La France doit bâtir une agriculture plus forte et plus souveraine. Cela passera inévitablement par l'intégration renforcée des technologies et des innovations ainsi que par un accompagnement des pépites de l'Agri/Agro. Face aux enjeux socio-économiques et environnementaux, l'innovation répond aux enjeux contemporains. En faisant de l'innovation une priorité dans le monde agricole, nous nous engageons pour une agriculture plus durable, résiliente et compétitive." +
"Le Pôle de compétitivité Agri Sud - Ouest Innovation contribue activement à faire émerger des solutions performantes et compétitives dans les domaines d’activité agri / agro, en soutenant les initiatives de porteurs de projets mais aussi en repérant les futurs besoins et marchés. "
                );
                _dal.CreateCrowdfunding(
                    "EverWatt",
                    30000,
                    "Paris", 
                    "2",
                    new DateTime(2022, 06, 27),
                    new DateTime(2023, 05, 30),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "everwatt.jpg",
                    "EverWatt est une participation de Transition Evergreen, le premier fonds d'investissement coté en France (EURONEXT Paris - Compartiment C) dédié à la transition écologique et à la réduction de l'empreinte carbone."+

                     "EverWatt, est un acteur intégré spécialisé dans l'aménagement énergétique et la décarbonation des Territoires. Grâce aux sociétés qu'elle détient, EverWatt agit à l'échelle des Territoires autour de 3 axes stratégiques :"+
"Une production énergétique plus propre ;"+
                "La baisse des consommations d'énergie ;"+
"L'absorption et la compensation des émissions de carbone résiduel."
                );
                _dal.CreateCrowdfunding(
                    "WICLUB ECONOMIE BLEUE",
                    80000,
                    "Balma (31)",
                    "3",
                    new DateTime(2022, 09, 22),
                    new DateTime(2023, 05, 01),
                    _dal.GetAssociation(2),
                    _dal.CreateCollecte(),
                    "wiclubeco.jpg",
                    "Pôles de compétitivité dédiés à l’économie de la mer, les Pôles Mer Bretagne Atlantique et Méditerranée ont été créés en 2005 dans le cadre de la politique industrielle de la France visant à promouvoir l’innovation en développant les relations entre entreprises et laboratoires de recherche."+

"Ils ont pour ambition de développer durablement l'économie maritime et littorale sur l’ensemble des façades maritimes françaises, et à l’international. "
                );
                _dal.CreateCrowdfunding(
                    "Enerpro Biogaz",
                    450000,
                    "Rennes (35)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "enerpro.png",
                    "Depuis 2016 Enerpro Biogaz met au point des systèmes de méthanisation à petite échelle qui traitent et valorisent les déchets organiques des fermes d’élevage (fumiers, lisiers) et des industries agroalimentaires (résidus de production, eaux usées, et biodéchets) en toute indépendance."+

"Avec près de 10 installations à notre actif, nos efforts en R & D ont permis de concevoir des unités compactes qui valorisent l’énergie produite(chaleur, électricité… et bientôt carburant) en autoconsommation ou en revente."+

"Nous proposons des unités de méthanisation miniaturisées, financièrement accessibles et opérables directement par l’exploitant."
                );
                _dal.CreateCrowdfunding(
                    "NEOLINE DÉVELOPPEMENT",
                    450000,
                    "Nantes (44)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "neoline.png",
                    "Dans un monde où la transition énergétique et écologique devient un facteur déterminant, NEOLINE a pour vision de proposer un transport maritime qui allie pertinence opérationnelle avec sobriété énergétique pour tendre vers un transport zéro émission."+

"La mission de NEOLINE est de développer des solutions de transport maritime à propulsion principale vélique qui sont propres, sur mesure et compétitives, conçues pour répondre aux besoins logistiques des chargeurs."+

"NEOLINE a vocation, avec ses partenaires, à constituer une réponse française innovante à un défi environnemental universel tout en restant dans un cadre industriel et compétitif."
                );
                _dal.CreateCrowdfunding(
                    "Cyclik",
                    450000,
                    "Lyon (69)",
                    "2",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "cyclik.jpg",
                    "Chez Cyclik, nous fabriquons depuis 2016 des vélos en bambou haut de gamme et sur-mesure à Lyon et nous lançons la marque Relief avec la vocation de démocratiser l’usage du végétal dans les modes de transports doux."+

                     "Utiliser des matières végétales et à faible impact environnemental et exploiter les propriétés mécaniques du bambou et du lin pour apporter du confort."+
                     "Relocaliser la fabrication des vélos: de la fabrication des cadres au montage des périphériques et travailler avec le tissu industriel national."+
                      "Apporter le beau et le singulier dans le marché du Vélo à Assistance Électrique(VAE)"+
                       "Voilà les 3 missions que relève Relief: le premier vélo électrique de série en bambou et lin, réellement made in France."
                );
                _dal.CreateCrowdfunding(
                    "FRANCE VALLEY REVENU EUROPE",
                    450000,
                    "Paris (75)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "francevalley.jpg",
                    "France Valley Revenu Europe est le premier fonds européen en investissement forestier. Structuré sous forme de société anonyme, son objet est l'acquisition et la gestion d'actifs forestiers sur le territoire européen."+
                    "Investir dans cette entreprise permet d'accéder à cette classe d'actifs méconnue mais très innovante, décorrélée des marchés financiers et immobiliers."+
                    "Cette nouvelle offre a toute sa place dans une stratégie de diversification patrimoniale."+
                    "Investissez dans France Valley Revenu Europe 6 pour allier performance sociétale et économique, avec un objectif de rendement de 2.5 %/ an, autour d'un sous-jacent unique : les actifs forestiers."
                );
                _dal.CreateCrowdfunding(
                    "Meyerbeer",
                    450000,
                    "Nice (06)",
                    "1",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "meyerbeer.jpg",
                    "Le projet MEYERBEER NICE consiste en l'acquisition d'un immeuble de rapport en R+3 composé de 39 lots dont 21 lots à usage d'habitation, pour une revente en bloc."+
                    "A ce jour, l'immeuble est déjà sous offre ferme avec un promoteur d'envergure européenne côté en bourse, qui souhaite l'acheter en l'état pour effectuer des travaux de revalorisation."+
                    "Aucun travaux n'est donc à prévoir dans le cadre de cette opération de marchand de biens."+
                    "Une déclaration préalable sera déposée en avril 2022.Elle permettrait notamment au futur acquéreur de convertir les parkings présents sur tout le RDC, en habitation."
                );
                _dal.CreateCrowdfunding(
                    "Saint Agnes",
                    450000,
                    "Menton (06)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "Saintagnes.jpg",
                    "Le projet SAINTE-AGNES est un refinancement d'une opération de marchand de biens réalisée à Menton dans le quartier Haut Borrigo, dans le département des Alpes-Maritimes (06)."+
                    "Elle consiste à acquérir une maison à usage d'habitation (lot B) pour la revendre, sans réalisation de travaux et de procéder à une division parcellaire afin d'en revendre le terrain à bâtir(lot A) une fois le permis de construire obtenu et purgé."+
                    "Pour cette opération, un permis d'aménager a d'abord était obtenu et purgé en mai 2021."
                );
                _dal.CreateCrowdfunding(
                    "Cabris",
                    450000,
                    "Cabris (06)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "cabris.png",
                    "Opération de marchand de biens située à CABRIS, dans le département des Alpes-Maritimes (06), en région Provence-Alpes-Côte d'Azur."+
                    "Le projet CABRIS consiste à financer l'acquisition d’un terrain comprenant une maison principale en R+3 d’habitation et un bâtiment indépendant avec piscine en arrière de la parcelle."+
                    "Terrain à l'origine d'un seul tenant, il est prévu une division parcellaire en 3 terrains ainsi qu'une division de la maison principale en 2 lots."+
                    "La maison principale située sur le terrain B sera divisée en 2 appartements dont chacun bénéficiera de son accès privatif, tandis que le bâtiment indépendant est situé sur le terrain A et sera revendu avec sa parcelle sans modification."+
                    "Le projet est situé sur une parcelle cadastrale d'une superficie de 4 979 m², dont l'acquisition sera réalisée en avril 2022."
                );
                _dal.CreateCrowdfunding(
                    "Immo 2 club",
                    450000,
                    "Toulouse (31)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "clubimmo2.jpg",
                    "Forts de notre expérience en financement d'opérations de crowdfunding immobilier (près de 750 projets financés pour plus de 335 M€) et suite au premier WiCLUB lancé en fin d'année 2020, place au WiCLUB Immobilier 2, avec une proposition de valeur optimisée (pas de frais de souscription, moins de frais de gestion, plus de carried interest) !"+
                    "Il s’agit d’un club d’investissement participatif, syndiqué et collectif réunissant dans un véhicule financier ad - hoc des WiSEEDers souhaitant investir dans plusieurs projets immobiliers d’envergure et de différentes natures sur le territoire français(promotion, aménagement foncier, marchand de biens)."

                                         
                );
                _dal.CreateCrowdfunding(
                    "FONCIÈRE DES PRATICIENS",
                    450000,
                    "Nantes (44)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "scpifonciere.jpg",
                    "Foncière des Praticiens est une SCPI spécialisée dans la gestion d'actifs immobiliers de professionnels de la Santé."+
                    "Un mot d'ordre : Proposer un véhicule d’épargne à visée sociétale dans le domaine de la santé !"+
                    "Créée en 2017, pour et à l'initiative de praticiens du groupe de cliniques privées Vivalto, elle a ensuite été ouverte à l'épargne publique en 2019 avec l'obtention de l'agrément de l'Autorité des Marchés Financiers (AMF) lui permettant de faire l'appel public à l'épargne.Depuis 2020, elle propose également à ses investisseurs d'apporter une dimension philanthropique à leur investissement via la création d'un fonds de partage.Ce fonds donne la possibilité aux porteurs de parts de verser entre 10 et 30% des revenus trimestriels distribués au profit de 3 associations :"+
                    ">> la fondation Arsep qui œuvre dans la recherche et l'accompagnement de personnes atteintes de la sclérose en plaques"+
                    ">> France Tutelle qui conseille les aidants tuteurs familiaux"+
                    ">> et l'institut Vivalto Santé (engagé dans la recherche clinique, l'innovation et la formation des médecins)."+
                    "Outre la participation proposée aux investisseurs au fonds de partage, Foncière Magellan, la société de gestion gérant la SCPI Foncière des Praticiens, s'engage à reverser 20% de la commission annuelle de gestion à ces trois associations."
                );
                _dal.CreateCrowdfunding(
                    "IROKO ZEN",
                    450000,
                    "Paris 16",
                    "2",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "irokozen.jpg",
                    "Iroko Zen est une SCPI 100% digitale et sans frais de souscription. Elle acquiert des entrepôts, bureaux et commerces afin de les gérer et distribuer les loyers mensuellement sous forme de dividendes. Elle privilégie des immeubles de taille modeste et alloue les fonds de manière dynamique, anticipant les usages de demain. A la fois diversifiée, transparente et généraliste, Iroko Zen est une solution pédagogique pour investir simplement en immobilier."+
                    "Elle élabore sa propre stratégie, à ce jour majoritairement en commerces, entrepôts et locaux d'activité, sans se spécialiser dans une classe d'actifs immobiliers particulière."
                );
                _dal.CreateCrowdfunding(
                    "CAP FONCIERES ET TERRITOIRES",
                    450000,
                    "Nancy (54)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "capfonciere.png",
                    "Cap Foncières & Territoires est une SCPI de rendement à thématique territoriale qui acquiert et gère des actifs en immobilier d’entreprise, rigoureusement sélectionnés dans les métropoles dynamiques françaises."+
                    "Issue de la fusion de 3 SCPI régionales(Nord - Est Horizon, Rhône - Alpes Méditerranée et Ouest Cap Atlantique), Cap foncières & Territoires vise un rendement supérieur ou égal à 5 %/ an, et cible des actifs de taille moyenne(entre 750 000€ et 3M€) loués par des signatures de qualité."+
                    "La société de gestion Foncières & Territoires est l'expression de 25 années d'expérience dans l'investissement immobilier d'entreprise, au plus près des acteurs façonnant l'économie des régions au sein desquelles elle évolue."
                );
                _dal.CreateCrowdfunding(
                    "SCPI AEDIFICIS",
                    450000,
                    "Toulouse (31)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "midiscpii.jpg",
                    "La SCPI AEDIDIFIS : L’immobilier de demain au cœur des métropoles françaises engagée dans une démarche Socialement Responsable."+
                    "MIDI 2i a souhaité mettre à disposition du grand public ses 15 années d’expérience en gestion de fonds immobiliers régionaux (1,3 Mds d’actifs sous gestion)*. Avec sa SCPI AEDIFICIS, créée en décembre 2019, MIDI 2i vous propose une offre de placement à long terme dans l’immobilier d’entreprise : bureaux commerces locaux d’activité et logistique situés dans les métropoles françaises."
                );
                _dal.CreateCrowdfunding(
                    "SCPI ACTIVIMMO",
                    450000,
                    "Ile de France",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "activimmo.jpg",
                    "Activimmo est une SCPI innovante, la seule du marché spécialisée dans l'immobilier d'entreprise logistique."+
                    "Son positionnement sur ce segment de marché est pertinent car directement impliqué dans les enjeux de logistique du dernier kilomètre:"+
                    "Livrer plusieurs distributeurs en un seul point"+
                    "Fluidifier la distribution des marchandises"+
                    " Mieux maîtriser l'empreinte carbone de la chaine logistique"+
                    "La demande actuelle et à venir pour ce type de biens est en croissance, ce qui limite le risque d'une baisse de la valorisation de la part et impacte positivement la performance de la SCPI."
                );
                _dal.CreateCrowdfunding(
                    "Pas de secret et pas d'histoires",
                    450000,
                    "Orléans (45)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "wiclub2.jpeg",
                    "Répondant à une demande croissante de WiSEEDers souhaitant investir de manière simple, rapide et récurrente sur WiSEED, WiCLUB SANTÉ 2 vous offre l’opportunité de constituer un portefeuille diversifié tant en termes de natures de projets que de répartition des risques."+
                    "Il est prévu d'effectuer deux tranches de financement différentes :"+
                    "Une première tranche se terminant vers mai(environ 700k€ collectés) ;"+
                    " Une seconde tranche se terminant à la fin de l'année."
                );
                _dal.CreateCrowdfunding(
                    "Moviescar",
                    450000,
                    "Marseille",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "taxi406.jpg",
                    "Durant le premier confinement, nous vous avions dressé une petite liste non-exhaustive des voitures de cinéma les plus mythiques. Mais savez-vous que vous pouvez les voir en vrai ? Dans la vraie vie, en dehors des salles obscures et de votre salon ! Franck Galiègue, créateur de Movie Cars Central, en réunit actuellement un bon paquet en région Parisienne, et les expose au public tous les week-ends jusqu’à fin Juillet."
                );
                _dal.CreateCrowdfunding(
                    "Latice Medical",
                    450000,
                    "Loos (59)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "laticemed.jpg",
                    "LATTICE MEDICAL créée fin 2017 valorise plusieurs années de recherche du CHU et de l'Université de Lille dans l'ingénierie tissulaire pour la régénération de tissus autologues adipeux. L'entreprise exploite une technologie brevetée et étendue à l'international, avec une première application dans la reconstruction mammaire."+
                    "LATTICE MEDICAL souhaite révolutionner la reconstruction mammaire avec son implant MATTISSE permettant une reconstruction autologue pour toutes les patientes et devenir leader du marché de la réparation des tissus mous humains.Notre ambition est de remplacer les implants silicones et d'aider 40 000 femmes d'ici 2030 à avoir une reconstruction mammaire plus simple et sans risques."
                );
                _dal.CreateCrowdfunding(
                    "EKKOPOL",
                    450000,
                    "Ponteves (83)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "ekkopoll.png",
                    "EKKOPOL lutte contre toutes les formes de pollutions marines du littoral : les déchets plastiques et les hydrocarbures."
                );
                _dal.CreateCrowdfunding(
                    "Rhizosfer",
                    450000,
                    "(08)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(1),
                    _dal.CreateCollecte(),
                    "rhizo.png",
                    "Rhizosfer développe un procédé vert innovant de production de plants de miscanthus de qualité."+
                    "Cultivée significativement en Europe depuis la fin des années 90, plus de 800 hectares de miscanthus sont plantés tous les ans en France.Historiquement, cette plante est multipliée par division de ses racines, mais les modifications du climat observées depuis les 5 dernières années, entraînent une production de racines de moindre de qualité et de quantité très aléatoire."+
                    "Rhizosfer développe un nouveau procédé de production de plants de miscanthus, transformant une production manuelle en plein champ en une production automatisée, sécurisée face aux changements climatiques, en serre."
                );
                _dal.CreateCrowdfunding(
                    "KEETIZ",
                    450000,
                    "Montpellier (34)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "keetiz.png",
                    "Keetiz est une application qui récompense l'acte d'achat en contribuant à rembourser une partie de nos dépenses dans les commerces partenaires référencés"+
                    "KEETIZ, le récap' en 2 minutes !"+
                    "C'est par ici : https://www.keetiz.fr/reportagetf1_0820 "+
                    "NOTRE MISSION"+

                    "Recréer du lien entre les commerçants et leurs clients en utilisant la stratégie de la récompense afin de renforcer le maintien et la croissance des commerces de proximité sur nos territoires."+
                    "En invitant à consommer différemment 50 millions de consommateurs grâce à la stratégie de la récompense."+
                    "En redonnant le pouvoir aux commerçants grâce à la data hyper qualifiée."+
                    "En aidant les collectivités et les grandes entreprises à revitaliser et redynamiser leurs commerces."
                );
                _dal.CreateCrowdfunding(
                    "NEOCEAN",
                    450000,
                    "Montpellier (34)",
                    "3",
                    new DateTime(2022, 12, 24),
                    new DateTime(2023, 11, 21),
                    _dal.GetAssociation(3),
                    _dal.CreateCollecte(),
                    "neocean.jpg",
                    "Neocean : We change water mobility, now !"+
                    "Océanographe de formation, j'étais spécialisé dans la protection des récifs coralliens. J'ai ainsi navigué en bateau à moteur dans de nombreux lagons pour y travailler et j'ai toujours été frustré de voir que lorsque nous naviguions sur les eaux transparentes, les poissons de toutes tailles s'enfuyaient sous l'étrave, effrayés par le bruit et la perturbation de nos hors-bord à la surface. La nécessité de trouver une solution pour naviguer proprement en bateau à moteur en zone côtière était une nécessité, mais les solutions techniques étaient alors peu opérationnelles. C’est en 2013 que les premiers grands catamarans de l'America's Cup avec des foils en T apparurent. Au même moment les voitures 100% électriques commençaient à faire parler d'elle. L'idée de coupler foils en T et propulsion électrique a alors jailli comme solution à la navigation propre et...5 ans plus tard l'Overboat été né - Vincent Dufour, fondateur de Neocean"
                );
            }
        }
    }
}