namespace InfirmerieDAL
{
    public class ClasseDAO
    {
        private static ClasseDAO uneClasseDAO;

        // Accesseur en lecture, renvoi une instance
        public static ClasseDAO GetuneClasseDAO()
        {
            if (uneClasseDAO == null)
            {
                uneClasseDAO = new ClasseDAO();
            }

            return uneClasseDAO;
        }
    }
}