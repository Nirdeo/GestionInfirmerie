using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class QuantiteMedicament
    {
        private int Id_visite_quantite_medic;
        private int Id_medicament_quantite_medic;
        private int Quantite_medic;

        public QuantiteMedicament(int id_visite_quantite_medic, int quantite_medic)
        {
            Id_visite_quantite_medic = id_visite_quantite_medic;
            Quantite_medic = quantite_medic;
        }

        public QuantiteMedicament(int id_visite_quantite_medic, int id_medicament_quantite_medic, int quantite_medic)
        {
            Id_visite_quantite_medic = id_visite_quantite_medic;
            Id_medicament_quantite_medic = id_medicament_quantite_medic;
            Quantite_medic = quantite_medic;
        }

        public int Id_visite_quantite { get => Id_visite_quantite_medic; set => Id_visite_quantite_medic = value; }
        public int Id_medicament_quantite { get => Id_medicament_quantite_medic; set => Id_medicament_quantite_medic = value; }
        public int Quantite { get => Quantite_medic; set => Quantite_medic = value; }

        public override string ToString()
        {
            return Quantite.ToString();
        }
    }
}
