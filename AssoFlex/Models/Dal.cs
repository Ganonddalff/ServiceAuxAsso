using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AssoFlex.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace AssoFlex.Models
{
    public class Dal : IDal
    {
        private const string AbsolutePath =
            "wwwroot/assets/";
        //private const string DefaultAvatar = "../wwwroot/assets/img/avatar.jpeg";
        private AssoFlexContext _assoFlex;

        public Dal()
        {
            this._assoFlex = new AssoFlexContext();
        }
        
        public void Dispose()
        {
           this._assoFlex.Dispose();
        }

        public byte[] ImageToByteArray(string pathImage) //Image image
        {
            return System.IO.File.ReadAllBytes(pathImage);
        }

        #region Initialisation
        public void InitializeDb()
        {
            this._assoFlex.Database.EnsureDeleted();
            this._assoFlex.Database.EnsureCreated();

            //------------- UTILISATEURS -------------//
            this.CreateUtilisateur(
                "Guytri",
                "Kastane",
                "31 rue de l'aurore",
                0755172316,
                "gkastane@gmail.com",
                EncodeMD5("11111"),
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin"
            );
            this.CreateUtilisateur(
                "Mateusz",
                "Tirel",
                "19, rue des petites murailles",
                0667127014,
                "admin",
                EncodeMD5("admin"),
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin"
            );
            this.CreateUtilisateur(
                "Billal",
                "Benziane",
                "32 rue de l'aurore",
                0755172317,
                "billal.benziane1@gmail.com",
                EncodeMD5("11111"), 
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin"
            );
            this.CreateUtilisateur(
                "Paul",
                "Jean",
                "78 rue de l'aurore",
                0755172320,
                "pjean@gmail.com",
                EncodeMD5("22222"), 
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
            );
            this.CreateUtilisateur(
                "Jean",
                "Jacques",
                "",
                0755172324,
                "jjacques@gmail.com", 
                EncodeMD5("33333"), 
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
            );
            this.CreateUtilisateur(
                "Jessica",
                "Alba", 
                "",
                0755172328,
                "jalba@gmail.com",
                EncodeMD5("44444"), 
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
            );
            this.CreateUtilisateur(
                "Louis",
                "David",
                "",
                0755172332,
                "ldavid@gmail.com",
                EncodeMD5("55555"),
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg"
            );
            this.CreateUtilisateur(
                "Alban",
                "Ivanoff",
                "",
                0755172338,
                "aivanoff@gmail.com",
                EncodeMD5("66666"),
                "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg"
            );
            
            //------------- ASSOCIATIONS -------------//
            this.CreateAssociation(
                "AGP",
                "111111-111",
                2,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Association des Gabonais de Poitiers"
            );
            this.CreateAssociation(
                "ASTEC",
                "222222-222",
                3,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "L'Association pour la Science et la " +
                "Transmission de l'Esprit Critique a pour principal" +
                " projet la chaîne YouTube la Tronche en Biais."
            );
            this.CreateAssociation(
                "Tête en l'air",
                "333333-333",
                4,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Depuis 2006, nous avons pour objectif de faire partager à un large public notre passion. " +
                "A ce titre, nos membres se déplacent avec leur matériel dans les écoles, centres de loisirs, associations," +
                " soirées privées etc."
            );
            this.CreateAssociation(
                "Fage",
                "111111-111",
                5,
                ImageToByteArray(AbsolutePath + "logos/FAGE_logo.jpg"),
                "Fondée en 1989, elle asseoit son fonctionnement sur la démocratie participative et regroupe" +
                " près de 2000 associations et syndicats, soit environ 300 000 étudiants. " +
                "La FAGE a pour but de garantir l\'égalité des chances de réussite dans le système éducatif. " +
                "C\'est pourquoi elle agit pour l\'amélioration constante des conditions de vie et d\'études des" +
                " jeunes en déployant des activités dans le champ de la représentation et de la défense des droits. " +
                "En gérant des services et des œuvres répondant aux besoins sociaux, elle est également actrice" +
                " de l'innovation sociale." 
            );
            this.CreateAssociation(
                "Energie Jeunes",
                "111111-111",
                6,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "association Energie Jeunes agit au service de la réussite scolaire de tous. Elle est reconnue " +
               "d’Utilité Publique et agréée par le Ministère de l’Education Nationale. En étroite collaboration avec " +
               "les enseignants et les personnels de direction des établissements scolaires " +
                "elle offre aux collégiens l’opportunité d’apprendre à aimer apprendre.  " 
            );
            this.CreateAssociation(
                "Vacances et familles",
                "111111-111",
                7,
                ImageToByteArray(AbsolutePath + "logos/logo_vacances_familles.jpg"),
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
            this.CreateAssociation(
                "LPO",
                "111111-111",
                8,
                ImageToByteArray(AbsolutePath + "logos/logo_lpo.jpg"),
                "La LPO a été créée en 1912 pour mettre un terme au massacre du macareux moine en Bretagne, " +
                "oiseau marin devenu son symbole.  LPO met en œuvre des plans nationaux de restauration d’oiseaux parmi" +
                " les plus menacés de France, coordonne des programmes européens de sauvegarde d’espèces et gère la" +
                " réintroduction d’oiseaux menacés. Elle participe à de grandes enquêtes nationales et internationales" +
                " et propose à l’État, aux collectivités régionales et locales, son expertise sur le patrimoine naturel," +
                " et concourt ainsi à la protection d’espèces et d’habitats menacés. "
            );
            this.CreateAssociation(
               "VMEH",
               "222222-222",
               3,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "Nous sommes une Fédération reconnue dans l’accompagnement des personnes isolées, hospitalisées ou en EHPAD." +
                "otre mission est double : • assurer présence et écoute auprès des personnes hospitalisées ou en résidences médicalisées ;" +
                "• soutenir l’action des personnels soignants et associés et des institutions." +
               "Transmission de l'Esprit Critique a pour principal projet la chaîne YouTube la Tronche en Biais."
            );
            this.CreateAssociation(
               "CCFD",
               "222222-222",
               2,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "Acteur historique du changement dans plus de 70 pays, le CCFD-Terre Solidaire agit contre" +
               " toutes les formes d’injustices. Nous œuvrons pour que chacun voie ses droits fondamentaux respectés :" +
               " manger à sa faim, vivre de son travail, habiter dans un environnement sain, choisir là où construire sa vie… " 
            );
            this.CreateAssociation(
               "Secours populaire français ",
               "222222-222",
               1,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "Créé en 1945, le Secours populaire français est une association à but non lucratif" +
               " et reconnue d’utilité publique. Il met au centre de son action l’humain, sans distinction sociale," +
               " politique ou religieuse. Il refuse l’assistanat et privilégie l’écoute et l’accompagnement des personnes" +
               " en difficulté dans le respect de leur dignité. Il invite chacun (donateurs, bénévoles, personnes aidées)" +
               " à participer activement à ce grand mouvement de solidarité." 
            );
            this.CreateAssociation(
               "La Fédération Française des Diabétiques ",
               "222222-222",
               1,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "La Fédération Française des Diabétiques est une association de patients, au service des" +
               " patients et dirigée par des patients." +
                "Avec son réseau d’une centaine d’associations locales et de délégations, réparties sur l’ensemble" +
               " du territoire et son siège national, elle a pour vocation de représenter les 4 millions de patients" +
               " diabétiques." 
            );
            this.CreateAssociation(
               "Outil en main",
               "222222-222",
               1,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "L’Outil en Main est une association ayant pour but l’initiation des jeunes dès 9 ans aux" +
               " métiers manuels et du patrimoine, par des gens de métier ou professionnels qualifiés, bénévoles," +
               " le plus souvent à la retraite, avec de vrais outils dans de vrais ateliers. Lors de ces ateliers," +
               " les gens de métier montrent aux jeunes les techniques artisanales et le geste juste. Une initiative" +
               " humaine où deux générations collaborent lors d’une même activité." +
               "Ces ateliers sont un lieu de rassemblement et d'échange entre jeunes et seniors, aussi bien en milieu" +
               " rural qu'en milieu urbain.Il a pour but la revalorisation de tous les métiers manuels artisanaux," +
               " métiers du bâtiment, métiers du patrimoine, métiers de bouche ou métiers liés à l’environnement. " 
            );
            this.CreateAssociation(
               "Action contre la faim",
               "222222-222",
               1,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
               "ACTION CONTRE LA FAIM est une organisation non gouvernementale internationale indépendante et" +
               " organisée en réseau. Elle conduit des actions humanitaires et d’aide au développement." +
               "ACTION CONTRE LA FAIM applique et promeut les valeurs du Droit International Humanitaire: humanité," +
               " indépendance, neutralité, non - discrimination, accès libre des victimes à l'aide, transparence" +
               " et professionnalisme. " 
            );
            this.CreateAssociation(
               "Eeudf",
               "222222-222",
               2,
               ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
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
            this.CreateAssociation(
                 "Ordre de Malte de France",
                 "222222-222",
                 3,
                 ImageToByteArray(AbsolutePath + "logos/default-logo.png"),

                 " C'est une association reconnue d’utilité publique, fondée en 1927. Ses milliers de salariés" +
                 " et de bénévoles s’engagent chaque jour en France et dans 27 pays pour secourir, soigner et accompagner" +
                 " les personnes fragilisées par la maladie, le handicap, la pauvreté ou l’exclusion." 
            );
            this.CreateAssociation(
                "Maisons paysannes de France ",
                "222222-222",
                1,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Maisons Paysannes de France, une expérience unique de 50 ans pour la connaissance et la" +
                " sauvegarde du patrimoine rural bâti et paysager. Sur le terrain, notre association nationale," +
                " reconnue d'utilité publique, aide les particuliers et les collectivités locales dans leurs projets" +
                " en faveur du patrimoine rural." 
            );
            this.CreateAssociation(
                 "APR",
                 "222222-222",
                 2,
                 ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                 "Etudier et mettre en œuvre toutes les mesures et encourager toutes les initiatives propres à " +
                 "réduire la fréquence et la gravité des accidents de la circulation routière" +
                 "Créée en 1949 et reconnue d’utilité publique en 1955, l’association Prévention Routière conduit ses" +
                 " actions dans de multiples domaines: éducation routière des enfants et adolescents, sensibilisation et" +
                 " information du grand public et formation continue des conducteurs(infractionnistes, salariés des " +
                 "entreprises, seniors). Elle intervient régulièrement auprès des pouvoirs publics pour faire des" +
                 " propositions visant à améliorer la sécurité routière." 
            );
            this.CreateAssociation(
                "ASTEC",
                "222222-222",
                1,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "L'Association pour la Science et la " +
                "Transmission de l'Esprit Critique a pour principal" +
                " projet la chaîne YouTube la Tronche en Biais."
                );
            this.CreateAssociation(
                "SNSM",
                "222222-222",
                2,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Notre façon de vivre la mer évolue constamment : accroissement du nombre de plaisanciers," +
                " diversification des loisirs nautiques, nouvelles pratiques à risques, judiciarisation de la société…" +
                " Ces évolutions ont été à l’origine des plans de modernisation Cap 2010 et Cap 2010+, mis en œuvre de" +
                " façon volontariste par les équipes bénévoles et salariées de la SNSM à partir de 2008." +
                "Ces plans de développement ambitieux concernent la modernisation des équipements individuels" +
                " de sécurité et des équipements de sauvetage, la mise en œuvre d’une politique nationale de formation" +
                " des sauveteurs, la prévention auprès du grand public et la réorganisation des fonctions de soutien au" +
                " sein de l’association " 
            );
            this.CreateAssociation(
                "Emmaus",
                "222222-222",
                2,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Emmaüs est né il y a 66 ans pour trouver, avec les personnes victimes de phénomènes" +
                " d’exclusion, les solutions qui leur permettent de redevenir acteur de leur vie. Fidèle à la volonté" +
                " de l’abbé Pierre, Emmaüs est devenu à la fois une fabrique d’innovations sociales et de solidarités" +
                " pour aider des publics en situation de grande précarité, et un front engagé et militant en faveur" +
                " d’une société plus humaine et plus juste."
            );
            this.CreateAssociation(
                "APCLD",
                "222222-222",
                2,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "Grâce à son réseau de bénévoles organisé en équipe régionale, l’association propose à la fois" +
                " une aide personnalisée et une démarche collective. L’association propose de nombreuses prestations et" +
                " intervient aussi dans le domaine de la promotion de la santé notamment par ses campagnes nationales d’informations." 
            );
            this.CreateAssociation(
                "ADMR",
                "222222-222",
                3,
                ImageToByteArray(AbsolutePath + "logos/default-logo.png"),
                "L'ADMR, c'est 2 950 associations sur l'ensemble du territoire, regroupant 105 000 bénévoles " +
                "et près de 100 000 salariés, qui agissent chaque jour conjointement pour apporter un service à domicile " +
                "sur mesure à plus de 723 400 clients. L'ADMR est la référence du service à la personne depuis " +
                "plus de 70 ans. Le réseau ADMR propose une offre globale de services pour tous, qui se décline " +
                "en quatre domaines: Autonomie, Domicile, Famille, Santé. " 
            );
            //------------- EVÈNEMENT -------------//
            this.CreateEvenement(
                this.GetAssociation(1),
                "Eminem", 
                50, 
                new DateTime(2022, 12, 30), 
                new DateTime(2022, 12, 30), 
                "ACCORD ARENA", 
                "5",
                90,
                "Slim Shady, the real Slim Shady. \nPlease, stand up."
            );
            this.CreateEvenement(
                this.GetAssociation(1),
                "PNL",
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                10,
                "Concert pour collégiens."
            );
            this.CreateEvenement(
                this.GetAssociation(3),
                "Eminem", 
                50,
                new DateTime(2022, 12, 30),
                new DateTime(2022, 12, 30),
                "ACCORD ARENA",
                "5",
                100,
                "Slim Shady, the real Slim Shady. \nPlease, stand up."
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "Concert super",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Paris",
                "1",
                5,
                "C'est un concert qu'a l'air bien."
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "Red country",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Lille",
                "1",
                5,
                ""
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "High school musical",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Paris",
                "1",
                5,
                ""
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "DTF",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Paris",
                "1",
                5,
                ""
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "FAST&FOOD",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "NY",
                "1",
                5,
                ""
            );
            this.CreateEvenement(
                this.GetAssociation(2),
                "Daggers",
                200,
                new DateTime(2022, 04, 02),
                new DateTime(2022, 04, 03),
                "Londres",
                "1",
                5,
                ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Sunset",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Garage Monster",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Movie cars",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Back to the past",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Yin & Ytwo",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "SaltPeps",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Hara kiri",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Paris Papleure",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Satantine",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            this.CreateEvenement(
               this.GetAssociation(2),
               "Con sert deux l'eau riz",
               200,
               new DateTime(2022, 04, 02),
               new DateTime(2022, 04, 03),
               "Paris",
               "1",
               5,
               ""
            );
            //------------- CROWDFUNDING -------------//
            this.CreateCrowdfunding(
                "Jackson",
                10000,
                "Montreuil",
                "1", 
                new DateTime(2022, 04, 22),
                new DateTime(2023, 04, 21),
                this.GetAssociation(1), 
                this.CreateCollecte(),
                "Pour jackson svp"
            );
            this.CreateCrowdfunding(
                "Jefferson",
                30000,
                "Dallas", 
                "2",
                new DateTime(2022, 06, 27),
                new DateTime(2023, 05, 30),
                this.GetAssociation(3),
                this.CreateCollecte(),
                "Pour Jefferson svp"
            );
            this.CreateCrowdfunding(
                "Nguyen",
                80000,
                "Vietnam",
                "3",
                new DateTime(2022, 09, 22),
                new DateTime(2023, 05, 01),
                this.GetAssociation(2),
                this.CreateCollecte(),
                "Pour Nguyen svp"
            );
            this.CreateCrowdfunding(
                "Benjamin",
                450000,
                "Montpellier",
                "Construction",
                new DateTime(2022, 12, 24),
                new DateTime(2023, 11, 21),
                this.GetAssociation(1),
                this.CreateCollecte(),
                "Pour Benjamin svp"
            );
            this.CreateCrowdfunding(
                "LesdemonsdelaTR",
                450000,
                "Montpellier",
                "Construction",
                new DateTime(2022, 12, 24),
                new DateTime(2023, 11, 21),
                this.GetAssociation(3),
                this.CreateCollecte(),
                ""
            );
            //------------- ADHESION ARTICLE -------------//
            this.CreateAdhesionArticle(
                this.GetAssociation(1),
                "1",
                0
            );
        }
        #endregion

        #region Utilisateur

        public Utilisateur GetUtilisateur(int id)
        {
            return this._assoFlex.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public Utilisateur GetUtilisateur(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.GetUtilisateur(id) : null;
        }

        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "Assoflex" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(
                new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }
        public Utilisateur Authentifier(string email, string password)
        {
            var motDePasse = EncodeMD5(password);
            var user = this._assoFlex.Utilisateurs.FirstOrDefault(u => 
                u.Email == email && u.Password == motDePasse);
            return user;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            return _assoFlex.Utilisateurs.ToList();
        }

        public Utilisateur CreateUtilisateur(string prenom, string nom, string adresse, int telephone, string email,
            string password, string profilImg, string role = "Basic")
        {
            Utilisateur userToAdd = new Utilisateur()
            {
                Prenom = prenom,
                Nom = nom,
                Adresse = adresse,
                Telephone = telephone,
                Email = email,
                Password = password,
                ProfilImg = profilImg,
                Role = role
            };
            this._assoFlex.Utilisateurs.Add(userToAdd);
            this.CreatePanier(userToAdd);
            this._assoFlex.SaveChanges();
            return userToAdd;
        }

        public void UpdateUtilisateur(int id, string prenom, string nom, string adresse, int telephone, string email,
            string password, string profilImg, string role)
        {
            Utilisateur userToUpdate = this._assoFlex.Utilisateurs.Find(id);
            if (userToUpdate != null)
            {
                userToUpdate.Prenom = prenom;
                userToUpdate.Nom = nom;
                userToUpdate.Adresse = adresse;
                userToUpdate.Telephone = telephone;
                userToUpdate.Email = email;
                userToUpdate.Password = password;
                userToUpdate.ProfilImg = profilImg;
                userToUpdate.Role = role;
                this._assoFlex.SaveChanges();
            }
        }

        public void DeleteUtilisateur(int id)
        {
            Utilisateur userToDelete = this._assoFlex.Utilisateurs.Find(id);
            if (userToDelete != null)
            {
                this._assoFlex.Utilisateurs.Remove(userToDelete);
                this._assoFlex.SaveChanges();
            }
        }

        #endregion

        #region Association

        public Association GetAssociation(int id)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.Id == id);
        }

        public Association GetAssociation(string idStr)
        {
            return int.TryParse(idStr, out var id) ? this.GetAssociation(id) : null;
        }

        public int GetAssociationId(int idAdmin)
        {
            return this._assoFlex.Associations.FirstOrDefault(a => a.AdminAssoId == idAdmin)!.Id;
        }

        public List<Association> GetAllAssociations()
        {
            return _assoFlex.Associations.Include(a => a.AdminAsso).ToList();
        }

        public List<IWidgetAsso> GetAssociationsToWidget()
        {
            
            List<Association> laListe = GetAllAssociations();
            var assoWidget = new List<IWidgetAsso>();
            foreach (var asso in laListe)
            {
                asso.SubWidgetAsso = new SubwidgetAsso
                {
                    Nom = asso.Nom,
                    Description = asso.Description
                };
                assoWidget.Add(asso);
            }
            return assoWidget;
        }

        public Association CreateAssociation(string nom, string numSiret, int idGerant, byte[] logoAsso, string description = "")
        {
            Association assoToAdd = new Association()
            {
                Nom = nom,
                NumSiret = numSiret,
                DateInscription = DateTime.Now,
                Description = description,
                AdminAsso = this._assoFlex.Utilisateurs.Find(idGerant)
            };
            this._assoFlex.Associations.Add(assoToAdd);
            this._assoFlex.SaveChanges();
            return assoToAdd;
        }

        public void UpdateAssociation(int id, string nom, string numSiret, byte[] logoAsso, string description)
        {
            Association assoToUpdate = this._assoFlex.Associations.Find(id);
            if (assoToUpdate != null)
            {
                assoToUpdate.Nom = nom;
                assoToUpdate.NumSiret = numSiret;
                assoToUpdate.Description = description;
                this._assoFlex.SaveChanges();
            }
        }

        public void DeleteAssociation(int id)
        {
            Association assoToDelete = this._assoFlex.Associations.Find(id);
            if (assoToDelete != null)
            {
                this._assoFlex.Associations.Remove(assoToDelete);
                this._assoFlex.SaveChanges();
            }
        }

        #endregion

        #region Adhesion

        public List<Adhesion> GetAllAdhesions()
        {
            return this._assoFlex.Adhesions.ToList();
        }

        public Adhesion CreateAdhesion(int idAsso, int idUser, int adhesionArticleId)
        {
            AdhesionArticle adhesionArticle = this.GetAdhesionArticle(adhesionArticleId);
            DateTime dateFin;
            switch (Convert.ToInt16(adhesionArticle.Frequence))
            {
                case 1:
                    dateFin = DateTime.Now.AddMonths(1);
                    break;
                case 2:
                    dateFin = DateTime.Now.AddMonths(3);
                    break;
                case 3:
                    dateFin = DateTime.Now.AddMonths(6);
                    break;
                case 4:
                    dateFin = DateTime.Now.AddYears(1);
                    break;
                default:
                    dateFin = DateTime.Now.AddMonths(1);
                    break;
            }
            Adhesion adhesionToAdd = new Adhesion()
            {
                Association = this._assoFlex.Associations.Find(idAsso),
                Utilisateur = this._assoFlex.Utilisateurs.Find(idUser),
                DateDebut = DateTime.Now,
                DateFin = dateFin,
            };
            this._assoFlex.Adhesions.Add(adhesionToAdd);
            this._assoFlex.SaveChanges();
            return adhesionToAdd;
        }

        public void UpdateAdhesion()
        {
            throw new NotImplementedException();
        }

        public void DeleteAdhesion(int id)
        {
            Adhesion adhesionToDelete = this._assoFlex.Adhesions.Find(id);
            this._assoFlex.Adhesions.Remove(adhesionToDelete);
            this._assoFlex.SaveChanges();
        }

        #endregion

        #region AdhesionArticle

        public List<AdhesionArticle> GetAllAdhesionArticles()
        {
            return this._assoFlex.AdhesionArticles.ToList();
        }

        public AdhesionArticle GetAdhesionArticle(int id)
        {
            return this._assoFlex.AdhesionArticles.Find(id);
        }

        public AdhesionArticle CreateAdhesionArticle(Association association,
            string frequence, decimal montant)
        {
            AdhesionArticle adhesionArticleToAdd = new AdhesionArticle()
            {
                Association = association,
                Nom = "Standard",
                Frequence = frequence,
                MontantAdh = montant
            };
            this._assoFlex.AdhesionArticles.Add(adhesionArticleToAdd);
            this._assoFlex.SaveChanges();
            return adhesionArticleToAdd;
        }

        public void UpdateAdhesionArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdhesionArticle(int id)
        {
            AdhesionArticle adhesionArticleToDelete = 
                this._assoFlex.AdhesionArticles.Find(id);
            this._assoFlex.AdhesionArticles.Remove(adhesionArticleToDelete);
            this._assoFlex.SaveChanges();
        }

        #endregion

        #region Souscription

        public List<Souscription> GetAllSouscriptions()
        {
            return this._assoFlex.Souscriptions.ToList();
        }

        public Souscription GetSouscription(int id)
        {
            throw new NotImplementedException();
        }

        public Souscription CreateSouscrition(int id, string formule="Formule 0")
        {
            Association association = this._assoFlex.Associations.Find(id);
            Souscription souscriptionToAdd = new Souscription()
            {
                Association = association,
                DateDebut = DateTime.Now,
                DateFin = DateTime.Now.AddYears(1),
                Formule = formule
            };
            this._assoFlex.Souscriptions.Add(souscriptionToAdd);
            this._assoFlex.SaveChanges();
            return souscriptionToAdd;
        }

        public void UpdateSouscription()
        {
            throw new NotImplementedException();
        }

        public void DeleteSouscription(int id)
        {
            Souscription souscriptionToDelete = this._assoFlex.Souscriptions.Find(id);
            this._assoFlex.Souscriptions.Remove(souscriptionToDelete);
            this._assoFlex.SaveChanges();
        }

        #endregion

        #region Crowdfunding

        public Crowdfunding GetCrowdfunding(int id)
        {
            return _assoFlex.Crowdfundings.Include(c => c.PorteurDuProjet).ThenInclude(e => e.AdminAsso).FirstOrDefault(a => a.Id==id);
        }

        public Crowdfunding GetCfCollecte(int id)
        {
            return _assoFlex.Crowdfundings.Include(c => c.Collecte).FirstOrDefault(a => a.Id == id);
        }
        
        public List<Crowdfunding> GetAllCrowdfundings()
        {
            return _assoFlex.Crowdfundings.Include(c =>c.Collecte).ToList();
        }
        
        public List<IWidgetCF> GetCrowdfundingsToWidget()
        {
            
            List<Crowdfunding> laListe = GetAllCrowdfundings();
            var cfWidget = new List<IWidgetCF>();
            foreach (var cf in laListe)
            {
                cf.SubWidgetCF = new SubWidgetCF
                {
                    Nom = cf.Nom,
                    DateFinProjet = cf.DateFinProjet,
                    CategorieProjet = cf.CategorieProjet,
                    MontantProjet = cf.MontantProjet,
                    Collecte = cf.Collecte,
                    PorteurDuProjet = cf.PorteurDuProjet,
                    Description = cf.Description
                };
                cfWidget.Add(cf);
            }
            return cfWidget;
        }
        



        public Crowdfunding CreateCrowdfunding(string nom, int Montant, string LieuProjet, string CategorieProjet, DateTime DateDebut,
            DateTime DateFin, Association Porteur, Collecte collecte, string description)
        {
            Crowdfunding crowdfundingToAdd = new Crowdfunding()
            {
                Nom = nom,
                MontantProjet = Montant,
                LieuProjet = LieuProjet,
                CategorieProjet = CategorieProjet,
                DateCreation = DateTime.Now,
                DateDebutProjet = DateDebut,
                DateFinProjet = DateFin,
                PorteurDuProjet = Porteur,
                Collecte = collecte,
                Statut = true,
                Description =description
            };
            this._assoFlex.Crowdfundings.Add(crowdfundingToAdd);
            this._assoFlex.SaveChanges();
            return crowdfundingToAdd;
        }

        public void DeleteCrowdfunding(int id)
        {
            Crowdfunding crowdfundingToDelete = this._assoFlex.Crowdfundings.Find(id);
            this._assoFlex.Crowdfundings.Remove(crowdfundingToDelete);
            this._assoFlex.SaveChanges();
        }

        public Crowdfunding UpdateCrowdfunding(int Id, string Nom, int Montant, string LieuProjet, string CategorieProjet,
            DateTime DateFin)
        {
            Crowdfunding crowdfundingToUpdate = this._assoFlex.Crowdfundings.Find(Id);

            if (crowdfundingToUpdate != null)
            {
                crowdfundingToUpdate.Nom = Nom;
                crowdfundingToUpdate.MontantProjet = Montant;
                crowdfundingToUpdate.LieuProjet = LieuProjet;
                crowdfundingToUpdate.CategorieProjet = CategorieProjet;
                crowdfundingToUpdate.DateFinProjet = DateFin;

                this._assoFlex.Update(crowdfundingToUpdate);
                this._assoFlex.SaveChanges();
            }
            return crowdfundingToUpdate;
        }
        
        #endregion

        #region Collecte

        public List<Collecte> GetAllCollectes()
        {
            throw new NotImplementedException();
        }

        public Collecte GetCollecte(int id)
        {
            return _assoFlex.Collectes.Find(id);
        }
        public Collecte CreateCollecte()
        {
            Collecte maCollecte = new Collecte()
            {
                MontantCollecte = 0,
            };
            _assoFlex.Add(maCollecte);
            _assoFlex.SaveChanges();
            return maCollecte;
        }

        public void UpdateCollecte()
        {
            throw new NotImplementedException();
        }

        public void DeleteCollecte(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Contribution

        public List<Contribution> GetAllContributions()
        {
            throw new NotImplementedException();
        }

        public Contribution GetAllContribution(int id)
        {
            throw new NotImplementedException();
        }
        
        public Contribution CreateContribution(double montantContribution, int collecteId, Utilisateur userLoggedIn)
        {
            Collecte maCollecte = GetCollecte(collecteId);
            Contribution maContribution = new Contribution()
            {
                MontantContribution = montantContribution,
                collecte = maCollecte,
                DateContribution = DateTime.Now,
                utilisateur = userLoggedIn,

            };

            maCollecte.MontantCollecte = (maCollecte.MontantCollecte + montantContribution);
            _assoFlex.Update(maCollecte);
            _assoFlex.Add(maContribution);
            _assoFlex.SaveChanges();
            return maContribution;
        }

        public void UpdateContribution(int id, double montantContribution, int collecteId, Utilisateur userLoggedIn)
        {
            throw new NotImplementedException();
        }

        public void DeleteContribution(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Billetterie

        public List<Billetterie> GetAllBilletteries()
        {
            throw new NotImplementedException();
        }

        public Billetterie GetBilletterie(int id)
        {
            throw new NotImplementedException();
        }

        public Billetterie CreateBilletterie(string nom, string prenom)
        {
            throw new NotImplementedException();
        }

        public void DeleteBilletterie(int id)
        {
            throw new NotImplementedException();
        }
        
        public void UpdateBilletterie(int id, string nom, string prenom)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Evenement

        public List<Evenement> GetAllEvenements()
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ToList();
        }
        
        public List<IWidgetEvent> GetEventToWidget()
        {
            
            List<Evenement> laListe = GetAllEvenements();
            var eventWidget = new List<IWidgetEvent>();
            foreach (var eventInList in laListe)
            {
                eventInList.SubWidgetEvent = new SubWidgetEvent
                {
                    NomEvent = eventInList.NomEvent,
                    Description = eventInList.Description,
                    Prix = eventInList.Prix,
                    DateDebutEvent = eventInList.DateDebutEvent
                };
                eventWidget.Add(eventInList);
            }
            return eventWidget;
        }

        public Evenement GetEvenement(int id)
        {
            return _assoFlex.Evenements.Include(e=>e.Organisateur).ThenInclude(a=> a.AdminAsso).FirstOrDefault(e=>e.IdEvent==id);
        }

        public EvenementViewModel GetEvenementViewModel(int id)
        {
            Evenement eventToVM = _assoFlex.Evenements.Find(id);
            EvenementViewModel evm = new EvenementViewModel();
            evm.Evenements = eventToVM;
            return evm;
            
        }

        public Evenement CreateEvenement(Association organisateur, string nom, int nbTickets, DateTime DateDebut, DateTime DateFin,
            string Lieu, string categorie, int prix, string description)
        {
            Evenement eventToAdd = new Evenement()
            {
                Organisateur = organisateur,
                NomEvent = nom,
                NbTickets = nbTickets,
                NbPlacesRestantes = nbTickets,
                DateDebutEvent = DateDebut,
                DateFinEvent = DateFin,
                LieuEvent = Lieu,
                CategorieEvent = categorie,
                Prix = prix,
                Statut = true,
                Description = description
            };
            this._assoFlex.Evenements.Add(eventToAdd);
            this._assoFlex.SaveChanges();
            return eventToAdd;
        }

        public void DeleteEvenement(int Id)
        {
            Evenement eventToDelete = this._assoFlex.Evenements.Find(Id);
            this._assoFlex.Evenements.Remove(eventToDelete);
            this._assoFlex.SaveChanges();
        }

        public Evenement UpdateEvenement(int Id, string nom, int nbTicket, DateTime DateDebut, DateTime DateFin,
            string Lieu, string categorie, int prix)
        {
            Evenement eventToUpdate = this._assoFlex.Evenements.Find(Id);
            if (eventToUpdate != null)
            {
                eventToUpdate.NomEvent = nom;
                eventToUpdate.NbTickets = nbTicket;
                eventToUpdate.DateDebutEvent = DateDebut;
                eventToUpdate.DateFinEvent = DateFin;
                eventToUpdate.LieuEvent = Lieu;
                eventToUpdate.CategorieEvent = categorie;
                eventToUpdate.Prix = prix;

                this._assoFlex.Update(eventToUpdate);
                this._assoFlex.SaveChanges();
            }

            return eventToUpdate;
        }
        
        #endregion

        #region LigneDeCommande

        public List<LigneDeCommande> GetAllLignesDeCommande()
        {
            return this._assoFlex.LignesDeCommande.ToList();
        }

        public LigneDeCommande GetLigneDeCommande(int id)
        {
            return this._assoFlex.LignesDeCommande.Find(id);
        }

        public LigneDeCommande CreateLigneDeCommande(int userId, decimal montantUnit, int quantite, string typeCommande)
        {
            LigneDeCommande ldcToAdd = new LigneDeCommande()
            {
                UtilisateurId = userId,
                MontantUnitaire = montantUnit,
                Quantite = quantite,
                TypeDeCommande = typeCommande
            };
            this._assoFlex.LignesDeCommande.Add(ldcToAdd);
            this._assoFlex.SaveChanges();
            return ldcToAdd;
        }

        public void UpdateLigneDeCommande(int id, int userId, decimal montantUnit, int quantite, string typeCommande)
        {
            LigneDeCommande ldcToUpdate = this._assoFlex.LignesDeCommande.Find(id);
            ldcToUpdate.UtilisateurId = userId;
            ldcToUpdate.MontantUnitaire = montantUnit;
            ldcToUpdate.Quantite = quantite;
            ldcToUpdate.TypeDeCommande = typeCommande;
            this._assoFlex.SaveChanges();
        }

        public void DeleteLigneDeCommande(int id)
        {
            LigneDeCommande ldcToDelete = this._assoFlex.LignesDeCommande.Find(id);
            this._assoFlex.LignesDeCommande.Remove(ldcToDelete);
            this._assoFlex.SaveChanges();
        }

        #endregion

        #region Commande

        public List<Commande> GetAllCommandes()
        {
            return this._assoFlex.Commandes.ToList();
        }

        public Commande GetCommande(int id)
        {
            return this._assoFlex.Commandes.FirstOrDefault(c => c.Id == id);
        }

        public Commande CreateCommande(int userId, int quantiteTotal, double sousTotal, double total,
            List<LigneDeCommande> lignesDeCommande)
        {
            Commande commandeToAdd = new Commande()
            {
                UtilisateurId = userId,
                DateCommande = DateTime.Now,
                QuantiteTotal = quantiteTotal,
                SousTotal = sousTotal,
                Total = total,
                LignesDeCommande = lignesDeCommande
            };
            this._assoFlex.Commandes.Add(commandeToAdd);
            this._assoFlex.SaveChanges();
            return commandeToAdd;
        }

        public void AddLigneCommandeToCommande(int id, LigneDeCommande ligneDeCommande)
        {
            Commande commandeToAddLdC = this._assoFlex.Commandes.Find(id);
            commandeToAddLdC.LignesDeCommande.Add(ligneDeCommande);
            this._assoFlex.SaveChanges();
        }

        public void UpdateCommande(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommande(int id)
        {
            Commande commandeToDelete = this._assoFlex.Commandes.Find(id);
            this._assoFlex.Commandes.Remove(commandeToDelete);
            this._assoFlex.SaveChanges();
        }
        
        #endregion

        #region Panier

        public List<Panier> GetAllPaniers()
        {
            return this._assoFlex.Paniers.ToList();
        }

        public Panier GetPanier(int id)
        {
            return this._assoFlex.Paniers.Find(id);
        }

        public Panier GetPanierByUserId(int userId)
        {
            var panier = this._assoFlex.Paniers.FirstOrDefault(p => p.UtilisateurId == userId);
            panier.Utilisateur = this.GetUtilisateur(userId);
            return panier;
        }

        public Panier GetPanierByUserId(string userIdStr)
        {
            return int.TryParse(userIdStr, out var id) ? this.GetPanierByUserId(id) : null;
        }

        public Panier CreatePanier(Utilisateur user)
        {
            Panier panierToAdd = new Panier()
            {
                Utilisateur = user,
                ArticlesPanier = new List<ArticlePanier>(),
            };
            this._assoFlex.Paniers.Add(panierToAdd);
            this._assoFlex.SaveChanges();
            return panierToAdd;
        }

        public void AddArticleToPanier(int id, ArticlePanier articlePanier)
        {
            Panier panier = this._assoFlex.Paniers.Find(id);
            if (panier.ArticlesPanier == null)
            {
                panier.ArticlesPanier = new List<ArticlePanier>();
            }
            panier.ArticlesPanier.Add(articlePanier);
            this._assoFlex.SaveChanges();
        }

        public void UpdatePanier(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePanier(int id)
        {
            Panier panierToDelete = this._assoFlex.Paniers.Find(id);
            this._assoFlex.Paniers.Remove(panierToDelete);
        }

        public List<ArticlePanier> GetArticlesPanierByPanierId(int panierId)
        {
            List<ArticlePanier> listeArticle = this._assoFlex.ArticlesPanier.Where(c => c.PanierId == panierId).ToList();
            return listeArticle;
        }

        #endregion
    }
}
