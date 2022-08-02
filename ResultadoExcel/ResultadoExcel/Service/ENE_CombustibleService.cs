using EFCore.BulkExtensions;
using ResultadoExcel.Context;
using ResultadoExcel.Models;

namespace ResultadoExcel.Service
{
    public class ENE_CombustibleService : IENE_CombustibleService
    {

        DatabaseContext  _dbContext= null;
        public ENE_CombustibleService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ENE_Combustible> GetCombustibles()
        {
            return _dbContext.ENE_Combustible.ToList();
        }

        public List<ENE_Combustible> SaveCombustibles(List<ENE_Combustible> ENE_Combustible)
        {
            _dbContext.BulkInsert(ENE_Combustible);
            return ENE_Combustible;
        }
    }
}
