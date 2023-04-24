using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForeignPassport Passport = new ForeignPassport();
            Passport.Input();
            Console.WriteLine(Passport);
        }

        class ForeignPassport
        {
            private string Name_;
            private string Surname_;
            private string Patronymic_;
            private string DateofBirth_;
            private int[] IdCode_ = new int[16];
            public ForeignPassport()
            {
                Random rand = new Random();
                for (int i = 0; i < 16; i++)
                {
                    IdCode_[i] = rand.Next() % 9;
                }
                Name_ = "";
                Surname_ = "";
                Patronymic_ = "";
                DateofBirth_ = "";
            }
            public void Input()
            {
                try
                {
                    Console.Write("\nEnter Name: ");
                    Name_ = Console.ReadLine();
                    if (string.IsNullOrEmpty(Name_))
                    {
                        throw new Exception("Empty String");
                    }
                    Console.Write("\nEnter Surname: ");
                    Surname_ = Console.ReadLine();
                    if (string.IsNullOrEmpty(Surname_))
                    {
                        throw new Exception("Empty String");
                    }
                    Console.Write("\nEnter Patronymic: ");
                    Patronymic_ = Console.ReadLine();
                    if (string.IsNullOrEmpty(Patronymic_))
                    {
                        throw new Exception("Empty String");
                    }
                    Console.Write("\nEnter Date of Birth: ");
                    DateofBirth_ = Console.ReadLine();
                    if (string.IsNullOrEmpty(DateofBirth_))
                    {
                        throw new Exception("Empty String");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Input();
                }
            }
            public override string ToString()
            {
                return string.Format
                (
                    $"\nName: {Name_}" +
                    $"\nSurname: {Surname_}" +
                    $"\nPatronymic: {Patronymic_}" +
                    $"\nDate Of Birth: {DateofBirth_}" + 
                    $"\nId Code: {String.Join("", IdCode_.Select(p => p.ToString()).ToArray())}"
                    ) ;
            }
        }
    }
}
