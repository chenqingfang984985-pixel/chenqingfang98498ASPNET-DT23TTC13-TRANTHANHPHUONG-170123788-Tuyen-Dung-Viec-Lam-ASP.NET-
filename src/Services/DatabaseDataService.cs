using Microsoft.EntityFrameworkCore;
using TuyenDungViecLam.Data;
using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Services
{
    public class DatabaseDataService : IDataService
    {
        private readonly ApplicationDbContext _context;

        public DatabaseDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetJobByIdAsync(string id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<List<Employer>> GetEmployersAsync()
        {
            return await _context.Employers.ToListAsync();
        }

        public async Task<Employer?> GetEmployerByIdAsync(string id)
        {
            return await _context.Employers.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<phuongtran84>> Getphuongtran84Async()
        {
            return await _context.phuongtran84.ToListAsync();
        }

        public async Task<List<Application>> GetApplicationsAsync()
        {
            return await _context.Applications.ToListAsync();
        }

        public async Task<List<Job>> SearchJobsAsync(string? keyword, string? location, string? category)
        {
            var query = _context.Jobs.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(j => j.Title.Contains(keyword) || j.Company.Contains(keyword));
            }

            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(j => j.Location.Contains(location));
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(j => j.Category == category);
            }

            return await query.ToListAsync();
        }
    }
}