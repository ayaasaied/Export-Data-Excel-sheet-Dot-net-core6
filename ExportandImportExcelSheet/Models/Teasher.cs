namespace ExportandImportExcelSheet.Models
{
    public class Teasher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int age { get; set; }
        public virtual  Schoole Schoole { get; set; }



    }
}
