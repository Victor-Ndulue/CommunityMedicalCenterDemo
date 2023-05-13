using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMCDemo.Domain.Entities
{
    public class Ref_Disciplines
    {
        [Key]
        public int Ref_Disciplines_Code { get; set; }
        [ForeignKey(nameof(ProfessionalStaff))]
        public int ProfessionalStaff_Id { get; set; }
        public string? DisciplinesName { get; set; }
        public string? DisciplinesDescription { get; set; }
        public string? DisciplinesType { get; set; }
        public DateTime? DateObtained { get; set; }

        public  ProfessionalStaff? ProfessionalStaff { get; set;}
    }
}