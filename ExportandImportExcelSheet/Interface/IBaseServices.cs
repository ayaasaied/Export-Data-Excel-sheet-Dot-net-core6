using ExportandImportExcelSheet.Models;
using ExportandImportExcelSheet.ViewModel;

namespace ExportandImportExcelSheet.Interface
{
    public interface IBaseServices
    {
        List<StudentsDeatilesVM> GetAllStudentsDeatiles();
        public List<Student> GetStudents();
         byte[] DownloadExcel(List<Student> students);
    }
}
