namespace ExportandImportExcelSheet.Models
{
    public class Subject
    {
       public int id { get; set; }
        public string Name { get; set; }
        public virtual List<Schoole> Schooles { get; set;}
        public virtual List<Student> Students { get; set;}
    }
}
