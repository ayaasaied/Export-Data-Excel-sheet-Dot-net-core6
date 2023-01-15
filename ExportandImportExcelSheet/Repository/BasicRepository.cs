using ClosedXML.Excel;
using ExportandImportExcelSheet.Data;
using ExportandImportExcelSheet.Interface;
using ExportandImportExcelSheet.Models;
using ExportandImportExcelSheet.ViewModel;

namespace ExportandImportExcelSheet.Repository
{
    public class BasicRepository : IBaseServices
    {
        private readonly SchooleDBPractice db;
        public BasicRepository(SchooleDBPractice db)
        {
            this.db = db;
        }
        public List<StudentsDeatilesVM> GetAllStudentsDeatiles()
        {
            var stu=db.Student.Select(st => new StudentsDeatilesVM
            {
                StudentName = st.Name,
                StudentId = st.Id,
                Subjects = st.Subjects,


            }).ToList();

            return stu;
          
        }

        public List<Student> GetStudents()
        {
            var students = db.Student.ToList();
            return students;
        }

        public byte[] DownloadExcel(List<Student> students)
        {

            using var workbook = new XLWorkbook();




            var worksheet = workbook.Worksheets.Add("students");
            var currentRow = 1;
            var Currentcoloum = 1;



            worksheet.Cell(currentRow, 1).Value = " Id";
            worksheet.Cell(1, 1).Style.Font.Bold = true;
            worksheet.Cell(currentRow, 2).Value = "Full Name";
            worksheet.Cell(currentRow, 3).Value = "schoole name";
            worksheet.Cell(currentRow, 4).Value = "age";
         

            worksheet.Range("A1:T1").Style.Fill.BackgroundColor = XLColor.BlueGray;
            worksheet.Range("A1:T1").Style.Font.FontSize = 12;
            worksheet.ColumnWidth = 20;
            worksheet.Columns("B").Width = 35;
            worksheet.Range("A:T").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //worksheet.Range("A1:T1")
            //  worksheet.Columns("A").Style.Protection.SetLocked(true);
            // worksheet.Columns("A").Hide();








            foreach (var student in students)
            {
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = student.Id;
                worksheet.Cell(currentRow, 2).Value = student.Name;
                worksheet.Cell(currentRow, 3).Value = student.Schoole.Name;
                worksheet.Cell(currentRow, 4).Value = student.age;
                
            }



            using (var stream = new MemoryStream())
            {



                workbook.SaveAs(stream);
                var content = stream.ToArray();



                return (content);
            }



        }

    }
}
