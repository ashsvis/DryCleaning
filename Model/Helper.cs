using System;
using System.Linq;

namespace Model
{
    public enum TextCase
    {
        Nominative/*Кто? Что?*/,
        Genitive/*Кого? Чего?*/,
        Dative/*Кому? Чему?*/,
        Accusative/*Кого? Что?*/,
        Instrumental/*Кем? Чем?*/,
        Prepositional/*О ком? О чём?*/
    };

    public static class Helper
    {
        private static Root _root;

        public static void DefineRoot(Root root)
        {
            _root = root;
        }

        public static string SentenceTypeNameById(Guid idSentenceType)
        {
            var sentenceType = _root.SentenceTypes.FirstOrDefault(item => item.IdSentenceType == idSentenceType);
            return sentenceType != null ? sentenceType.ToString() : idSentenceType.ToString();
        }

        public static string AppointmentNameById(Guid idAppointment)
        {
            var appointment = _root.Appointments.FirstOrDefault(item => item.IdAppointment == idAppointment);
            return appointment != null ? appointment.ToString() : idAppointment.ToString();
        }

        public static string GenderNameById(Guid idGender)
        {
            var gender = _root.Genders.FirstOrDefault(item => item.IdGender == idGender);
            return gender != null ? gender.ToString() : idGender.ToString();
        }

        public static string ServiceNameById(Guid idService)
        {
            var service = _root.Services.FirstOrDefault(item => item.IdService == idService);
            return service != null ? service.ToString() : idService.ToString();
        }

        public static string SentenceNameById(Guid idSentence)
        {
            var sentence = _root.Sentences.FirstOrDefault(item => item.IdSentence == idSentence);
            return sentence != null ? sentence.ToString() : idSentence.ToString();
        }

        public static Client ClientById(Guid idClient)
        {
            return _root.Clients.FirstOrDefault(item => item.IdClient == idClient);
        }

        public static Employee EmployeeById(Guid idEmployee)
        {
            return _root.Employees.FirstOrDefault(item => item.IdEmployee == idEmployee);
        }

        public static Sentence SentenceById(Guid idSentence)
        {
            return _root.Sentences.FirstOrDefault(item => item.IdSentence == idSentence);
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

        public static string CurrencyToTxt(double _amount, bool _firstCapital)
        {
            long rublesAmount = (long)Math.Floor(_amount);
            long copecksAmount = ((long)Math.Round(_amount * 100)) % 100;
            int lastRublesDigit = lastDigit(rublesAmount);
            int lastCopecksDigit = lastDigit(copecksAmount);

            string s = NumeralsToTxt(rublesAmount, TextCase.Nominative, true, _firstCapital) + " ";

            if (IsPluralGenitive(lastRublesDigit))
                s += rubles[3] + " ";
            else if (IsSingularGenitive(lastRublesDigit))
                s += rubles[2] + " ";
            else
                s += rubles[1] + " ";

            s += String.Format("{0:00} ", copecksAmount);

            if (IsPluralGenitive(lastCopecksDigit))
                s += copecks[3] + " ";
            else if (IsSingularGenitive(lastCopecksDigit))
                s += copecks[2] + " ";
            else
                s += copecks[1] + " ";

            return s.Trim();
        }

        static string[] rubles =
        {
            "", "рубль", "рубля", "рублей"
        };

        static string[] copecks =
        {
            "", "копейка", "копейки", "копеек"
        };

        static string[] from3till19 =
        {
            "", "три", "четыре", "пять", "шесть",
            "семь", "восемь", "девять", "десять", "одиннадцать",
            "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
            "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
        };

        static string[] from3till19Genetive =
        {
            "", "трех", "четырех", "пяти", "шести",
            "семи", "восеми", "девяти", "десяти", "одиннадцати",
            "двенадцати", "тринадцати", "четырнадцати", "пятнадцати",
            "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати"
        };

        static string[] tens =
        {
            "", "двадцать", "тридцать", "сорок", "пятьдесят",
            "шестьдесят", "семьдесят", "восемьдесят", "девяносто"
        };

        static string[] tensGenetive =
        {
            "", "двадцати", "тридцати", "сорока", "пятидесяти",
            "шестидесяти", "семидесяти", "восьмидесяти", "девяноста"
        };

        static string[] hundreds =
        {
            "", "сто", "двести", "триста", "четыреста",
            "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"
        };

        static string[] hundredsGenetive =
        {
            "", "ста", "двухсот", "трехсот", "четырехсот",
            "пятисот", "шестисот", "семисот", "восемисот", "девятисот"
        };

        static string[] thousands =
        {
            "", "тысяча", "тысячи", "тысяч"
        };

        static string[] thousandsAccusative =
        {
            "", "тысячу", "тысячи", "тысяч"
        };

        static string[] millions =
        {
            "", "миллион", "миллиона", "миллионов"
        };

        static string[] billions =
        {
            "", "миллиард", "миллиарда", "миллиардов"
        };

        static string[] trillions =
        {
            "", "трилион", "трилиона", "триллионов"
        };

        static string zero = "ноль";
        static string firstMale = "один";
        static string firstFemale = "одна";
        static string firstFemaleAccusative = "одну";
        static string firstMaleGenetive = "одно";
        static string secondMale = "два";
        static string secondFemale = "две";
        static string secondMaleGenetive = "двух";
        static string secondFemaleGenetive = "двух";

        public static string NumeralsToTxt(long _sourceNumber, TextCase _case, bool _isMale, bool _firstCapital)
        {
            string s = "";
            long number = _sourceNumber;
            int remainder;
            int power = 0;

            if ((number >= (long)Math.Pow(10, 15)) || number < 0)
            {
                return "";
            }

            while (number > 0)
            {
                remainder = (int)(number % 1000);
                number = number / 1000;

                switch (power)
                {
                    case 12:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, trillions) + s;
                        break;
                    case 9:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, billions) + s;
                        break;
                    case 6:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, millions) + s;
                        break;
                    case 3:
                        switch (_case)
                        {
                            case TextCase.Accusative:
                                s = MakeText(remainder, hundreds, tens, from3till19, secondFemale, firstFemaleAccusative, thousandsAccusative) + s;
                                break;
                            default:
                                s = MakeText(remainder, hundreds, tens, from3till19, secondFemale, firstFemale, thousands) + s;
                                break;
                        }
                        break;
                    default:
                        string[] powerArray = { };
                        switch (_case)
                        {
                            case TextCase.Genitive:
                                s = MakeText(remainder, hundredsGenetive, tensGenetive, from3till19Genetive, 
                                             _isMale ? secondMaleGenetive : secondFemaleGenetive, 
                                             _isMale ? firstMaleGenetive : firstFemale, powerArray) + s;
                                break;
                            case TextCase.Accusative:
                                s = MakeText(remainder, hundreds, tens, from3till19, 
                                             _isMale ? secondMale : secondFemale, 
                                             _isMale ? firstMale : firstFemaleAccusative, powerArray) + s;
                                break;
                            default:
                                s = MakeText(remainder, hundreds, tens, from3till19, 
                                             _isMale ? secondMale : secondFemale, 
                                             _isMale ? firstMale : firstFemale, powerArray) + s;
                                break;
                        }
                        break;
                }
                power += 3;
            }
            if (_sourceNumber == 0)
                s = zero + " ";
            if (s != "" && _firstCapital)
                s = s.Substring(0, 1).ToUpper() + s.Substring(1);
            return s.Trim();
        }

        static string MakeText(int _digits, string[] _hundreds, string[] _tens, string[] _from3till19, 
                               string _second, string _first, string[] _power)
        {
            string s = "";
            int digits = _digits;

            if (digits >= 100)
            {
                s += _hundreds[digits / 100] + " ";
                digits = digits % 100;
            }
            if (digits >= 20)
            {
                s += _tens[digits / 10 - 1] + " ";
                digits = digits % 10;
            }
            if (digits >= 3)
                s += _from3till19[digits - 2] + " ";
            else if (digits == 2)
                s += _second + " ";
            else if (digits == 1)
                s += _first + " ";

            if (_digits != 0 && _power.Length > 0)
            {
                digits = lastDigit(_digits);
                if (IsPluralGenitive(digits))
                    s += _power[3] + " ";
                else if (IsSingularGenitive(digits))
                    s += _power[2] + " ";
                else
                    s += _power[1] + " ";
            }
            return s;
        }

        static bool IsPluralGenitive(int _digits)
        {
            if (_digits >= 5 || _digits == 0)
                return true;
            return false;
        }

        static bool IsSingularGenitive(int _digits)
        {
            if (_digits >= 2 && _digits <= 4)
                return true;
            return false;
        }

        static int lastDigit(long _amount)
        {
            long amount = _amount;
            if (amount >= 100)
                amount = amount % 100;
            if (amount >= 20)
                amount = amount % 10;
            return (int)amount;
        }

    }
}
