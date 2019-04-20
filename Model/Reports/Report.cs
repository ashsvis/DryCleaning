using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Отчёт 
    /// </summary>
    public class Report
    {
        public string Caption { get; set; } = string.Empty; // заголовок отчета
        public ReportColumns ReportColumns { get; set; } = new ReportColumns(); // колонки отчета
        public ReportRows ReportRows { get; set; } = new ReportRows(); // строки отчета

        /// <summary>
        /// Инициализация
        /// </summary>
        public void Clear()
        {
            Caption = string.Empty;
            ReportColumns.Clear();
            ReportRows.Clear();
        }
    }
}
