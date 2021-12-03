using InfirmerieBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieDAL
{
    public class VisiteDAO
    {
        private static VisiteDAO unVisiteDAO;

        // Accesseur en lecture, renvoi une instance
        public static VisiteDAO GetunVisiteDAO()
        {
            if (unVisiteDAO == null)
            {
                unVisiteDAO = new VisiteDAO();
            }

            return unVisiteDAO;
        }

        public static List<Visite> GetVisites()
        {
            throw new NotImplementedException();
        }
    }
}
