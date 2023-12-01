using Frangao.Data.Models;
using Frangao.Data.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Frangao.Data.Services
{
    public class GranjaService : IGranjaService
    {
        private readonly AppDbContext _context;
        public GranjaService(AppDbContext context)
        {
            _context = context;  
        }

        public Task CreateGranjaAsync(Granja newFarm)
        {
            newFarm.DateOfCreation = DateTime.Now;
            _context.Add(newFarm);
            return _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteGranjaAsync(string id)
        {
            var farmToDelete = await _context.Granjas.FindAsync(int.Parse(id));

            if (farmToDelete == null)
            {
                return false;
            }

            try
            {
                _context.Granjas.Remove(farmToDelete);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Granja>> GetAllGranjasAsync()
        {
            return await _context.Granjas.ToListAsync();
        }

        public async Task<List<Granja>> GetPagedGranjasAsync(int page, int pageSize)
        {
            return await _context.Granjas
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public int GetTotalGranjasCount()
        {
            return _context.Granjas.Count();
        }

        public async Task UpdateGranjaAsync(Granja updatedGranja)
        {
            var existingGranja = await _context.Granjas.FindAsync(updatedGranja.Id);

            if (existingGranja == null)
            {
                throw new InvalidOperationException("Granja not found for update.");
            }

            existingGranja.FarmName = updatedGranja.FarmName;
            existingGranja.State = updatedGranja.State;
            existingGranja.Municipality = updatedGranja.Municipality;
            existingGranja.ProductionSystem = updatedGranja.ProductionSystem;

            await _context.SaveChangesAsync();
        }
    }
}
