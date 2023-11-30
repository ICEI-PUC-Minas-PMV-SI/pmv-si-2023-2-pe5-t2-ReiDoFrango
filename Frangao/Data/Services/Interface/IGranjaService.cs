using Frangao.Data.Models;

namespace Frangao.Data.Services.Interface
{
    public interface IGranjaService
    {
        Task<List<Granja>> GetAllGranjasAsync();
        Task<List<Granja>> GetPagedGranjasAsync(int page, int pageSize);
        Task UpdateGranjaAsync(Granja updatedGranja);
        int GetTotalGranjasCount();
        Task CreateGranjaAsync(Granja newFarm);
        Task<bool> DeleteGranjaAsync(string id);
    }
}
