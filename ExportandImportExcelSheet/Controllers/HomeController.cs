using ExportandImportExcelSheet.Interface;
using ExportandImportExcelSheet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExportandImportExcelSheet.Controllers
{
    public class HomeController : Controller

    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBaseServices baseServices;

        public HomeController(ILogger<HomeController> logger ,IBaseServices baseServices)
        {
            _logger = logger;
            this.baseServices = baseServices;
        }

        public IActionResult Index()
        {
            //var Students = baseServices.GetAllStudentsDeatiles();
            //var Students = baseServices.GetStudents().ToList();
            //var excel=baseServices.

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult DownloadExcelsheet()
        {
            var students = baseServices.GetStudents();
            var ResultSheet = baseServices.DownloadExcel(students);
            return File(ResultSheet, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "UsersScoreCards.xlsx");
        }
    }
}