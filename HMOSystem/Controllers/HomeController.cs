using HMO.BL.BE;
using HMOSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMOSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PatientModel patientModel = new PatientModel();
            var PatientList = patientModel.GetPatients();
            return View(PatientList.ToList());

        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            PatientModel patientModel = new PatientModel();
            var PatientList = patientModel.GetPatients();
            var patient = PatientList.Where(p => p.Id == id).FirstOrDefault();
            return View(patient);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            Patient patient = new Patient();
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            try
            {
                // TODO: Add insert logic here
                PatientModel model = new PatientModel();
                model.AddPatient(patient.Id, patient.FirstName, patient.LastName, patient.Addres, patient.Birthday,
                                 patient.Telephone, patient.PhoneNumber, patient.VaccineDates, patient.PositiveDate, patient.RecoveryDate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            PatientModel patientModel = new PatientModel();
            var PatientList = patientModel.GetPatients();
            var patient = PatientList.Where(p => p.Id == id).FirstOrDefault();
            return View(patient);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Patient patient)
        {
            try
            {
                // TODO: Add update logic here
                PatientModel model = new PatientModel();
                model.EditPatient(patient);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            PatientModel patientModel = new PatientModel();
            var PatientList = patientModel.GetPatients();
            var patient = PatientList.Where(p => p.Id == id).FirstOrDefault();
            return View(patient);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                PatientModel model = new PatientModel();
                model.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult AddVaccine(Patient patient)
        {
            Vaccine vaccine = new Vaccine();
            return View();
        }
        // POST: Home/AddVaccine
        [HttpPost]
        public ActionResult AddVaccine(Vaccine vaccine)
        {

            try
            {
                // TODO: Add insert logic here
                VaccineModel vacModel = new VaccineModel();
                vacModel.AddVaccine(vaccine.Id, vaccine.VacDate, vaccine.Producer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult VaccineDetails(Vaccine vaccine)
        {
            VaccineModel vaccineModel = new VaccineModel();
            var VaccineList = vaccineModel.GetVaccines();
            

            //ViewData["Vaccines"] = Vaccines;

            //PatientModel patientModel = new PatientModel();
            //var PatientList = patientModel.GetPatients();
            //var patient = PatientList.Where(p => p.Id == id).FirstOrDefault();
            //List<Vaccine> Vaccines = patient.VaccineDates;
           // VaccineModel vacModel = new VaccineModel();
           // var VaccineList = vacModel.GetVaccines(patient);
           //// var vaccine = VaccineList.Where(v => v.Id == id).FirstOrDefault();
            return View(VaccineList);
        }
    }
}
