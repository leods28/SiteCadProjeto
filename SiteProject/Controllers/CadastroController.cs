using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteProject.Controllers
{
    public class CadastroController : Controller
    {
        public static List<Models.Dados_Supermercado> _listaSupermercado = new List<Models.Dados_Supermercado>()
        {
            new Models.Dados_Supermercado() {rsocial="Eee", nomefant="Shopx", CNPJ="222456-10"}
        };

        [Authorize]
        public ActionResult CadSupermercado()
        {
            return View();
        }

        public static List<Models.Dados_Restaurante> _listaRestaurante = new List<Models.Dados_Restaurante>()
        {
            new Models.Dados_Restaurante() {rsocial="ABAB", nomefant="Foods", CNPJ="123456-10"}
        };

        [Authorize]
        public ActionResult CadRestaurante()
        {
            return View();
        }

        public static List<Models.Dados_Borracharia> _listaBorracharia = new List<Models.Dados_Borracharia>()
        {
            new Models.Dados_Borracharia() {rsocial="ABC", nomefant="Borracharia do Zé", CNPJ="123456-10"}
        };

        [Authorize]
        public ActionResult CadBorracharia()
        {
            return View(_listaBorracharia);
        }

        public static List<Models.Dados_Posto> _listaPosto = new List<Models.Dados_Posto>()
        {
            new Models.Dados_Posto() {rsocial="Fuel", nomefant="MaxFuel", CNPJ="343456-10"}
        };

        [Authorize]

        public ActionResult CadPosto()
        {
            return View();
        }

        public static List<Models.Dados_Oficina> _listaOficina = new List<Models.Dados_Oficina>()
        {
            new Models.Dados_Oficina() {rsocial="AAA", nomefant="Oficina do João", CNPJ="223456-10"}
        };

        [Authorize]
        public ActionResult CadOficina()
        {
            return View();
        }
    }
}