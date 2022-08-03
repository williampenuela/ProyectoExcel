using System.ComponentModel.DataAnnotations;

namespace ResultadoExcel.Models
{
    public class Combustible
    {
        [Key]
        public int Id_Combustible { get; set; } = 0;
        public string Cod_Movil { get; set; } = "";
        public string Km_Actual { get; set; } = "";
        public string Cantidad_Suministro { get; set; } = "";
        public int Odometro_Dañado { get; set; } = 0;
        public string? Evidencia { get; set; } = "";
        public int Usuario_Creacion { get; set; } = 0;
        public DateTime Fecha_Creacion { get; set; }
        public Boolean Estado { get; set; }
        public int Id_Surtidor { get; set; } = 0;
        public int Estado_Tapa { get; set; } = 0;
        public int Id_Apertura { get; set; } = 0;
        public int? Id_EDS_Pendiente_Actualizacion { get; set; } = 0;
        public int? Usuario_Insercion { get; set; }=0;
        public int? Id_Eds_Tipo_Insercion { get; set; }= 0;

    }
}
