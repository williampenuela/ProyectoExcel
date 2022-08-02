using ResultadoExcel.Models;

namespace ResultadoExcel.Service
{
    public interface IENE_CombustibleService
    {
        List<ENE_Combustible> GetCombustibles();
        List<ENE_Combustible> SaveCombustibles(List<ENE_Combustible>ENE_Combustible);
    }
}
