using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atendimento.Entities;
using Atendimento.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Controllers
{
    public class AtendimentoController : Controller
    {
        IPacienteRepositorio _rep;
        public AtendimentoController(IPacienteRepositorio rep)
        {
            _rep = rep;
        }
        public IActionResult Index()
        {
            return View(_rep.GetPacientes());
        }
        public IActionResult AddPaciente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPaciente(Paciente paciente)
        {
            _rep.AddPaciente(paciente);
            return RedirectToAction("Index");
        }
        public IActionResult EditPaciente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditPaciente(Paciente paciente)
        {
            _rep.EditPaciente(paciente);
            return RedirectToAction("Index");
        }
        public IActionResult RemovePaciente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemovePaciente(Paciente paciente)
        {
            _rep.RemovePaciente(paciente);
            return RedirectToAction("Index");
        }
    }
}