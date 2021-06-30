using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Client
{
    class ExportExcel
    {
        Workbook workBook;
        Worksheet workSheet;

        public ExportExcel(string path, int sheet)
        {
            _Excel.Application excel = new _Excel.Application();
            workBook = excel.Workbooks.Open(path);
            workSheet = workBook.Worksheets[sheet];
        }

        public void Write(int row, int col, string word, string meaning)
        {
            workSheet.Cells[row, col].Value2 = row;
            workSheet.Cells[row, col + 1].Value2 = word;
            workSheet.Cells[row, col + 3].Value2 = meaning;
            workBook.Save();
            workBook.Close();
        }
    }
}
