namespace AssoFlex.Models
{
    public class DefaultAssociations
    {
        public static void InitializeAssocations()
        {
            using (IDal _dal = new Dal())
            {
                _dal.CreateAssociation(
                    "AGP",
                    "111111-111",
                    2,
                    "default-logo.png",
                    "13",
                    "Association des Gabonais de Poitiers");
                _dal.CreateAssociation(
                    "ASTEC",
                    "222222-222",
                    3,
                    "default-logo.png",
                    "5",
                    "L'Association pour la Science et la " +
                    "Transmission de l'Esprit Critique a pour principal" +
                    " projet la chaîne YouTube la Tronche en Biais."
                    );
                _dal.CreateAssociation(
                    "Tête en l'air",
                    "333333-333",
                    4,
                    "default-logo.png",
                    "2",
                    "Depuis 2006, nous avons pour objectif de faire partager à un large public notre passion. " +
                    "A ce titre, nos membres se déplacent avec leur matériel dans les écoles, centres de loisirs, associations," +
                    " soirées privées etc."
                    );
                _dal.CreateAssociation(
                    "Fage",
                    "111111-111",
                    5,
                    "FAGE_logo.jpg",
                    "9",
                    "Fondée en 1989, elle asseoit son fonctionnement sur la démocratie participative et regroupe" +
                    " près de 2000 associations et syndicats, soit environ 300 000 étudiants. " +
                    "La FAGE a pour but de garantir l\'égalité des chances de réussite dans le système éducatif. " +
                    "C\'est pourquoi elle agit pour l\'amélioration constante des conditions de vie et d\'études des" +
                    " jeunes en déployant des activités dans le champ de la représentation et de la défense des droits. " +
                    "En gérant des services et des œuvres répondant aux besoins sociaux, elle est également actrice" +
                    " de l'innovation sociale." 
                );
                _dal.CreateAssociation(
                    "Energie Jeunes",
                    "111111-111",
                    6,
                    "logo_energieJeunes.jpg",
                   "13",
                    "association Energie Jeunes agit au service de la réussite scolaire de tous. Elle est reconnue " +
                   "d’Utilité Publique et agréée par le Ministère de l’Education Nationale. En étroite collaboration avec " +
                   "les enseignants et les personnels de direction des établissements scolaires " +
                    "elle offre aux collégiens l’opportunité d’apprendre à aimer apprendre.  " 
                );
                _dal.CreateAssociation(
                    "Vacances et familles",
                    "111111-111",
                    7,
                    "logo_vacances_familles.jpg",
                    "3",
                    "Elle enracine ses convictions dans la lutte contre les ex­clusions, parmi lesquelles" +
                    " la mise à l’écart des vacances d’une grande partie de la population. " +
                    "Le projet de Vacances & Familles a été particulièrement renforcé lors de l’adoption de la loi du 29" +
                    " juil­let 1998, relative à la lutte contre les exclusions, faisant de l’accès de tous aux vacances" +
                    " un objectif national. Vacances & Familles puise sa force dans sa vie associative intense, démocratique" +
                    " et laïque. " +
                    "Sans distinction d’âge, d’opinion politique ou religieuse, d’origine sociale, Vacances & Familles " +
                    "regroupe 1 500 bénévoles disponibles et impliqués, tous mobilisés pour permettre aux familles de" +
                    " réus­sir leur projet vacances. La mixité sociale est une réalité qui se décline au cœur même de" +
                    " l’association par la diversité des bénévoles et par la rencontre interculturelle entre familles" +
                    " vacancières et bénévoles. " 
                );
                _dal.CreateAssociation(
                    "LPO",
                    "111111-111",
                    8,
                    "logo_lpo.jpg",
                    "4",
                    "La LPO a été créée en 1912 pour mettre un terme au massacre du macareux moine en Bretagne, " +
                    "oiseau marin devenu son symbole.  LPO met en œuvre des plans nationaux de restauration d’oiseaux parmi" +
                    " les plus menacés de France, coordonne des programmes européens de sauvegarde d’espèces et gère la" +
                    " réintroduction d’oiseaux menacés. Elle participe à de grandes enquêtes nationales et internationales" +
                    " et propose à l’État, aux collectivités régionales et locales, son expertise sur le patrimoine naturel," +
                    " et concourt ainsi à la protection d’espèces et d’habitats menacés. "
                );
                _dal.CreateAssociation(
                   "VMEH",
                   "222222-222",
                   3,
                   "logo_VMEH.jpg",
                   "6",
                   "Nous sommes une Fédération reconnue dans l’accompagnement des personnes isolées, hospitalisées ou en EHPAD." +
                    "otre mission est double : • assurer présence et écoute auprès des personnes hospitalisées ou en résidences médicalisées ;" +
                    "• soutenir l’action des personnels soignants et associés et des institutions." +
                   "Transmission de l'Esprit Critique a pour principal projet la chaîne YouTube la Tronche en Biais."
                );
                _dal.CreateAssociation(
                   "CCFD",
                   "222222-222",
                   2,
                   "logo_CCFD.jpg",
                   "3",
                   "Acteur historique du changement dans plus de 70 pays, le CCFD-Terre Solidaire agit contre" +
                   " toutes les formes d’injustices. Nous œuvrons pour que chacun voie ses droits fondamentaux respectés :" +
                   " manger à sa faim, vivre de son travail, habiter dans un environnement sain, choisir là où construire sa vie… " 
                );
                _dal.CreateAssociation(
                   "Secours populaire français ",
                   "222222-222",
                   1,
                   "logo_secours_pop.jpg",
                   "1",
                   "Créé en 1945, le Secours populaire français est une association à but non lucratif" +
                   " et reconnue d’utilité publique. Il met au centre de son action l’humain, sans distinction sociale," +
                   " politique ou religieuse. Il refuse l’assistanat et privilégie l’écoute et l’accompagnement des personnes" +
                   " en difficulté dans le respect de leur dignité. Il invite chacun (donateurs, bénévoles, personnes aidées)" +
                   " à participer activement à ce grand mouvement de solidarité." 
                );
                _dal.CreateAssociation(
                   "La Fédération Française des Diabétiques ",
                   "222222-222",
                   1,
                   "logo_FFD.jpg",
                   "6",
                   "La Fédération Française des Diabétiques est une association de patients, au service des" +
                   " patients et dirigée par des patients." +
                    "Avec son réseau d’une centaine d’associations locales et de délégations, réparties sur l’ensemble" +
                   " du territoire et son siège national, elle a pour vocation de représenter les 4 millions de patients" +
                   " diabétiques." 
                );
                _dal.CreateAssociation(
                   "Outil en main",
                   "222222-222",
                   1,
                   "logo_loutil_en_main.jpg",
                   "4",
                   "L’Outil en Main est une association ayant pour but l’initiation des jeunes dès 9 ans aux" +
                   " métiers manuels et du patrimoine, par des gens de métier ou professionnels qualifiés, bénévoles," +
                   " le plus souvent à la retraite, avec de vrais outils dans de vrais ateliers. Lors de ces ateliers," +
                   " les gens de métier montrent aux jeunes les techniques artisanales et le geste juste. Une initiative" +
                   " humaine où deux générations collaborent lors d’une même activité." +
                   "Ces ateliers sont un lieu de rassemblement et d'échange entre jeunes et seniors, aussi bien en milieu" +
                   " rural qu'en milieu urbain.Il a pour but la revalorisation de tous les métiers manuels artisanaux," +
                   " métiers du bâtiment, métiers du patrimoine, métiers de bouche ou métiers liés à l’environnement. " 
                );
                _dal.CreateAssociation(
                   "Action contre la faim",
                   "222222-222",
                   1,
                   "logo_action_contre_la_faim.jpg",
                   "3",
                   "ACTION CONTRE LA FAIM est une organisation non gouvernementale internationale indépendante et" +
                   " organisée en réseau. Elle conduit des actions humanitaires et d’aide au développement." +
                   "ACTION CONTRE LA FAIM applique et promeut les valeurs du Droit International Humanitaire: humanité," +
                   " indépendance, neutralité, non - discrimination, accès libre des victimes à l'aide, transparence" +
                   " et professionnalisme. " 
                );
                _dal.CreateAssociation(
                   "Eeudf",
                   "222222-222",
                   2,
                   "logo_eeudf.jpg",
                   "13",
                   "Depuis plus de 100 ans, Les Éclaireuses et Éclaireurs Unionistes de France (EEUdF) favorise la" +
                   " relation entre l’enfant et la nature, la vie d’équipe, la solidarité et la fraternité. Mouvement" +
                   " protestant de scoutisme ouvert à toutes et tous, nous proposons une méthode d’éducation complémentaire" +
                   " à la famille et à l’école ; visant à un épanouissement complet de la personnalité de chacun par" +
                   " l’apprentissage de la débrouillardise, de l’autonomie et de la solidarité." +
                    "L’association forme des jeunes à devenir acteurs de la société.En plus de son projet scout," +
                   " elle crée des commissions et des groupes de travail thématiques pour aller plus loin dans sa" +
                   " réflexion et dans les activités qu’elle propose aux enfants.Il s’agit de mener un travail sur les" +
                   " grands enjeux de la société actuelle que sont l’environnement, la paix, le vivre - ensemble ou encore" +
                   " l’égalité Homme - Femme. " 
                );
                _dal.CreateAssociation(
                     "Ordre de Malte de France",
                     "222222-222",
                     3,
                     "logo_lordre_de_malte.jpg",
                     "1",
                     " C'est une association reconnue d’utilité publique, fondée en 1927. Ses milliers de salariés" +
                     " et de bénévoles s’engagent chaque jour en France et dans 27 pays pour secourir, soigner et accompagner" +
                     " les personnes fragilisées par la maladie, le handicap, la pauvreté ou l’exclusion." 
                );
                _dal.CreateAssociation(
                    "Maisons paysannes de France ",
                    "222222-222",
                    1,
                    "logo_maisons_paysannes.jpg",
                    "10",
                    "Maisons Paysannes de France, une expérience unique de 50 ans pour la connaissance et la" +
                    " sauvegarde du patrimoine rural bâti et paysager. Sur le terrain, notre association nationale," +
                    " reconnue d'utilité publique, aide les particuliers et les collectivités locales dans leurs projets" +
                    " en faveur du patrimoine rural." 
                );
                _dal.CreateAssociation(
                     "APR",
                     "222222-222",
                     2,
                     "default-logo.png",
                     "1",
                     "Etudier et mettre en œuvre toutes les mesures et encourager toutes les initiatives propres à " +
                     "réduire la fréquence et la gravité des accidents de la circulation routière" +
                     "Créée en 1949 et reconnue d’utilité publique en 1955, l’association Prévention Routière conduit ses" +
                     " actions dans de multiples domaines: éducation routière des enfants et adolescents, sensibilisation et" +
                     " information du grand public et formation continue des conducteurs(infractionnistes, salariés des " +
                     "entreprises, seniors). Elle intervient régulièrement auprès des pouvoirs publics pour faire des" +
                     " propositions visant à améliorer la sécurité routière." 
                );
                _dal.CreateAssociation(
                    "SNSM",
                    "222222-222",
                    2,
                    "logo_snsm.jpg",
                    "8",
                    "Notre façon de vivre la mer évolue constamment : accroissement du nombre de plaisanciers," +
                    " diversification des loisirs nautiques, nouvelles pratiques à risques, judiciarisation de la société…" +
                    " Ces évolutions ont été à l’origine des plans de modernisation Cap 2010 et Cap 2010+, mis en œuvre de" +
                    " façon volontariste par les équipes bénévoles et salariées de la SNSM à partir de 2008." +
                    "Ces plans de développement ambitieux concernent la modernisation des équipements individuels" +
                    " de sécurité et des équipements de sauvetage, la mise en œuvre d’une politique nationale de formation" +
                    " des sauveteurs, la prévention auprès du grand public et la réorganisation des fonctions de soutien au" +
                    " sein de l’association " 
                );
                _dal.CreateAssociation(
                    "Emmaus",
                    "222222-222",
                    2,
                    "logo_emmaus.jpg",
                    "3",
                    "Emmaüs est né il y a 66 ans pour trouver, avec les personnes victimes de phénomènes" +
                    " d’exclusion, les solutions qui leur permettent de redevenir acteur de leur vie. Fidèle à la volonté" +
                    " de l’abbé Pierre, Emmaüs est devenu à la fois une fabrique d’innovations sociales et de solidarités" +
                    " pour aider des publics en situation de grande précarité, et un front engagé et militant en faveur" +
                    " d’une société plus humaine et plus juste."
                );
                _dal.CreateAssociation(
                    "APCLD",
                    "222222-222",
                    2,
                    "logo_apcld.jpg",
                    "6",
                    "Grâce à son réseau de bénévoles organisé en équipe régionale, l’association propose à la fois" +
                    " une aide personnalisée et une démarche collective. L’association propose de nombreuses prestations et" +
                    " intervient aussi dans le domaine de la promotion de la santé notamment par ses campagnes nationales d’informations." 
                );
                _dal.CreateAssociation(
                    "ADMR",
                    "222222-222",
                    3,
                    "logo_admr.jpg",
                    "6",
                    "L'ADMR, c'est 2 950 associations sur l'ensemble du territoire, regroupant 105 000 bénévoles " +
                    "et près de 100 000 salariés, qui agissent chaque jour conjointement pour apporter un service à domicile " +
                    "sur mesure à plus de 723 400 clients. L'ADMR est la référence du service à la personne depuis " +
                    "plus de 70 ans. Le réseau ADMR propose une offre globale de services pour tous, qui se décline " +
                    "en quatre domaines: Autonomie, Domicile, Famille, Santé. " 
                );
            }
        }
    }
}