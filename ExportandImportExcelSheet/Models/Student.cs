namespace ExportandImportExcelSheet.Models
{
    public class Student
    {
      public  int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int age { get; set; }

        public virtual Schoole Schoole { get; set; }
        public virtual List<Subject> Subjects { get; set; }



    }
}
