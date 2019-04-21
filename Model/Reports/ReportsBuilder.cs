using System;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Построитель отчетов
    /// </summary>
    public static class ReportsBuilder
    {
        public static Report GetEmployeeImplementations(Root root, DateTime first, DateTime last)
        {
            var caption = string.Format("Продажи сотрудников за период с {0} по {1}",
                                        first.ToShortDateString(),
                                        last.ToShortDateString());
            var report = new Report
            {
                Caption = caption
            };
            report.ReportColumns.Add("Фамилия, имя и отчество", "Итог");
            // заполнение строк отчёта
            foreach (var groupItem in root.Implementations
                                      .Where(item => item.ImplementationDate.Date >= first.Date && 
                                             item.ImplementationDate.Date <= last.Date)
                                      .OrderBy(item => Helper.EmployeeById(item.IdEmployee)?.ToString())
                                      .GroupBy(item => item.IdEmployee))
            {
                var employee = Helper.EmployeeById(groupItem.Key);
                if (employee == null) continue;
                decimal sum = 0;
                foreach (var implementation in groupItem)
                {
                    var sentence = Helper.SentenceById(implementation.IdSentence);
                    if (sentence == null) continue;
                    sum += sentence.Price;
                }
                report.ReportRows.Add($"{employee}", $"{sum}");
            }
            return report;
        }

        public static Report GetImplementationsByClient(Root root, DateTime first, DateTime last)
        {
            var caption = string.Format("Продажи по клиентам за период с {0} по {1}",
                                        first.ToShortDateString(),
                                        last.ToShortDateString());
            var report = new Report
            {
                Caption = caption
            };
            report.ReportColumns.Add("Фамилия, имя и отчество", "Итог");
            // заполнение строк отчёта
            foreach (var groupItem in root.Implementations
                                      .Where(item => item.ImplementationDate.Date >= first.Date &&
                                             item.ImplementationDate.Date <= last.Date)
                                      .OrderBy(item => Helper.ClientById(item.IdClient)?.ToString())
                                      .GroupBy(item => item.IdClient))
            {
                var client = Helper.ClientById(groupItem.Key);
                if (client == null) continue;
                decimal sum = 0;
                foreach (var implementation in groupItem)
                {
                    var sentence = Helper.SentenceById(implementation.IdSentence);
                    if (sentence == null) continue;
                    sum += sentence.Price;
                }
                report.ReportRows.Add($"{client}", $"{sum}");
            }
            return report;
        }

        public static Report GetPayByEmployees(Root root, DateTime first, DateTime last)
        {
            var caption = string.Format("Выплаты сотрудникам за период с {0} по {1}",
                                        first.ToShortDateString(),
                                        last.ToShortDateString());
            var report = new Report
            {
                Caption = caption
            };
            report.ReportColumns.Add("Фамилия, имя и отчество", "Итог", "Прожажи", "Процент от прожаж");
            // заполнение строк отчёта
            foreach (var groupItem in root.Implementations
                          .Where(item => item.ImplementationDate.Date >= first.Date &&
                                 item.ImplementationDate.Date <= last.Date)
                          .OrderBy(item => Helper.EmployeeById(item.IdEmployee)?.ToString())
                          .GroupBy(item => item.IdEmployee))
            {
                var employee = Helper.EmployeeById(groupItem.Key);
                if (employee == null) continue;
                decimal sum = 0;
                foreach (var implementation in groupItem)
                {
                    var sentence = Helper.SentenceById(implementation.IdSentence);
                    if (sentence == null) continue;
                    sum += sentence.Price;
                }
                var appointment = Helper.AppointmentById(employee.IdAppointment);
                if (appointment == null) continue;
                var value = sum * appointment.SalesPercentage / 100;
                if (value > 0)
                    report.ReportRows.Add($"{employee}", $"{value}", $"{sum}", $"{appointment.SalesPercentage}");
            }
            return report;
        }

        public static Report GetImplementationsByServices(Root root, DateTime first, DateTime last)
        {
            var caption = string.Format("Выручка по ассортименту за период с {0} по {1}",
                                        first.ToShortDateString(),
                                        last.ToShortDateString());
            var report = new Report
            {
                Caption = caption
            };
            report.ReportColumns.Add("Наименование", "Итого");
            // заполнение строк отчёта
            foreach (var service in root.Services)
            {
                decimal sum = 0;
                foreach (var implementation in root.Implementations
                                               .Where(item => item.ImplementationDate.Date >= first.Date &&
                                                              item.ImplementationDate.Date <= last.Date))
                {
                    var sentence = Helper.SentenceById(implementation.IdSentence);
                    if (sentence == null) continue;
                    foreach (var category in root.Categories.FilteredBySentence(sentence.IdSentence)
                                             .Where(item => item.IdService == service.IdService))
                        sum += service.Price * category.Quantity;
                }
                if (sum > 0)
                    report.ReportRows.Add($"{service}", $"{sum}");
            }

            return report;
        }

        public static Report GetImplementationsBySentenceTypes(Root root, DateTime first, DateTime last)
        {
            var caption = string.Format("Продажи по классам предложений за период с {0} по {1}",
                                        first.ToShortDateString(),
                                        last.ToShortDateString());
            var report = new Report
            {
                Caption = caption
            };
            report.ReportColumns.Add("Наименование", "Итог");
            // заполнение строк отчёта
            foreach (var groupItem in root.Implementations
                                      .Where(item => item.ImplementationDate.Date >= first.Date &&
                                             item.ImplementationDate.Date <= last.Date)
                                      .GroupBy(item => Helper.SentenceById(item.IdSentence).IdSentenceType))
            {
                var sentenceTypeName = Helper.SentenceTypeNameById(groupItem.Key);
                decimal sum = 0;
                foreach (var implementation in groupItem)
                {
                    var sentence = Helper.SentenceById(implementation.IdSentence);
                    if (sentence == null) continue;
                    sum += sentence.Price;
                }
                report.ReportRows.Add($"{sentenceTypeName}", $"{sum}");
            }
            return report;
        }

    }
}
