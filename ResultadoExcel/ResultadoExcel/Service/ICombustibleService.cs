using ResultadoExcel.Models;

namespace ResultadoExcel.Service
{
    public interface ICombustibleService
    {
        List<Combustible> GetCombustibles();
        List<Combustible> SaveCombustibles(List<Combustible> combustibles);
    }
}
