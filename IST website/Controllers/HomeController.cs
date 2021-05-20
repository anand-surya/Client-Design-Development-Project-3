using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;
        

     
        public HomeController(IGetFaculty facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        

        public async Task<IActionResult> Index()
        {
            var getAbout = new GetIndex();
            var under = await getAbout.GetAbout();
            var indViewModel = new IndexViewModel()
            {
                Ind = under,
                Title = "About"
            };
            return View(indViewModel);
        }

        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var facultyViewModel = new FacultyViewModel()
            {
                Faculty = allFaculty.ToList(),
                Title = "Faculty"
            };
            return View(facultyViewModel);
        }

        public async Task<IActionResult> GetStaff() { 
        
            var getStaff = new GetStaff();
            var stafff = await getStaff.gStaff();
            
            var staffViewModel = new StaffViewModel()
            {
                Staff = stafff.ToList(),
                Title = "Staff"
            };
            return View(staffViewModel);
        }

        public async Task<IActionResult> Under()
        {
            var getUnder = new GetUndergraduate();
            var under = await getUnder.GetUnderGradDegrees();
            var underViewModel = new UndergradViewModel()
            {
                UnderGrads = under,
                Title = "Undergraduate Programs",
          
            };
            return View(underViewModel);
        }

        public async Task<IActionResult> Minor()
        {
            var getMinor = new GetMinors();
            var ugMinor = await getMinor.GetUgMinors();
            var minorViewModel = new MinorViewModel()
            {
                Minors = ugMinor,
                Title = "Undergraduate Minors"
            };
            return View(minorViewModel);
        }

        public async Task<IActionResult> Grad()
        {
            var getGrad = new GetGraduate();
            var grad = await getGrad.GetGradDegrees();
            var gradViewModel = new GradViewModel()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            return View(gradViewModel);
        }

        public async Task<IActionResult> Employment()
        {
            var getEmp = new GetEmployment();
            var Empl = await getEmp.GetEmpTable();
            var gradViewModel = new EmploymentViewModel()
            {
                Emp = Empl,
                Title = "Employment History"
            };
            return View(gradViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
