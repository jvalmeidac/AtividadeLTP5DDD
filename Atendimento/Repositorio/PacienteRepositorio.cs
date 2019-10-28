using System;
using System.Collections.Generic;
using Atendimento.Entities;
using Atendimento.Infra;
using Dapper;

namespace Atendimento.Repositorio
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        IDB _db;
        public PacienteRepositorio(IDB db)
        {
            _db = db;
        }
        public void AddPaciente(Paciente paciente)
        {
            using (var con = _db.GetConnection())
            {
                con.Execute($"INSERT INTO Paciente(ID,Nome,Sobrenome,CPF,DataNasc,Endereco)" +
                    $" VALUES(@ID,@Nome,@Sobrenome,@CPF,@DataNasc,@Endereco)",
                    new { paciente.ID, paciente.Nome, paciente.Sobrenome, paciente.CPF, paciente.DataNasc, paciente.Endereco });
            }
        }

        public void EditPaciente(Paciente paciente)
        {
            using(var con = _db.GetConnection())
            {
                con.Execute($"UPDATE Paciente SET Nome = @Nome, Sobrenome = @Sobrenome, CPF = @CPF, DataNasc = @DataNasc, Endereco = @Endereco WHERE ID={paciente.ID}");
            }
        }

        public Paciente GetPacienteByID(Guid ID)
        {
            using(var con = _db.GetConnection())
            {
                return con.QueryFirst<Paciente>($"SELECT * FROM Atendimento WHERE ID={ID}");
            }
        }

        public IEnumerable<Paciente> GetPacientes()
        {
            using(var con = _db.GetConnection())
            {
                return con.Query<Paciente>("SELECT * FROM Paciente");
            }
        }

        public void RemovePaciente(Paciente paciente)
        {
            using(var con = _db.GetConnection())
            {
                con.Execute($"DELETE FROM Paciente WHERE ID={paciente.ID}");
            }
        }
    }
}
