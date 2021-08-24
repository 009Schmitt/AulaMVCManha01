using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVCManha01.Model
{
    public static class EstacionamentoDB
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;

        public static bool AtualizaEntrada(string placa, string horaEntrada,string vaga)
        {
            // {Convert.ToDouble(horaEntrada).ToString(CultureInfo.InvariantCulture)
            // Serve para transformar o numero com , em numero com .
            string update = $"UPDATE dbo.Estacionamento Set Placa = '{placa}', HoraEntrada = {Convert.ToDouble(horaEntrada).ToString(CultureInfo.InvariantCulture)} WHERE idEstacionamento = {vaga}";
            DBFunction.GenericExecute(update);
            return true;
        }





    }
}
