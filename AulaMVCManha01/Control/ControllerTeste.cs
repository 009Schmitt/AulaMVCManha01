using AulaMVCManha01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMVCManha01.Control
{
    public static class ControllerTeste
    {
        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(cpf) &&
                !string.IsNullOrEmpty(rg))
            {
                return DBTeste.AdicionaPessoa(nome, cpf, rg);

            }
            else
            {
                return false;
            }
        }

        public static bool AdicionaFuncionario(string nome, string cpf, string rg,string salario)
        {
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(cpf) &&
                !string.IsNullOrEmpty(rg) &&
                !string.IsNullOrEmpty(salario))
            {
                return DBTeste.AdicionaFuncionario(nome, cpf, rg, salario);

            }
            else
            {
                return false;
            }
        }

        public static List<string[]> SelecionaPessoas()
        {
            return DBTeste.SelecionaPessoas();
        }

        public static List<string[]> SelecionaFuncionarios()
        {
            return DBTeste.SelecionaFuncionarios();
        }
    }
}
