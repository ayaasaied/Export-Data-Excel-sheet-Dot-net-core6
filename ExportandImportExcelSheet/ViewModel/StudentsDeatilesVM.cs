using ExportandImportExcelSheet.Models;
using System.ComponentModel.DataAnnotations;

namespace ExportandImportExcelSheet.ViewModel
{
    public class StudentsDeatilesVM
    {
        [Key]
        public int StudentId { get; set; }
        public int schooleid { get; set; }
        public int subjectid { get; set; }
        public string StudentName { get; set;}
        public int StudentAge { get; set;}
        public string schooleName { get; set;}
        public string subjectName { get; set;}
        public virtual Schoole Schoole { get; set; }
        public virtual List<Subject> Subjects { get; set; }

    }
}
