using InfirmerieBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieDAL
{
    public class QuantiteMedicamentDAO
    {
        private static QuantiteMedicamentDAO uneQuantiteMedicamentDAO;

        // Accesseur en lecture, renvoi une instance
        public static QuantiteMedicamentDAO GetuneQuantiteMedicamentDAO()
        {
            if (uneQuantiteMedicamentDAO == null)
            {
                uneQuantiteMedicamentDAO = new QuantiteMedicamentDAO();
            }

            return uneQuantiteMedicamentDAO;
        }

        public static List<QuantiteMedicament> GetQuantiteMedicaments()
        {
            throw new NotImplementedException();
        }
    }
}
