using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebSite.Models;

namespace WebSite.Data
{

    public class DataSeeder
    {

        public static void SeedCountries(ApplicationContext context)
        {

            if (!context.Departments.Any())
            {
                context.Departments.Add(new Departments
                {
                    Name = "Департамент кинематография при Министерстве культуры информации итуризма Кыргызской Республики",
                    Address = "г. Бишкек ул.Логвиненко 13.",
                    Lang = 1,
                    Contacts = "Приемная директора",
                    Director = "Бектеналиев Мукталы Абдыбекович ",
                    Email = "goskinokg@mail.ru",
                    Fax = "+996 312 30 02 65",
                    Phone = "+996 312 30 10 46"
                });

                context.Departments.Add(new Departments
                {
                    Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Кинематография департаменти",
                    Address = "Бишкек ш. Логвиненко көч. 13.",
                    Lang = 2,
                    Contacts = "Мүдүрдүн кабылдамасы",
                    Director = "Бектеналиев Мукталы Абдыбекович ",
                    Email = "goskinokg@mail.ru",
                    Fax = "+996 312  30 02 65",
                    Phone = "+996 312 30 10 46"
                });
                context.Departments.Add(new Departments
                {
                    Name = "Департамент информации и массовых коммуникаций  при Министерстве культуры информации и туризма Кыргызской Республики  ",
                    Address = "г. Бишкек ул.Пушкина 78.",
                    Lang = 1,
                    Contacts = "Приемная директора ",
                    Director = "Сарногоева Салкын Сатаровна  ",
                    Email = "depinfokg@mail.ru",
                    Fax = "+996 312 66 03 32",
                    Phone = "+996 312 66 03 32"
                });
                context.Departments.Add(new Departments
                {
                    Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Маалымат жана массалык коммуникациялар департаменти ",
                    Address = "Бишкек ш. Пушкин көч. 78.",
                    Lang = 2,
                    Contacts = "Мүдүрдүн кабылдамасы",
                    Director = "Сарногоева Салкын Сатаровна  ",
                    Email = "depinfokg@mail.ru",
                    Fax = "+996 312 66 03 32",
                    Phone = "+996 312 66 03 32"
                });
                context.Departments.Add(new Departments
                {
                    Name = "Департамент туризма  при Министерстве культуры информации и туризма Кыргызской Республики  ",
                    Address = "Бишкек, ул. Киевская 96 «б»/",
                    Lang = 1,
                    Contacts = "Приемная директора ",
                    Director = "Максат Дамир уулу   ",
                    Email = "tourism.department@mail.ru",
                    Fax = "+996 312 62 18 61",
                    Phone = "+996 312 62 18 61"
                });
                context.Departments.Add(new Departments
                {
                    Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Туризм департаменти ",
                    Address = "Бишкек ш.  Киев көч. 96 «б».",
                    Lang = 2,
                    Contacts = "Мүдүрдүн кабылдамасы",
                    Director = "Максат Дамир уулу   ",
                    Email = "tourism.department@mail.ru",
                    Fax = "+996 312 62 18 61",
                    Phone = "+996 312 62 18 61"
                });
                context.SaveChanges();
            }

            if (!context.Otdel.Any())
            {
                context.Otdel.Add(new Otdel() { Name = "Центральный аппарат", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Управления сохранения и развития культурного наследия", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Управления развития, культуры, искусства и профессионального образования", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Отдел кадровой и правовой помощи", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Отдел организационной работы, связи с общественностью и делопроизводства", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Отдел международной связи и привлечения инвестиции", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Управления финансов и государственных закупок", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Отдел бухгалтерского учета  и отчетности", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "Сектор внутренного аудита", Lang = 1 });
                context.Otdel.Add(new Otdel() { Name = "", Lang = 1 });
                context.SaveChanges();
            }

            if (!context.Positions.Any())
            {
                context.Positions.Add(new Positions() { Name = "Приемная министра" });
                context.Positions.Add(new Positions() { Name = "Приемная статс-секретаря" });
                context.Positions.Add(new Positions() { Name = "Приемная заместителя министра" });
                context.Positions.Add(new Positions() { Name = "Заместитель министра -директор департамента туризма" });
                context.Positions.Add(new Positions() { Name = "Министр" });
                context.Positions.Add(new Positions() { Name = "Статс-секретарь" });
                context.Positions.Add(new Positions() { Name = "Заместитель министра" });
                context.Positions.Add(new Positions() { Name = "Директор департамента туризма" });
                context.Positions.Add(new Positions() { Name = "Советник министра" });
                context.Positions.Add(new Positions() { Name = "Помощник министра" });
                context.Positions.Add(new Positions() { Name = "Пресс секретарь" });
                context.Positions.Add(new Positions() { Name = "Уполномоченный по вопросам предупреждения коррупции" });
                context.Positions.Add(new Positions() { Name = "Начальник" });
                context.Positions.Add(new Positions() { Name = "Главный специалист" });
                context.Positions.Add(new Positions() { Name = "Ведущий специалист" });
                context.Positions.Add(new Positions() { Name = "Специалист" });
                context.Positions.Add(new Positions() { Name = "И.о.начальника" });
                context.Positions.Add(new Positions() { Name = "И.о. ведущий специалист" });
                context.Positions.Add(new Positions() { Name = "Заведущий" });
                context.Positions.Add(new Positions() { Name = "Бухгалтер" });
                context.Positions.Add(new Positions() { Name = "Кассир" });
                context.Positions.Add(new Positions() { Name = "Заведующий сектором" });

                context.SaveChanges();
            }

            if (!context.OtdelDetali.Any())
            {
                context.OtdelDetali.Add(new OtdelDetali() { Lang = 1, PositionsId = 1, OtdelId = 1, Name = "Жаманкулов А.К.", Phone = "62 04 82" });
                context.OtdelDetali.Add(new OtdelDetali() { Lang = 1, PositionsId = 2, OtdelId = 1, Name = "Секимов Б.Ш.", Phone = "620613" });
                context.OtdelDetali.Add(new OtdelDetali() { Lang = 1, PositionsId = 3, OtdelId = 1, Name = "Иманалиев К.О.", Phone = "622679" });
                context.OtdelDetali.Add(new OtdelDetali() { Lang = 1, PositionsId = 3, OtdelId = 1, Name = "Кадырбеков Н.К.", Phone = "62 60 08" });
                context.OtdelDetali.Add(new OtdelDetali() { Lang = 1, PositionsId = 4, OtdelId = 1, Name = "Максат Дамир уулу", Phone = "621871" });
                context.SaveChanges();
            }

            if (!context.Kollegia.Any())
            {
                context.Kollegia.Add(new Kollegia() { Name = "Жаманкулов Азамат Капарович", Positions = "Министр (входит в состав по должности )", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Секимов Бактыбек Шайыкбекович", Positions = "Статс-секретарь (входят в состав по должности )", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Кадырбеков Нуржигит Кадырбекович", Positions = "Заместитель министра (входят в состав по должности )", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Иманалиев Кайрат Олжобаевич", Positions = "Заместитель министра (входят в состав по должности )", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Дамир уулу Максат", Positions = "Заместитель министра – директор Департамента туризма при МКИТ КР(входят в состав по должности)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Бектеналиев Мукталы Абдыбекович", Positions = "Директор Департамента кинематографии при МКИТ КР (входят в состав по должности)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Сарногоева Салкын Сатаровна", Positions = "Директор Департамента информации и массовых коммуникаций при МКИТ КР (входят в состав по должности)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Джангазиев Айбек Мусаевич", Positions = "Директор Национальной киностудии «Кыргызфильм» им.Толомуша Океева(распоряжением Премьер - министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Алмакучуков Кенешбек Мукашевич", Positions = "Директор Национального исторического музея Кыргызской Республики; (распоряжением Премьер - министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Осмонов Кыргызбай Арапбаевич", Positions = "Генеральный директор Кыргызской национальной филармонии имени Т.Сатылганова; (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Мекешова Назгүл Барктабасовна", Positions = "Эксперт отдела образования, культуры и спорта Аппарата Правительства КР; (распоряжением Премьер - министра) ", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Усубалиев Таалайбек Сыдыманович", Positions = "Председатель Союза художников Кыргызской Республики. (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Бегалиев Муратбек Акимович", Positions = "Народный артист Кыргызской Республики, ректор Кыргызской национальной консерватории им. Калыя Молдобасанова (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Кулмамбетов Жаныш Осмонович", Positions = "Председатель Союза театральных деятелей Кыргызской Республики (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Бакашова Жылдыз Кемеловна", Positions = "Директор Национальной библиотеки Кыргызской Республики им.Алыкула Осмонова (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Акматалиев Абдылдажан Амантурович", Positions = "Академик, директора института языка и литературы имени Чынгыза Айтматова при Национальной академии наук Кыргызской Республики", Lang = 1 });
                context.SaveChanges(); context.Kollegia.Add(new Kollegia() { Name = "Турапова Керимберди Ырысалиевича", Positions = "Народный артист Кыргызской Республики, генерального директора Кыргызского национального академического театра оперы и балета имени Абдыласа Малдыбаева (распоряжением Премьер -министра)", Lang = 1 });
                context.SaveChanges();
            }

            if (!context.ListOfResources.Any())
            {
                context.ListOfResources.Add(new ListOfResources() { Name = "   Президент    Кыргызской Республики", Links = "<a href='http://www.president.kg/ru' target='_blank'>", Lang = 1 });
                context.ListOfResources.Add(new ListOfResources() { Name = "Жогорку Кеңеш Кыргызской Республики", Links = "<a href='http://kenesh.kg/' target='_blank'>", Lang = 1 });
                context.ListOfResources.Add(new ListOfResources() { Name = "Правительство Кыргызской Республики", Links = "<a href='https://www.gov.kg/ky?lang=kg&page_id=27290' target='_blank'>", Lang = 1 });
                context.SaveChanges();
            }

            if (!context.ContactsPodvedPodrz.Any())
            {
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Департамент кинематография при Министерстве культуры информации и туризма Кыргызской Республики ", Address = "г. Бишкек ул.Логвиненко 13.", Director = "Бектеналиев Мукталы Абдыбекович ", Contacts = "Приемная директора", Phone = " +996 312 30 10 46", Fax = "+996 312 30 02 65", Email = "goskinokg@mail.ru", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Департамент информации и массовых коммуникаций  при Министерстве культуры информации и туризма Кыргызской Республики ", Address = "г. Бишкек ул.Пушкина 78.", Director = "Сарногоева Салкын Сатаровна  ", Contacts = "Приемная директора ", Phone = "+996 312 66 03 32", Fax = "+996 312 66 03 32", Email = "depinfokg@mail.ru", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Департамент туризма  при Министерстве культуры информации и туризма Кыргызской Республики  ", Address = "Бишкек, ул. Киевская 96 «б»/", Director = "Максат Дамир уулу   ", Contacts = "Приемная директора ", Phone = "+996 312 62 18 61", Fax = "+996 312 62 18 61", Email = "tourism.department@mail.ru", Lang = 1 });

                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Кинематография департаменти ", Address = "Бишкек ш. Логвиненко көч. 13.", Director = "Бектеналиев Мукталы Абдыбекович ", Contacts = "Мүдүрдүн кабылдамасы", Phone = " +996 312 30 10 46", Fax = "+996 312 30 02 65", Email = "goskinokg@mail.ru", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Маалымат жана массалык коммуникациялар департаменти ", Address = "Бишкек ш. Пушкин көч. 78.", Director = "Сарногоева Салкын Сатаровна  ", Contacts = "Мүдүрдүн кабылдамасы", Phone = "+996 312 66 03 32", Fax = "+996 312 66 03 32", Email = "depinfokg@mail.ru", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Podved", Name = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлигине караштуу Туризм департаменти", Address = "Бишкек ш.  Киев көч. 96 «б».", Director = "Максат Дамир уулу   ", Contacts = "Мүдүрдүн кабылдамасы", Phone = "+996 312 62 18 61", Fax = "+996 312 62 18 61", Email = "tourism.department@mail.ru", Lang = 2 });

                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Жаманкулов Азамат Капарович", Contacts = "Министрдин кабылдамасы", Phone = "+996 312 62 04 82", Address = " ", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Секимов Бактыбек Шайыкбекович", Contacts = "Статс- катчынын кабылдамасы", Phone = "+996 312 62 06 13", Address = " ", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Иманалиев Кайрат Олжобаевич", Contacts = "Министрдин орун басарынын кабылдамасы", Phone = "+996 312 62 60 08", Address = " ", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Кадырбеков Нуржигит Кадырбекович", Contacts = "Министрдин орун басарынын кабылдамасы", Phone = "+996 312 62 26 79", Address = " ", Lang = 2 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Максат Дамир уулу", Contacts = "Министрдин орун басары, Туризм департаментинин директорунун кабылдамасы", Phone = "+996 312 62 18 71", Address = " ", Lang = 2 });

                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Жаманкулов Азамат Капарович", Contacts = "Приемная министра", Phone = "+996 312 62 04 82", Address = " ", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Секимов Бактыбек Шайыкбекович", Contacts = "Приемная статс-секретаря", Phone = "+996 312 62 06 13", Address = " ", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Иманалиев Кайрат Олжобаевич", Contacts = "Приемная заместителя министра", Phone = "+996 312 62 60 08", Address = " ", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Кадырбеков Нуржигит Кадырбекович", Contacts = "Приемная заместителя министра", Phone = "+996 312 62 26 79", Address = " ", Lang = 1 });
                context.ContactsPodvedPodrz.Add(new ContactsPodvedPodrz() { Desc = "Rukovodstvo", Name = "Ruk", Director = "Максат Дамир уулу", Contacts = "Заместитель  министра - директор департамента туризма", Phone = "+996 312 62 18 71", Address = " ", Lang = 1 });

                context.SaveChanges();
            }

            if (!context.Resume.Any())
            {
                context.Resume.Add(new Resume()
                {
                    Name = "Министр",
                    LastName = "ЖАМАНКУЛОВ",
                    FirstName = "АЗАМАТ",
                    PatronomicName = "КАПАРОВИЧ",
                    BirthDay = new DateTime(1987, 09, 27),
                    BirthPlace = "Талас облусу, Бакай - Ата району",
                    Citizen = "Кыргыз Республикасы",
                    Education= "жогорку",
                    Languages= "кыргыз, казак, орус, түрк, англис",
                    Nation= "кыргыз",
                    Lang = 2
                }); 
                context.Resume.Add(new Resume()
                {
                    Name = "Министр",
                    LastName = "ЖАМАНКУЛОВ",
                    FirstName = "АЗАМАТ",
                    PatronomicName = "КАПАРОВИЧ",
                    BirthDay = new DateTime(1987, 09, 27),
                    BirthPlace = "Бакай- Атинский район ,Таласской области",
                    Citizen = "Кыргызской Республики",
                    Education = "высшее",
                    Nation = "кыргыз",
                    Languages = "кыргызский, казахский, турецкий  русский, английский ",
                    Lang = 1
                });
                context.Resume.Add(new Resume()
                {
                    Name = "МИНИСТРДИН ОРУН БАСАРЫ",
                    LastName = "ИМАНАЛИЕВ",
                    FirstName = "КАЙРАТ",
                    PatronomicName = "ОЛЖОБАЕВИЧ",
                    BirthDay = new DateTime(1977, 11, 29),
                    BirthPlace = "Ысык-Көл облусу, Ысык-Көл району",
                    Citizen = "Кыргыз Республикасы",
                    Education = "жогорку",
                    Languages = "кыргыз, казак, орус, түрк",
                    Nation = "кыргыз",
                    Lang = 2
                });
                context.Resume.Add(new Resume()
                {
                    Name = "МИНИСТРДИН ОРУН БАСАРЫ",
                    LastName = "ИМАНАЛИЕВ",
                    FirstName = "КАЙРАТ",
                    PatronomicName = "ОЛЖОБАЕВИЧ",
                    BirthDay = new DateTime(1977, 11, 29),
                    BirthPlace = "Иссык-Кульская область, Иссык-Кульский район, с. Темир",
                    Citizen = "Кыргызской Республики",
                    Education = "высшее",
                    Languages = "кыргызский, казахсий русский, турецкий ",
                    Nation = "кыргыз",
                    Lang = 2
                });
                context.SaveChanges();
            };

            if (!context.EducationList.Any())
            {
                context.EducationList.Add(new EducationList()
                {
                    Lang=2, ResumeId=1, Years=2008, Name="Кыргыз–Түрк “Манас” университети", Spesialnost= "Мекемедеги менеджмент"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 2,
                    ResumeId = 1,
                    Years = 2011,
                    Name = "Кыргызстан эл аралык университетин",
                    Spesialnost = "Финансы"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 1,
                    ResumeId = 2,
                    Years = 2008,
                    Name = "Кыргызско-Турецкий  Университет « Манас» ",
                    Spesialnost = "Менеджмент в организации"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 1,
                    ResumeId = 2,
                    Years = 2011,
                    Name = "Международный Университет Кыргызстана ",
                    Spesialnost = "Финансы"
                });

                context.EducationList.Add(new EducationList()
                {
                    Lang = 2,
                    ResumeId = 3,
                    Years = 2008,
                    Name = "Кыргыз мамлекеттик улуттук университети",
                    Spesialnost = "магистратурасы"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 2,
                    ResumeId = 3,
                    Years = 2008,
                    Name = "Кыргыз мамлекеттик улуттук университети",
                    Spesialnost = "журналистика факультети"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 2,
                    ResumeId = 1,
                    Years = 2011,
                    Name = "Кыргызстан эл аралык университетин",
                    Spesialnost = "Финансы"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 1,
                    ResumeId = 2,
                    Years = 2008,
                    Name = "Кыргызско-Турецкий  Университет « Манас» ",
                    Spesialnost = "Менеджмент в организации"
                });
                context.EducationList.Add(new EducationList()
                {
                    Lang = 1,
                    ResumeId = 2,
                    Years = 2011,
                    Name = "Международный Университет Кыргызстана ",
                    Spesialnost = "Финансы"
                });
                context.SaveChanges();
            };

            if (!context.WorkList.Any())
            {
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2011-2013-ж.ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "“Риэлт Партнер” жоопкерчилиги чектелген коому ",
                    Positions = "Аткаруучу директор"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2013-2014-ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = " “Кристалл” Ачык акционердик коому Таш-Көмүр ш.",
                    Positions = "Инвестицияларды тартуу боюнча адис- экономист"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014-ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "Биринчи Дүйнөлүк көчмөндөр оюндарынын катчылыгы",
                    Positions = "Жетекчинин орун басары"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014-ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "“Дүйнөлүк этно оюндар” коомдук фонду",
                    Positions = "Вице- президент"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014-2015-ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "Кыргызстан курортторунун асоциациясы",
                    Positions = "Вице-президент"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2015-ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "Экинчи Дүйнөлүк көчмөндөр оюндарынын катчылыгы",
                    Positions = "Жетекчи"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2015-2018-ж.ж.",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлиги Туризм департаменти",
                    Positions = "Министрдин орун басары- Туризм департаментинин директору"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2018 –ж.Учурда",
                    ResumeId = 1,
                    Lang = 2,
                    OrgName = "Кыргыз Республикасынын Маданият, маалымат жана туризм министрлиги",
                    Positions = "Министр"
                });

                context.WorkList.Add(new WorkList()
                {
                    Termine= "2011-2013г.г.",
                    ResumeId=2,
                    Lang=1,
                    OrgName= "ОсОО «Риэлт Партнер»",
                    Positions= "Исполнительный директор"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2013-2014 г.г.",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "ОАО «Кристалл» г. Таш - Кумыр",
                    Positions = "Специалист по привлечению инвестиций - экономист "
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014 г.",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "Секретариат по подготовке и проведению Первых Всемирных Игр Кочевников",
                    Positions = "Заместитель руководителя"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014 г.",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "ОФ «Всемирные Этно Игры»",
                    Positions = "Вице- президент"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2014-2015 г.г. ",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "Ассоциация курортов Кыргызстана",
                    Positions = "Исполнительный директор "
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2015 г.",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "Секретариат по подготовке и проведению Вторых Всемирных Игр Кочевников",
                    Positions = "Руководитель"
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2015-2018 г.г.",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "Министерство культуры, информации и туризма КР, Департамент туризма ",
                    Positions = "Заместитель министра культуры, информации и туризма КР, Директор департамента туризма "
                });
                context.WorkList.Add(new WorkList()
                {
                    Termine = "2018 г. по настоящее время",
                    ResumeId = 2,
                    Lang = 1,
                    OrgName = "Министерство культуры, информации и туризма КР",
                    Positions = "Министр"
                });


                context.SaveChanges();
            };

            if (!context.MyzeiCategory.Any())
            {
                context.MyzeiCategory.Add(new MyzeiCategory() { Lang = 1, Name = "Музеи республиканского значения" });
                context.MyzeiCategory.Add(new MyzeiCategory() { Lang = 1, Name = "Городские музеи " });
                context.MyzeiCategory.Add(new MyzeiCategory() { Lang = 1, Name = "Областные музеи " });
                context.MyzeiCategory.Add(new MyzeiCategory() { Lang = 1, Name = "Районные музеи" });
                context.MyzeiCategory.Add(new MyzeiCategory() { Lang = 1, Name = "Сельские музеи" });               
                context.SaveChanges();
            }
            if (!context.Myzei.Any())
            {
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Кыргызский национальный исторический музей", God= "106073" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Кыргызский национальный музей изобразительных искусств им.Г.Айтиева", God = "18048" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Кыргызский государственный мемориальный дом-музей М.В.Фрунзе", God = "13338" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Республиканский археолого-архитектурный музей-комплекс башня «Бурана»", God = "4889" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Национальный историко-мемориальный комплекс Ата-Бейит", God = "30" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Национальный историко-археологический музейный комплекс  «Сулайман-Тоо»", God = "32097" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Кыргызский национальный комплекс «Манас  Ордо»", God = "858" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Центр кочевой цивилизации «Курманжан Датка»", God = "968" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 1, Name = "Государственный историко-культурный музей-запаведник «Шах-Фазиль»", God = "20" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Мемориальный дом-музей О.Мануйловой г.Бишкек", God = "1438" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Мемориальный дом-музей А.Токонбаева г.Бишкек", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Мемориальный дом-музей И.Раззакова г.Бишкек", God = "860" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Мемориальный дом-музей С.Чуйкова г.Бишкек", God = "969" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Музей литературы и искусства Т.Сатылганова г.Бишкек", God = "4899" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Музей скульптуры под открытым небом г. Бишкек", God = "90" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Зоологический музей г.Бишкек", God = "более 5 тысячи минералов" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Геологический музей г.Бишкек", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Историко-краеведческий музей города Токмок", God = "7049" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Историко-краеведческий музей города Каракол", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Историко-краеведческий музей города Балыкчы", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "К.Карасаева-Н.М.Пржевальский музейно-мемориальный комплекс  города Каракол", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Джалал-Абадский государственный краевический музей", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Кызыл-Кийский городской историко-краеведческий музей", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Историко-краеведческий музей  города Сулюкта", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Историко-краеведческий музей города Исфана", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 2, Name = "Музей  «Слава» им.С.Садыкова города Исфана", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 3, Name = "Ошский музей изобразительных искусств", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 3, Name = "Ыссык-Кульский государственный историко-культурный музей-заповедник", God = "12357" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 3, Name = "Нарынский областной историко-этнографический музей", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Мемориальный дом-музей Суракан Кайназаровой  Сокулукского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Мемориальный  музей  Алыкула Осмонова Панфиловского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Историко-этнографический музей Курманджан Датка  Алайского района", God = "2097" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Историко-этнографический музей Ноокатского района", God = "973" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Музей колхоза «Россия»  (филиал Сулайман-Тоо) Ноокатского района", God = "2601" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Мемориальный музей имени У.Салиева (филиал Сулайман-Тоо) Ноокатского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Историко-краеведческий музей  Ак-Суйский района", God = "1356" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Историко-краеведческий музей имени Калена Жетимишбаева Жети-Огузского района", God = "5396" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Фольклерно-этнографический музей  имени  А.  Усонбаева Манаского района", God = "1540" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Ак- Таалинский районный исторический музей ", God = "2969" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Джумгальский районный историко-этнографический музей ", God = "5432" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Кочкорский районный историко-краеведческий музей ", God = "2849" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Ноокенский историко-этнографический музей им. А. Кулумбетова", God = "1234" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Кадамжайский районный музей имени Абдыкадыра Орозбекова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Лейлекский районный музейный комплекс", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Ала-Букинский районный историко-этнографический  музей", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Ноокенский районный историко-этнографический музей им. А.Кулумбетова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Аксыйский районный историко-этнографический музей имени Женижок", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Историко-этнографический музей Тогуз-Тороуского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Мемориальный дом-музей Т.Сатылганова Токтогульского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Музей Жоомарта Боконбаева  Токтогульского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Музей Коргол  Досу уулу  Токтогульского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 4, Name = "Музей  Абды Суеркулова Токтогульского района", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Исторический музей Кулатов", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Сельский музей Зулпуев", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Мемориальный музей А.Осмонова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Историко-краеведческий музей Ш.Баатыра", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Историко-краеведческий музей К.Жетимишбаева с.Оргочор", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Музей “Историко”", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Музей Боевой славы", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Музей изобразительного искусства им.Т.Герцена  с.Ак-Добо", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Мемориальный музей им.Ч.Тулебердиева с.Чолпонбай", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "музей им.Ч.Айтматова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Музей им.Куйручук", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Музей им. Мидин Алыбаев", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Исторический музей им.Алыш Койчуманова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Историко-краеведческий музей с.Казарман", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Дом музей им. Барпы Алыкулова", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Дом музей имени Токубай Тайгараев", God = "" });
                context.Myzei.Add(new Myzei() { Lang = 1, MyzeiCategoryId = 5, Name = "Исторический музей с.Кулунду", God = "" });
                context.SaveChanges();
                foreach (var item in context.Myzei.ToList())
                {
                    item.FactYear = "2019";
                    context.SaveChanges();
                }
            }

            if (!context.MyzeiZdanie.Any())
            {
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Национальный исторический музей КР", Profil = "исторический", Oblast = "г.Бишкек", TipZdania = "бывший филиал Центрального музея В.И. Ленина" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей изобразительного искусства им.Г.Айтиева", Profil = "изобразительного искусства", Oblast = "г.Бишкек", TipZdania = "индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей М.В. Фрунзе", Profil = "мемориальный", Oblast = "г.Бишкек", TipZdania = "индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Токмокский музей", Profil = "Историко-краеведческий", Oblast = "г. Токмок", TipZdania = "индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Балыкчынский музей", Profil = "Историко-краеведческий", Oblast = "г.Балыкчы (Иссык-Кульская область)", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Нарынский областной музей", Profil = "Историко-этнографический", Oblast = "Нарынская область", TipZdania = "индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Акталинский районный музей", Profil = "исторический", Oblast = "Нарынская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Кочкорский музей", Profil = "Историко-краеведческий", Oblast = "Нарынская область", TipZdania = "Типовое реконструированное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Джумгальский музей", Profil = "Историко-этнографический", Oblast = "Нарынскаяобласть", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Джалал-Абадский музей", Profil = "Историко-краеведческий ", Oblast = "Джалал-Абадская область", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей А.Суеркулова", Profil = "мемориальный", Oblast = "Джалал-Абадская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей Ж.Боконбаева", Profil = "мемориальный", Oblast = "Джалал-Абадская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "КорголДосулуу музей", Profil = "литературный", Oblast = "Джалал-Абадская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей Т.Сатылганова", Profil = "исторический", Oblast = "Джалал-Абадская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей А.Орозбекова", Profil = "мемориальный", Oblast = "Баткенская область", TipZdania = "реконструированное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей с.Кулунду", Profil = "исторический", Oblast = "Баткенская область", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей г.Сулюкта", Profil = "исторический", Oblast = "Баткенская область", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей им.Кулатова", Profil = "исторический", Oblast = "Ошская область ", TipZdania = "Реконструированноеприспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей им.Раззакова", Profil = "Мемориально-исторический", Oblast = "Баткенская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей «Славы» им.С.Садыкова", Profil = "мемориальный", Oblast = "Баткенская область", TipZdania = "приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Ляйлякский  районный музей ", Profil = "исторический", Oblast = "Баткенская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Сельский музей им.Т.Герцена", Profil = "изобразительного искусства", Oblast = "Таласская область", TipZdania = "Типовой проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Мемориальный комплекс «Ата-Бейит»", Profil = "мемориальный", Oblast = "Чуйская область", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музейно-мемориальный комплекс К.Карасаева и Н.П. Пржевальского", Profil = "мемориальный", Oblast = "Иссык-Кульская область", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей литературы и искусства им. Т.Сатылганова", Profil = "мемориальный   ", Oblast = "г.Бишкек", TipZdania = "Типовой  проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей А.Токомбаева", Profil = "мемориальный", Oblast = "г.Бишкек", TipZdania = "Типовой  проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей И.Раззакова", Profil = "мемориальный ", Oblast = "г.Бишкек", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Государственный музей им.Ч.Тулебердиева", Profil = "мемориальный", Oblast = "Таласская область", TipZdania = "реконструированное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей им.Усенбаева", Profil = "этнографический", Oblast = "Таласская область", TipZdania = "Типовой  проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Национальный историко-археологический комплекс «Сулейман-Тоо»", Profil = "исторический", Oblast = "Ошская область", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Культурно-национальный комплекс «Манас-Ордо»", Profil = "", Oblast = "Таласская область", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Музей-мастерская С.Чокморова", Profil = "мемориальный", Oblast = "г.Бишкек", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Джити-огузский районный музей им.К. Джетимишбаева", Profil = "исторический", Oblast = "Иссык-Кульская область", TipZdania = "Типовой  проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом – музей С. Кайназаровой", Profil = "мемориальный", Oblast = "Чуйская область", TipZdania = "Приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей С.А. Чуйкова", Profil = "мемориальный", Oblast = "г.Бишкек", TipZdania = "Приспособленное" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Центр кочевой цивилизации им.Курманжан Датка", Profil = "исторический", Oblast = "с.Чок Тал", TipZdania = "Индивидуальный проект" });
                context.MyzeiZdanie.Add(new MyzeiZdanie() { Lang = 1, Name = "Дом-музей О.М. Мануйловой", Profil = "мемориальный", Oblast = "г.Бишкек", TipZdania = "Типовой  проект" });
                context.SaveChanges();
            }
                /*
               if (!context.DictCountry.Any())
               {
                   var resourceName = "AisMKIT.Data.Countries.xml";
                   var assembly = Assembly.GetExecutingAssembly();
                   var stream = assembly.GetManifestResourceStream(resourceName);
                   var xml = XDocument.Load(stream);
                   var countries = xml.Element("countries")
                                   .Elements("country")
                                   .Select(x => new DictCountry
                                   {
                                       Name = (string)x.Element("name"),
                                       FullName = (string)x.Element("fullname"),
                                       Alpha2 = (string)x.Element("alpha2"),
                                       Alpha3 = (string)x.Element("alpha3"),
                                       English = (string)x.Element("english"),
                                       ISO = (string)x.Element("iso"),
                                       Location = (string)x.Element("location"),
                                       LocationPrecise = (string)x.Element("location-precise"),
                                   }).ToArray();
                   context.DictCountry.AddRange(countries); // AddOrUpdate(c => c.Name, countries);

                   context.SaveChanges();
               }
    */

            }
        }
}
