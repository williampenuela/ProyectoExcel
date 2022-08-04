using EFCore.BulkExtensions;
using ResultadoExcel.Context;
using ResultadoExcel.Models;

namespace ResultadoExcel.Service
{
    public class CombustibleService : ICombustibleService
    {
        DatabaseContext _dbContext = null;
        public CombustibleService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        // obtiene la informacion de la base de datos
        public List<Combustible> GetCombustibles()
        {
            return _dbContext.ENE_Combustible.ToList();
        }

        // importa los registros a la base de datos
        public List<Combustible> SaveCombustibles(List<Combustible> combustibles)
        {
            _dbContext.BulkInsert(combustibles);
            return combustibles;
        }
    }
}