using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehiclesTracking.Models;

namespace VehiclesTracking.Controllers
{
    public class VehicleController : Controller
    {
        //Home
        public ActionResult Home()
        {
            DbHandle dbhandle = new DbHandle();
            var vehicles = dbhandle.GetVehicle();
            List<int> regNumb = new List<int>();
            foreach (var veh in vehicles)
            {
                regNumb.Add(veh.RegistrationNumber);
            }
            //ViewBag.RegistrationNumber = new SelectList(vehicles, "RegistrationNumber");
            ViewBag.RegistrationNumber = regNumb;
            return View(vehicles);
        }

        // GET: Vehicle
        public ActionResult Index()
        {
            DbHandle dbhandle = new DbHandle();
            ModelState.Clear();
            return View(dbhandle.GetVehicle());
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DbHandle vdb = new DbHandle();
                    if (vdb.AddVehicle(vehicle))
                    {
                        ViewBag.Message = "Vehicle Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                //return View();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            DbHandle vdb = new DbHandle();
            return View(vdb.GetVehicle().Find(vehicle => vehicle.Id == id));
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Vehicle vehicle)
        {
            try
            {
                DbHandle vdb = new DbHandle();
                vdb.UpdateVehicle(vehicle);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                DbHandle vdb = new DbHandle();
                if (vdb.DeleteVehicle(id))
                {
                    ViewBag.AlertMsg = "Vehicle Deleted Successfully";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Owner/5
        public ActionResult Owner(int regNumb)
        {
            int registrationNumber = Convert.ToInt32(regNumb);
            DbHandle vdb = new DbHandle();
            return View(vdb.GetVehicleOwner(registrationNumber));
        }

    }
}
