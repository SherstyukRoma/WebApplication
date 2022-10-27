using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            if(Repository.Services.Count() == 0)
            {
                Repository.AddService(new Service() { 
                    Id = 1, 
                    Title = "Ветеринарная клиника",
                    ImgSrc = "/images/icon/care.png",
                    ImgAlt = "Ветеринарные услуги",
                    Description = "Цель нашей работы – здоровье Ваших любимцев! Мы готовы предоставить высококвалифицированную помощь в любую минуту, 7 дней в неделю, 24 часа в сутки. У нас есть все необходимое, чтоб в максимально короткие сроки провести комплексное аппаратное и лабораторное обследование питомца, ведь чем раньше поставлен диагноз, тем эффективнее будет лечение.УЗИ(в том числе и сложные обследования сердца), " +
                                        "цифровая рентгенография, электрокардиография, офтальмо - и отоскопия(обследование ушей животного), гибкая эндоскопия, лабораторные исследования, включая высокоточные экспресс - тесты на инфекционные заболевания. Наши врачи – это эксперты, пециализирующиеся во всех отраслях ветеринарии. "
                });
                Repository.AddService(new Service()
                {
                    Id = 2,
                    Title = "Дневной лагерь для домашних животных",
                    ImgSrc = "/images/icon/camp.png",
                    ImgAlt = "Дневной лагерь с домашними животными",
                    Description = "Цель нашей работы – кгуглосуточный присмотр за домашними животными"
                });
                Repository.AddService(new Service()
                {
                    Id = 3,
                    Title = "Питание домаших животных",
                    ImgSrc = "/images/icon/nutrition.png",
                    ImgAlt = "Питание домаших животных",
                    Description = "Что лучше, сухой корм или собственноручно приготовленная еда? Почему нельзя кормить питомца «человеческой» едой? Как выкормить совсем маленького щенка или котенка? Ответы на эти вопросы вы найдете здесь. Кроме того, вы узнаете, какие последствия может иметь неправильное питание – это поможет вам избежать ошибок и неприятностей, а также подарить вашим любимцам хорошее здоровье и отличное самочувствие."
                });
                Repository.AddService(new Service()
                {
                    Id = 4,
                    Title = "Страхование домашних животных",
                    ImgSrc = "/images/icon/insurance.png",
                    ImgAlt = "Страхование домашних животных",
                    Description = "С помощью страхования домашнего животного Вы можете застраховаться от расходов, сопряженных с заболеванием вашего питомца, его кражей или другим неожиданным несчастным случаем."
                });
            }
        }

        [HttpPost]
        public JsonResult GetAllServices()
        {
            return Json(Repository.Services);
        }

        public IActionResult Index()
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
