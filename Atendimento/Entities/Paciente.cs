using SharedContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Atendimento.Entities
{
    public class Paciente : EntityBase
    {
        public bool IsValid { get; private set; }
        public List<Tuple<string, string>> Erros { get; private set; }
        public Paciente(Guid _id, String _nome, String _sobrenome, String _cpf)
        {
            _id = ID;
            _nome = Nome;
            _sobrenome = Sobrenome;
            _cpf = CPF;
            IsValid = true;
            if (Nome.Length < 3 || Nome.Length > 20)
            {
                Erros.Add(new Tuple<string, string>("Nome", "O campo Nome não pode ser menor que 3 ou maior que 20!"));
                IsValid = false;
            }
            if (Sobrenome.Length < 3 || Sobrenome.Length > 30)
            {
                Erros.Add(new Tuple<string, string>("Sobrenome", "O campo Sobrenome não pode ser menor que 3 ou maior que 30!"));
                IsValid = false;
            }
            if (CPF.Length < 11 || Sobrenome.Length > 11)
            {
                Erros.Add(new Tuple<string, string>("CPF", "Insira um CPF válido!"));
                IsValid = false;
            }
        }  
        public string CPF { get; private set; }
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; private set; }
        public string Endereco { get; private set; }

    }
}
