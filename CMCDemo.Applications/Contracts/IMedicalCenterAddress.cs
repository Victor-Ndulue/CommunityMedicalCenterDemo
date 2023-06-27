using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IMedicalCenterAddress
    {
        Task<IEnumerable<MedicalCenterAddress>> GetAllMedicalCenterAddressesAsync(bool trackchanges);
        Task<MedicalCenterAddress> GetMedicalCenterAddressById(int Id, bool trackchanges);
        void UpdateMedicalCenterAddress(MedicalCenterAddress medicalCenterAddress);
        void CreateMedicalCenterAddress(MedicalCenterAddress entity);
        void DeleteMedicalCenterAddress(MedicalCenterAddress entity);
    }
}
