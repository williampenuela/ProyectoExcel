using EFCore.BulkExtensions;
using ResultadoExcel.Context;
using ResultadoExcel.Models;

namespace ResultadoExcel.Service
{
    public class CombustibleService : ICombustibleService
    {

        DatabaseContext  _dbContext= null;
        public CombustibleService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Combustible> GetCombustibles()
        {
            return _dbContext.ENE_Combustible.ToList();
        }

        public List<Combustible> SaveCombustibles(List<Combustible> combustibles)
        {
            _dbContext.BulkInsert(combustibles);
            return combustibles;
        }
    }
}
