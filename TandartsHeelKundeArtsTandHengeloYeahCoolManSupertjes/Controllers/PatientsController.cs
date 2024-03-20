﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Data;
//using TandartsSuperCool.Models;

//namespace TandartsSuperCool.Controllers
//{
//    public class PatientsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public PatientsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Patients
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Patient.ToListAsync());
//        }

//        // GET: Patients/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var patient = await _context.Patient
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (patient == null)
//            {
//                return NotFound();
//            }

//            return View(patient);
//        }

//        // GET: Patients/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Patients/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("ID,Zorgverzekeraar,Klantnummer")] Patient patient)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(patient);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(patient);
//        }

//        // GET: Patients/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var patient = await _context.Patient.FindAsync(id);
//            if (patient == null)
//            {
//                return NotFound();
//            }
//            return View(patient);
//        }

//        // POST: Patients/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("ID,Zorgverzekeraar,Klantnummer")] Patient patient)
//        {
//            if (id != patient.ID)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(patient);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!PatientExists(patient.ID))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(patient);
//        }

//        // GET: Patients/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var patient = await _context.Patient
//                .FirstOrDefaultAsync(m => m.ID == id);
//            if (patient == null)
//            {
//                return NotFound();
//            }

//            return View(patient);
//        }

//        // POST: Patients/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var patient = await _context.Patient.FindAsync(id);
//            if (patient != null)
//            {
//                _context.Patient.Remove(patient);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool PatientExists(int id)
//        {
//            return _context.Patient.Any(e => e.ID == id);
//        }
//    }
//}
