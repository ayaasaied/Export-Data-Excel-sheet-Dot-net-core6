using System.ComponentModel.DataAnnotations.Schema;

namespace ExportandImportExcelSheet.Models
{
    public class Schoole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //[ForeignKey("Student")]
        //public int StudentId { get; set; }
        //[ForeignKey("Teasher")]
        //public int TeasherId { get; set; }

        public virtual List<Student>  Students { get; set; }

        public virtual List<Teasher> Teashers { get; set; }

        public virtual List<Subject> Subjects { get; set; }

    }

}
