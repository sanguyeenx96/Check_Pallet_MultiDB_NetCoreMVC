using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pdc.Models;
using pdc.Models.L1231;
using pdc.Models.Lichsu;
using pdc.Models.T527;
using pdc.Models.T541;
using pdc.Models.T543;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace pdc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly L1231Context _l1231Context;
        private readonly T527Context _t527Context;
        private readonly T541Context _t541Context;
        private readonly T543Context _t543Context;
        private readonly CheckPalletPDCContext _checkPalletPDCContext;

        public HomeController(ILogger<HomeController> logger, L1231Context l1231Context,
            T527Context t527Context, T541Context t541Context, T543Context t543Context,
            CheckPalletPDCContext checkPalletPDCContext)
        {
            _logger = logger;
            _l1231Context = l1231Context;
            _t527Context = t527Context;
            _t541Context = t541Context;
            _t543Context = t543Context;
            _checkPalletPDCContext = checkPalletPDCContext;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public IActionResult Login(string manv, string matkhau)
        {
            if (!String.IsNullOrEmpty(manv) && !String.IsNullOrEmpty(matkhau))
            {
                User checklogin = _checkPalletPDCContext.Users.Where(x => (x.Manv == manv && x.Password == matkhau)).FirstOrDefault();
                if (checklogin != null)
                {
                    ISession session = HttpContext.Session;

                    session.SetString("user", checklogin.Hoten);
                    var hoten = session.GetString("user");

                    return RedirectToAction("Index");
                }
                else
                {
                    StatusMessage = "Sai mã nhân viên hoặc mật khẩu!";
                }
            }
            return View();
        }

        public IActionResult Index(string thitruong, string sopallet)
        {
            ISession session = HttpContext.Session;
            var hoten = session.GetString("user");

            if (hoten == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                if (!String.IsNullOrEmpty(thitruong) && !String.IsNullOrEmpty(sopallet))
                {
                    TempData["thitruong"] = thitruong;
                    TempData["sopallet"] = sopallet;
                    return RedirectToAction("Xuly");
                }
            }

            return View();
        }

        public IActionResult Xuly()
        {
            if (TempData["thitruong"] != null && TempData["sopallet"] != null)
            {
                string thitruong = TempData["thitruong"].ToString();
                string sopallet = TempData["sopallet"].ToString();
                var truyvan = _checkPalletPDCContext.Dulieuthitruongs.Where(x => thitruong.Contains(x.Mechandide)).FirstOrDefault();
                string tenmodel = truyvan.Model.ToString();
                string tenthitruong = truyvan.Mechandide.ToString();
                List<danhsachbody> danhsach = new List<danhsachbody>();
                if (tenmodel == "L1231")
                {
                    var list = _l1231Context.JisekiFs.Where(x => (x.JisDaio == thitruong && x.JisPlno == sopallet)).ToList();
                    foreach (var i in list)
                    {
                        danhsachbody data = new danhsachbody();
                        //data.model = tenmodel;
                        //data.merchandide = tenthitruong;
                        //data.numberpallet = sopallet;
                        data.bodydb = i.JisSile;
                        danhsach.Add(data);
                    }
                    ViewBag.ds = danhsach;
                    ViewBag.tenmodel = tenmodel;
                }
                if (tenmodel == "T527")
                {
                    var list = _t527Context.JisekiFs.Where(x => (x.JisDaio == thitruong && x.JisPlno == sopallet)).ToList();
                    foreach (var i in list)
                    {
                        danhsachbody data = new danhsachbody();
                        //data.model = tenmodel;
                        //data.merchandide = tenthitruong;
                        //data.numberpallet = sopallet;
                        data.bodydb = i.JisSile;
                        danhsach.Add(data);
                    }
                    ViewBag.ds = danhsach;
                    ViewBag.tenmodel = tenmodel;
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult luu([FromBody] List<danhsachbody> inputList, Lichsu _lichsu)
        {
            foreach (var data in inputList)
            {
                string db = data.bodydb;
                string check = data.bodycheck;

                Lichsu dulieu = new Lichsu();
                //if (!String.IsNullOrEmpty(_lichsu.Bodyno))
                //{
                //    dulieu.Bodyno = _lichsu.Bodyno.Trim();
                //}
                dulieu.Bodyno = check;
                dulieu.Datecheck = DateTime.Now;
                _checkPalletPDCContext.Add(dulieu);
                _checkPalletPDCContext.SaveChanges();
            }
            return Json(new { success = true });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}