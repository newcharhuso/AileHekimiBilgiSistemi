using Microsoft.AspNetCore.Mvc;
using AileHekimiHastaTakibi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AileHekimiHastaTakibi.Controllers
{
    public class HomeController : Controller
    {
        private static List<Patient> patients = new List<Patient>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }

        public IActionResult AddPatient()
        {
            ViewData["Title"] = "Yeni Hasta Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            patient.Id = nextId++;
            patients.Add(patient);
            return RedirectToAction("PatientList");
        }

        public IActionResult PatientList()
        {
            ViewData["Title"] = "Hasta Listesi";
            return View(patients);
        }

        public IActionResult PatientDetails(int id)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Hasta Detayları";
            return View(patient);
        }
    }
}
