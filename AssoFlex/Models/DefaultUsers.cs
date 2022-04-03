namespace AssoFlex.Models
{
    public class DefaultUsers
    {
        public static void InitializeUsers()
        {
            using (IDal _dal = new Dal())
            {
                _dal.CreateUtilisateur(
                    "Guytri",
                    "Kastane",
                    "31 rue de l'aurore",
                    0755172316,
                    "gkastane@gmail.com",
                    _dal.EncodeMD5("11111"),
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin"
                );
                _dal.CreateUtilisateur(
                    "Mateusz",
                    "Tirel",
                    "19, rue des petites murailles",
                    0667127014,
                    "admin@admin.admin",
                    _dal.EncodeMD5("admin"),
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin"
                );
                _dal.CreateUtilisateur(
                    "Billal",
                    "Benziane",
                    "32 rue de l'aurore",
                    0755172317,
                    "billal.benziane1@gmail.com",
                    _dal.EncodeMD5("11111"), 
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
                );
                _dal.CreateUtilisateur(
                    "Paul",
                    "Jean",
                    "78 rue de l'aurore",
                    0755172320,
                    "pjean@gmail.com",
                    _dal.EncodeMD5("22222"), 
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
                );
                _dal.CreateUtilisateur(
                    "Jean",
                    "Jacques",
                    "",
                    0755172324,
                    "jjacques@gmail.com", 
                    _dal.EncodeMD5("33333"), 
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
                );
                _dal.CreateUtilisateur(
                    "Jessica",
                    "Alba", 
                    "",
                    0755172328,
                    "jalba@gmail.com",
                    _dal.EncodeMD5("44444"), 
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg","Admin-Asso"
                );
                _dal.CreateUtilisateur(
                    "Louis",
                    "David",
                    "",
                    0755172332,
                    "ldavid@gmail.com",
                    _dal.EncodeMD5("55555"),
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg"
                );
                _dal.CreateUtilisateur(
                    "Alban",
                    "Ivanoff",
                    "",
                    0755172338,
                    "aivanoff@gmail.com",
                    _dal.EncodeMD5("66666"),
                    "fefb70a3-20bf-42e6-8420-7852d44cfa96_avatar.jpeg"
                );
            }
        }

            
    }
}