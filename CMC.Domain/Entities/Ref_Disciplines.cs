using System.ComponentModel.DataAnnotations;

namespace CMCDemo.Domain.Entities
{
    public class Ref_Disciplines
    {
        [Key]
        public int Ref_Disciplines_Code { get; set; }
        public string? DisciplinesName { get; set; }
        public string? DisciplinesDescription { get; set; }
        public string? DisciplinesType { get; set; }
        public DateTime? DateObtained { get; set; }
    }
}