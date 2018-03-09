﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraCompleta.Controllers {
   public class HomeController : Controller {


      // GET: Home
      [HttpGet]  // esta anotação é facultativa, pois, por defeito, é isto que acontece
      public ActionResult Index() {
         // inicializar o valor do visor
         ViewBag.Visor = 0;
         return View();
      }

      // POST: Home
      [HttpPost]
      public ActionResult Index(string bt, string visor) {

      // identificar o valor da variável 'bt'
      switch (bt){
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
               if(visor.Equals("0")) visor = bt;
               else visor += bt;
                              break;
            
         }

         // enviar resposta para o cliente
         ViewBag.Visor = visor;


         return View();
      }


   }
}