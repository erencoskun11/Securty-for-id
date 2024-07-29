using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Class2
    {
        private string tckimlikno;

        public string _tckimlikno
        {
            get
            {
                if (tckimlikno.Length == 11)
                {
                    return tckimlikno.Substring(0, 4); // İlk 4 karakteri döndür
                }
                else
                {
                    return "Geçersiz";
                }
            }
            set
            {
                bool control = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!char.IsNumber(value[i]))
                        {
                            control = true;
                            break;
                        }
                    }

                    if (control)
                    {
                        Console.WriteLine("Lütfen geçerli bir TC kimlik numarası giriniz.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC kimlik numarası 11 haneli değildir.");
                }
            }
        }
    }

}

