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
    }
}
