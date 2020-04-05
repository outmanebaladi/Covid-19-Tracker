using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Immutable;

namespace Covid_19_Tracker.Web.Mappers.ExcelExport
{
    public static class ExcelExportExtensions
    {
        public static void AjouterSuivi(this ExcelPackage excelPackage, ImmutableList<ExcelSuivi> suivis)
        {
            if(suivis == null)
            {
                throw new ArgumentException("Il faut utiliser des suivis non vides");
            }
            var casSuivi = suivis[0].NomPrenom;
            var sheet2 = excelPackage.Workbook.Worksheets.Add(casSuivi);

            sheet2.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet2.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet2.Cells["A4:A5"].Merge = true;
            sheet2.Cells["A4"].Value = "N°";

            sheet2.Cells["B4:B5"].Merge = true;
            sheet2.Cells["B4"].Value = "NOM ET PRENOM";

            sheet2.Cells["C4:C5"].Merge = true;
            sheet2.Cells["C4"].Value = "Date";

            const string Matin = "Matin";
            const string Soir = "Soir";

            sheet2.Cells["D4:E4"].Merge = true;
            sheet2.Cells["D4"].Value = "Temp. °C";
            sheet2.Cells["D5"].Value = Matin;
            sheet2.Cells["E5"].Value = Soir;

            sheet2.Cells["F4:G4"].Merge = true;
            sheet2.Cells["F4"].Value = "Toux";
            sheet2.Cells["F5"].Value = Matin;
            sheet2.Cells["G5"].Value = Soir;

            sheet2.Cells["H4:I4"].Merge = true;
            sheet2.Cells["H4"].Value = "Dyspnée";
            sheet2.Cells["H5"].Value = Matin;
            sheet2.Cells["I5"].Value = Soir;

            sheet2.Cells["J4:K4"].Merge = true;
            sheet2.Cells["J4"].Value = "Mal de Gorge";
            sheet2.Cells["J5"].Value = Matin;
            sheet2.Cells["K5"].Value = Soir;

            sheet2.Cells["L4:M4"].Merge = true;
            sheet2.Cells["L4"].Value = "Céphalée";
            sheet2.Cells["L5"].Value = Matin;
            sheet2.Cells["M5"].Value = Soir;

            sheet2.Cells["N4:O4"].Merge = true;
            sheet2.Cells["N4"].Value = "Myalgie";
            sheet2.Cells["N5"].Value = Matin;
            sheet2.Cells["O5"].Value = Soir;

            sheet2.Cells["P4:Q4"].Merge = true;
            sheet2.Cells["P4"].Value = "Autres";
            sheet2.Cells["P5"].Value = Matin;
            sheet2.Cells["Q5"].Value = Soir;

            sheet2.Cells["R4:S4"].Merge = true;
            sheet2.Cells["R4"].Value = "Conclusion";
            sheet2.Cells["R5"].Value = Matin;
            sheet2.Cells["S5"].Value = Soir;

            // load Order objects into the worksheet
            sheet2.Cells["A6"].LoadFromCollection(suivis, PrintHeaders: false, TableStyle: OfficeOpenXml.Table.TableStyles.Custom);
            // autofit columns to get the correct width
            sheet2.Cells[6, 1, sheet2.Dimension.End.Row, sheet2.Dimension.End.Column].AutoFitColumns();
            // set style
            sheet2.Cells[6, 1, sheet2.Dimension.End.Row, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet2.Cells[7, 3, sheet2.Dimension.End.Row, 3].Style.Numberformat.Format = "yyyy-mm-dd";
        }
    }
}
