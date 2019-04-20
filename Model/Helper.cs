using System;
using System.Linq;

namespace Model
{
    public static class Helper
    {
        private static Root _root;

        public static void DefineRoot(Root root)
        {
            _root = root;
        }

        public static string AppointmentById(Guid idAppointment)
        {
            var appointment = _root.Appointments.FirstOrDefault(item => item.IdAppointment == idAppointment);
            return appointment != null ? appointment.ToString() : idAppointment.ToString();
        }

        public static string GenderById(Guid idGender)
        {
            var gender = _root.Genders.FirstOrDefault(item => item.IdGender == idGender);
            return gender != null ? gender.ToString() : idGender.ToString();
        }

        public static string ServiceById(Guid idService)
        {
            var service = _root.Services.FirstOrDefault(item => item.IdService == idService);
            return service != null ? service.ToString() : idService.ToString();
        }

        public static string SentenceById(Guid idSentence)
        {
            var sentence = _root.Sentences.FirstOrDefault(item => item.IdSentence == idSentence);
            return sentence != null ? sentence.ToString() : idSentence.ToString();
        }

        public static decimal CalculateSentencePrice(Sentence sentence)
        {
            decimal summ = 0;
            foreach (var category in _root.Categories.FilteredBySentence(sentence.IdSentence))
            {
                var quantity = category.Quantity;
                var service = _root.Services.FirstOrDefault(item => item.IdService == category.IdService);
                if (service == null) continue;
                summ += quantity * service.Price;
            }
            return summ;
        }
    }
}
