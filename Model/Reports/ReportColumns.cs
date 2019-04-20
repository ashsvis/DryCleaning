using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Колонки (заголовки) отчета
    /// </summary>
    public class ReportColumns : List<string>
    {
        /// <summary>
        /// Добавить заголовки
        /// </summary>
        /// <param name="args"></param>
        public void Add(params string[] args)
        {
            foreach (var item in args)
                base.Add(item);
        }
    }
}
