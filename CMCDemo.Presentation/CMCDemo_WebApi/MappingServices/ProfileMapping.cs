using AutoMapper;
using CMCDemo.Applications.DTO_s;
using CMCDemo.Applications.DTO_s.DepartmentDTOS;
using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS;
using CMCDemo.Domain.Entities;

namespace CMCDemo_WebApi.MappingServices
{
    public class ProfileMapping : Profile
    {
        protected ProfileMapping()
        {
            CreateMap<Community_Medical_Centers, Community_Medical_CentersDto>();
            CreateMap<Community_Medical_CentersForCreation, Community_Medical_Centers>();
            CreateMap<Community_Medical_CentersForUpdate, Community_Medical_Centers>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentForCreation, Department>();
            CreateMap<DepartmentForUpdate, Department>();
            CreateMap<MedicalCenterAddress, MedicalCenterAddressDto>();
            CreateMap<MedicalCenterAddressForCreation, MedicalCenterAddress>();
            CreateMap<MedicalCenterAddressForUpdate, MedicalCenterAddress>();
            CreateMap<ProfessionalStaff, ProfessionalStaffDto>();
            CreateMap<ProfessionalStaffForCreation, ProfessionalStaff>();
            CreateMap<ProfessionalStaffForUpdate, ProfessionalStaff>();
            CreateMap<Ref_Disciplines, Ref_DisciplinesDto>();
            CreateMap<Ref_DisciplinesForCreation, Ref_Disciplines>();
            CreateMap<Ref_DisciplinesForUpdate, Ref_Disciplines>();
            CreateMap<StaffAddress, ProfessionalStaffDto>();
            CreateMap<ProfessionalStaffForCreation, ProfessionalStaff>();
            CreateMap<ProfessionalStaffForUpdate, ProfessionalStaff>();
        }
    }
}
