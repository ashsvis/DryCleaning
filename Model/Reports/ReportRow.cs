using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Строки отчета
    /// </summary>
    public class ReportRows :List<ReportRow>
    {
        // добавить строку отчета
        public void Add(params string[] args)
        {
            var row = new ReportRow();
            row.Add(args);
            base.Add(row);
        }
    }

    /// <summary>
    /// Строка отчета
    /// </summary>
    public class ReportRow
    {
        public List<string> Items { get; set; } = new List<string>(); // значения в колонках

        /// <summary>
        /// Добавить значения для колонок строки
        /// </summary>
        /// <param name="args"></param>
        public void Add(params string[] args)
        {
            foreach (var item in args)
                Items.Add(item);
        }
    }
}
