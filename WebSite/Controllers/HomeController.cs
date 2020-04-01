using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _appEnvironment;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context,IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public IActionResult SetLang(int id)
        {
            // UriBuilder uriBuilder = new UriBuilder(Request.UrlReferrer);
            //NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);
            //query.Add("myparam", "something");
            //uriBuilder.Query = query.ToString();
            //return new RedirectResult(Request.UrlReferrer.ToString());
            // return new RedirectResult(uriBuilder.Uri);
            if (id == 0) id = 1;
            HttpContext.Session.SetString("lang", id.ToString());
            string referer = Request.Headers["Referer"].ToString();
            return new RedirectResult(referer);
        }
        public IActionResult Index(int id)
        {
            if (id == 0) id = 1;
            HttpContext.Session.SetString("lang", id.ToString());
            return View(_context.ListOfResources.OrderByDescending(x => x.Id).ToList());
            
        }

        #region Ministerstvo

        //Структура
        public IActionResult Structure()
        {
            //int lang = int.Parse(HttpContext.Session.GetString("lang"));
            //return View(_context.Departments.Where(x => x.Lang == lang).ToList());
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }


        //История образования министерства
        public IActionResult History()
        {
            return View();
        }
        //Регламент
        public IActionResult Reglament()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Руководство
        public IActionResult Executives()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Министр
        public IActionResult Ministr()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }
        public IActionResult Stat()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Коллегия
        public IActionResult Kollegia()
        {
            return View(_context.Kollegia.OrderBy(x=>x.Id).ToList());
        }

        //Общественно-наблюдательный совет
        public IActionResult ObshestvenoNabSovet()
        {
            return View();
        }

        //Акты, регулирующие деятельность Министерства
        public IActionResult Documents()
        {
            return View();
        }

        //Полезные ссылки
        public IActionResult ListOfResources()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;

            return View(_context.ListOfResources.OrderByDescending(x=>x.Id).ToList());
        }
        //Dostoyanie
        public IActionResult Dostoyanie()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Theme = "Достояние республики";
            return View(_context.ListOfResources.OrderBy(x => x.Id).ToList());
        }

        public IActionResult Dostoyanie1()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Theme = "Достояние республики";
            return View(_context.ListOfResources.OrderBy(x => x.Id).ToList());
        }

        public IActionResult Dostoyanie2()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Theme = "Список всемирного наследия ЮНЕСКО";
            return View(_context.ListOfResources.OrderBy(x => x.Id).ToList());
        }

        public IActionResult Dostoyanie3()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Theme = "Памятники истории/культуры";
            return View(_context.ListOfResources.OrderBy(x => x.Id).ToList());
        }

        public IActionResult RabCult()
        {
            return View();
        }

        #endregion

        #region Grajdanam
        //Общественный прием
        public IActionResult PriemCitizen()
        {
            return View();
        }

        //Телефон доверия
        public IActionResult TelefonDoveria()
        {
            return View();
        }

        //Обращение граждан
        public IActionResult AppealsOfCitizens()
        {
            ViewBag.Result = "";
            return View();
        }

        //График приема граждан
        public IActionResult GraphicOfCitizens()
        {
            ViewBag.Result = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AppealsOfCitizens(Obrashenie model)
        {
            ViewBag.Result = "Не удалось отправить!";
            if (ModelState.IsValid)
            {
                //Test20@0 obshieotdel@list.ru
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                _context.Obrashenie.Add(model);
                _context.SaveChanges();
                 ViewBag.Result = "Сообщение отправлено в общий отдел";
                MailAddress to = new MailAddress(model.Email);
                MailAddress from = new MailAddress("bmirbek@gmail.ru");
                MailMessage message = new MailMessage(from, to);
                message.Subject = model.Theme;
                message.Body = @model.Message;
                SmtpClient client = new SmtpClient("smtp.mail.ru");
                client.Port = 25;
                client.Host = "smtp.mail.ru";
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("obshieotdel@list.ru", "Test20@0");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                await client.SendMailAsync(message);

            } 
             return View();
        }

        #endregion

        #region Deyatelnost

        //Международное сотрудничество
        public IActionResult International()
        {
            return View();
        }

        //Нематириальное культурное наследие
        public IActionResult NKN()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Нематириальное культурное наследие
        public IActionResult NKNPolojenie()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Нематириальное культурное наследие
        public IActionResult NKNPolojenie2()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //ИСТОРИКО КУЛЬТУРНОЕ НАСЛЕДИЕ
        public IActionResult PageIKN()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Антикоррупционные мероприятия
        public IActionResult Anticorrypt()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Образование
        public IActionResult Education()
        {
            return View();
        }


        //Развитие профессионально искусства
        public IActionResult RazvitieProfObraz()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }


        //Музейное дело
        public IActionResult MyzeiIndex()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Музейное дело
        public IActionResult MyzeinoeDelo()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            //ViewBag.Resp = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId==1).ToList();
            //ViewBag.Gorod = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 2).ToList();
            //ViewBag.Oblast = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 3).ToList();
            //ViewBag.Raion = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 4).ToList();
            //ViewBag.Selo = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 5).ToList();
            //ViewBag.Zdanie=_context.MyzeiZdanie.Where(x => x.Lang == lang).ToList();
            return View();
        }

        //Музейный фонд
        public IActionResult MyzeinyiFond()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Resp = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 1).ToList();
            ViewBag.Gorod = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 2).ToList();
            ViewBag.Oblast = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 3).ToList();
            ViewBag.Raion = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 4).ToList();
            ViewBag.Selo = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 5).ToList();
            ViewBag.Zdanie = _context.MyzeiZdanie.Where(x => x.Lang == lang).ToList();
            return View();
        }

        //Характер зданий, в которых расположены музеи
        public IActionResult MyzeinyeZdanie()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            ViewBag.Resp = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 1).ToList();
            ViewBag.Gorod = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 2).ToList();
            ViewBag.Oblast = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 3).ToList();
            ViewBag.Raion = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 4).ToList();
            ViewBag.Selo = _context.Myzei.Where(x => x.Lang == lang & x.MyzeiCategoryId == 5).ToList();
            ViewBag.Zdanie = _context.MyzeiZdanie.Where(x => x.Lang == lang).ToList();
            return View();
        }

        //Туризм
        public IActionResult Turizm()
        {
            return View();
        }

        //Туризм
        public IActionResult TurizmODep()
        {
            return View();
        }
        //Туризм
        public IActionResult TurizmHozSub()
        {
            return View();
        }
        //Туризм
        public IActionResult TurizmReestr()
        {
            return View();
        }
        //Туризм
        public IActionResult TurizmPerechen()
        {
            return View();
        }

        //Ремесло
        public IActionResult Remeslo()
        {
            return View();
        }

        //Ремесло
        public IActionResult RemesloMissia()
        {
            return View();
        }
        //Ремесло
        public IActionResult RemesloDeyatelnost()
        {
            return View();
        }
        //Ремесло
        public IActionResult RemesloPerechen()
        {
            return View();
        }

        //Информационная политика
        public IActionResult InfPolitika()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Кинематография
        public IActionResult Kinomotography()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }
        //Кинематография
        public IActionResult KinomotographyFond()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }
        //Кинематография
        public IActionResult KinomotographyDireksia()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }
        //Кинематография
        public IActionResult KinomotographyPerechen()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Кинематография
        public IActionResult KinomotographyKinoStudia()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Кинематография
        public IActionResult KinomotographyKinoDireksii()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Кинематография
        public IActionResult KinomotographyDepart()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }


        #endregion

        #region Sobytia

        //Фотогалерия
        public IActionResult PhotoGalery()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.lang = lang;
            return View();
        }

        //Фотогалерия
        public IActionResult Gallery()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.lang = lang;
            ViewBag.Theme = "Церемония открытие Перекрестного года Кыргызстана и России";
            return View();
        }
        
        #endregion

        #region Contacts
        //Руководство контакты
        public IActionResult ExecutivesContacts()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        //Контакты
        public IActionResult Contacts()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.lang = lang;
            return View();
        }

        //контакты подвед
        public IActionResult ContactsPodved()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View(_context.ContactsPodvedPodrz.Where(x => x.Lang == lang & x.Name!= "Ruk").ToList());
        }
        public VirtualFileResult ContactsSA()
        {

            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            // Путь к файлу
            //string file_path = Path.Combine(_appEnvironment.ContentRootPath, "wwwroot/docs/contacts/ConactSARus.pdf");
            var filepath = Path.Combine("~/docs/contacts", "ConactSARus.pdf");
            if (lang != 1) filepath = Path.Combine("~/docs/contacts", "ConactSAKyrg.pdf");
            //file_path = Path.Combine(_appEnvironment.ContentRootPath, "wwwroot/docs/contacts/ConactSAKyrg.pdf");
            // Тип файла - content-type
            string file_type = "application/pdf";
            // Имя файла - необязательно
            string file_name = "book.pdf";
            //return PhysicalFile(file_path, file_type, file_name);
            return File(filepath, "text/plain", "Центральный.pdf");
        }

        //Подведомственные учреждения
        public IActionResult SubordinatedInstitutions()
        {
            return View();
        }



        #endregion

        #region Footer

        //Вакансии
        public IActionResult JobsList()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();
        }

        public IActionResult Job(int id=0)
        {

            return View();                
        }
            //Карта сайте
            public IActionResult SiteMap()
        {
            int lang = 1;
            if (HttpContext.Session.GetString("lang") != null)
            {
                lang = int.Parse(HttpContext.Session.GetString("lang"));
            }
            ViewBag.Lang = lang;
            return View();

        }

        #endregion
        public IActionResult Test()
        {
            ViewBag.Tst = "<h2>Заголовок</h2>";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
