using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using ResultadoExcel.Models;
using ResultadoExcel.Service;

namespace ResultadoExcel.Controllers
{
    public class CombustiblesController : Controller
    {
        ICombustibleService _combustibleService = null;
        List<Combustible> _combustibles = new List<Combustible>();


        public CombustiblesController(ICombustibleService ENE_CombustibleService)
        {
            _combustibleService = ENE_CombustibleService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SaveCombustibles (List<Combustible> ENE_Combustible)
        {
            _combustibles = _combustibleService.SaveCombustibles(ENE_Combustible);
            return Json(_combustibles);
        }

        public string GenerateAndDownloadExcel (int IdCombustible, string combustible)
        {
            List<Combustible> ENE_Combustibles = _combustibleService.GetCombustibles();
            var datatable = CommonMethods.ConvertListToDataTable(ENE_Combustibles);
            datatable.Columns.Remove("Id_Combustible");

            byte[] fileContents = null;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Excel");
                ws.Cells["A1"].Value = "Modelo Archivo Plano Ventas Teseo";
                ws.Cells["A1"].Style.Font.Bold = true;
                ws.Cells["A1"].Style.Font.Size = 16;
                ws.Cells["A1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A2"].Value = "Lista";
                ws.Cells["A2"].Style.Font.Bold = true;
                ws.Cells["A2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:C3"].Style.Font.Bold = true;
                ws.Cells["A3:C3"].Style.Font.Size = 12;
                ws.Cells["A3:C3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:C3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:C3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:D3"].Style.Font.Bold = true;
                ws.Cells["A3:D3"].Style.Font.Size = 12;
                ws.Cells["A3:D3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:D3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:D3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:E3"].Style.Font.Bold = true;
                ws.Cells["A3:E3"].Style.Font.Size = 12;
                ws.Cells["A3:E3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:E3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:E3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:E3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:F3"].Style.Font.Bold = true;
                ws.Cells["A3:F3"].Style.Font.Size = 12;
                ws.Cells["A3:F3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:F3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:F3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:F3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:G3"].Style.Font.Bold = true;
                ws.Cells["A3:G3"].Style.Font.Size = 12;
                ws.Cells["A3:G3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:G3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:G3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:G3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:H3"].Style.Font.Bold = true;
                ws.Cells["A3:H3"].Style.Font.Size = 12;
                ws.Cells["A3:H3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:H3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:H3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:H3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:I3"].Style.Font.Bold = true;
                ws.Cells["A3:I3"].Style.Font.Size = 12;
                ws.Cells["A3:I3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:I3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:I3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:I3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:J3"].Style.Font.Bold = true;
                ws.Cells["A3:J3"].Style.Font.Size = 12;
                ws.Cells["A3:J3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:J3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:D3"].Style.Font.Bold = true;
                ws.Cells["A3:D3"].Style.Font.Size = 12;
                ws.Cells["A3:D3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:D3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:D3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:K3"].Style.Font.Bold = true;
                ws.Cells["A3:K3"].Style.Font.Size = 12;
                ws.Cells["A3:K3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:K3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:K3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:K3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:L3"].Style.Font.Bold = true;
                ws.Cells["A3:L3"].Style.Font.Size = 12;
                ws.Cells["A3:L3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:L3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:L3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:L3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:M3"].Style.Font.Bold = true;
                ws.Cells["A3:M3"].Style.Font.Size = 12;
                ws.Cells["A3:M3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:M3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:M3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:M3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(datatable, true);
                ws.Cells["A3:N3"].Style.Font.Bold = true;
                ws.Cells["A3:N3"].Style.Font.Size = 12;
                ws.Cells["A3:N3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:N3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:N3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:N3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                pck.Save();
                fileContents = pck.GetAsByteArray();
            }
            return Convert.ToBase64String(fileContents);
        }
    }
}

