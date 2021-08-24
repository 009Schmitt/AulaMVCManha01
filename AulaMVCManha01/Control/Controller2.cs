using AulaMVCManha01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVCManha01.Control
{
    public static class Controller2
    {
        public static List<string[]> SelectAll(string table)
        {
            if(!string.IsNullOrEmpty(table))
            {
                return DBFunction.GenericSelectAll(table);
            }
            else
            {
                return new List<string[]>();
            }
        }

        public static List<string> SelectAllFree()
        {
            return DBFunction.GenericUnitSelect("idEstacionamento", "Estacionamento", "Placa is null");
        }
        public static List<string> SelectAllOccupied()
        {
            return DBFunction.GenericUnitSelect("Placa","Estacionamento","Placa is not null");
        }

        public static bool AtualizaEntrada(string placa, string horaEntrada, string vaga)
        {
            if (!string.IsNullOrEmpty(placa) && 
                !string.IsNullOrEmpty(horaEntrada) && 
                !string.IsNullOrEmpty(vaga))
            {
                return EstacionamentoDB.AtualizaEntrada(placa, horaEntrada, vaga);
            }
            else
            {
                return false;
            }
        }

    }
}
