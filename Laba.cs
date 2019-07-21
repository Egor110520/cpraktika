using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Human> dictionary_human = new Dictionary<int, Human>();
            int cod = 0;
            bool q = true;
            while (q)
            {
                Console.WriteLine("Здравствуйте!");
                Console.WriteLine("Вы вошли в меню телефонной книжки.");
                Console.WriteLine("1. Создать новую запись.");
                Console.WriteLine("2. Редактировать запись.");
                Console.WriteLine("3. Удалить запись.");
                Console.WriteLine("4. Просмотр созданных записей.");
                Console.WriteLine("5. Просмотр всех созданных записей с краткой информацией: фамилия, имя и номер телефона.");
                Console.WriteLine("6. Выход.");
                Console.WriteLine();
                int sw_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (sw_1)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите  имя, фамилию, отчество, страну, дату рождения, номер телефона,  организацию, должность и прочие заметки.");
                            dictionary_human[cod] = new Human(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), long.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                            cod++;
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите cod записи, которую вы хотите отредактировать");
                            Console.WriteLine();
                            int k = 0;
                            foreach (Human in_dictionary in dictionary_human.Values)
                            {
                                Console.WriteLine("Запись c cod " + k + ":");
                                Console.WriteLine("Фамилия: " + in_dictionary.surname);
                                Console.WriteLine("Имя: " + in_dictionary.name);
                                Console.WriteLine("Отчество: " + in_dictionary.patronymic);
                                Console.WriteLine("Номер телефона: " + in_dictionary.telephone_Number);
                                Console.WriteLine("Страна: " + in_dictionary.country);
                                Console.WriteLine("Дата рождения: " + in_dictionary.birthday);
                                Console.WriteLine("Организация: " + in_dictionary.institution);
                                Console.WriteLine("Должность: " + in_dictionary.position);
                                Console.WriteLine("Прочие заметки: " + in_dictionary.notes);
                                Console.WriteLine();
                                k++;
                            }
                            k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            bool redact = true;
                            while (redact)
                            {
                                Console.WriteLine("1. Изменить имя.");
                                Console.WriteLine("2. Изменить фамилию.");
                                Console.WriteLine("3. Изменить отчество.");
                                Console.WriteLine("4. Изменить страну.");
                                Console.WriteLine("5. Изменить дату рождения.");
                                Console.WriteLine("6. Изменить номер телефона.");
                                Console.WriteLine("7. Изменить организацию.");
                                Console.WriteLine("8. Изменить должность.");
                                Console.WriteLine("9. Изменить прочие заметки.");
                                Console.WriteLine("10. Вернуться в главное меню и продолжить");
                                Console.WriteLine();
                                int sw_2 = Convert.ToInt32(Console.ReadLine());
                                switch (sw_2)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите имя");
                                            dictionary_human.ElementAt(k).Value.name = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите фамилию");
                                            dictionary_human.ElementAt(k).Value.surname = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите отчество");
                                            dictionary_human.ElementAt(k).Value.patronymic = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите страну");
                                            dictionary_human.ElementAt(k).Value.country = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите дату рождения");
                                            dictionary_human.ElementAt(k).Value.birthday = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите номер телефона");
                                            dictionary_human.ElementAt(k).Value.telephone_Number = long.Parse(Console.ReadLine());
                                            Console.Clear();
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите организацию");
                                            dictionary_human.ElementAt(k).Value.institution = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите должность");
                                            dictionary_human.ElementAt(k).Value.position = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введите заметки");
                                            dictionary_human.ElementAt(k).Value.notes = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case 10:
                                        {
                                            Console.Clear();
                                            redact = false;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите cod записи, которую вы хотите удалить");
                            Console.WriteLine();
                            int k = 0;
                            foreach (Human in_dictionary in dictionary_human.Values)
                            {
                                Console.WriteLine("Запись c cod " + k + ":");
                                Console.WriteLine("ФИО: " + in_dictionary.surname + " " + in_dictionary.name + " " + in_dictionary.patronymic);
                                Console.WriteLine("Номер телефона: " + in_dictionary.telephone_Number);
                                Console.WriteLine("Страна: " + in_dictionary.country);
                                Console.WriteLine("Дата рождения: " + in_dictionary.birthday);
                                Console.WriteLine("Организация: " + in_dictionary.institution);
                                Console.WriteLine("Должность: " + in_dictionary.position);
                                Console.WriteLine("Прочие заметки: " + in_dictionary.notes);
                                Console.WriteLine();
                                k++;
                            }
                            k = Convert.ToInt32(Console.ReadLine());
                            dictionary_human.Remove(k);
                            Console.WriteLine();
                            Console.WriteLine("Удалено. Чтобы продолжить, нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            int k = 0;
                            Console.Clear();
                            Console.WriteLine("Все ваши записи:");
                            Console.WriteLine();
                            foreach (Human in_dictionary in dictionary_human.Values)
                            {
                                Console.WriteLine("Запись c cod " + k + ":");
                                Console.WriteLine("Фамилия: " + in_dictionary.surname);
                                Console.WriteLine("Имя: " + in_dictionary.name);
                                Console.WriteLine("Номер телефона: " + in_dictionary.telephone_Number);
                                Console.WriteLine();
                                k++;
                            }
                            Console.WriteLine("Введите cod записи, которую вы хотите просмотреть");
                            k = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Запись с cod " + k + ":");
                            Console.WriteLine();
                            Console.WriteLine("ФИО: " + dictionary_human.ElementAt(k).Value.surname + " " + dictionary_human.ElementAt(k).Value.name + " " + dictionary_human.ElementAt(k).Value.patronymic);
                            Console.WriteLine("Номер телефона: " + dictionary_human.ElementAt(k).Value.telephone_Number);
                            Console.WriteLine("Страна: " + dictionary_human.ElementAt(k).Value.country);
                            Console.WriteLine("Дата рождения: " + dictionary_human.ElementAt(k).Value.birthday);
                            Console.WriteLine("Организация: " + dictionary_human.ElementAt(k).Value.institution);
                            Console.WriteLine("Должность: " + dictionary_human.ElementAt(k).Value.position);
                            Console.WriteLine("Прочие заметки: " + dictionary_human.ElementAt(k).Value.notes);
                            Console.WriteLine();
                            Console.WriteLine("Чтобы продолжить, нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Все ваши записи:");
                            Console.WriteLine();
                            foreach (Human in_dictionary in dictionary_human.Values)
                            {
                                Console.WriteLine("Фамилия: " + in_dictionary.surname);
                                Console.WriteLine("Имя: " + in_dictionary.name);
                                Console.WriteLine("Номер телефона: " + in_dictionary.telephone_Number);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Чтобы продолжить, нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            q = false;
                            break;

                        }
                }
            }
        }
    }
}

class Human
{
    public string institution, name, surname, notes, position, country, patronymic, birthday;
    public long telephone_Number;

    public Human(string name, string surname, string patronymic, string country, string birthday, long telephone_Number, string institution, string position, string notes)
    {
        this.name = name; this.surname = surname; this.telephone_Number = telephone_Number; this.birthday = birthday; this.country = country; this.notes = notes; this.position = position; this.institution = institution; this.patronymic = patronymic;
    }
}