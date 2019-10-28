using Atendimento.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento.Repositorio
{
    public interface IPacienteRepositorio
    {
        void AddPaciente(Paciente paciente);
        void RemovePaciente(Paciente paciente);
        void EditPaciente(Paciente paciente);
        IEnumerable<Paciente> GetPacientes();
        Paciente GetPacienteByID(Guid ID);

    }
}
