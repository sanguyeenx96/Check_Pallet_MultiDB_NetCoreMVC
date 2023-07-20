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

        public async Task<IActionResult> Login(string manv, string matkhau)
        {
            if (!String.IsNullOrEmpty(manv) && !String.IsNullOrEmpty(matkhau))
            {
                User checklogin = await _checkPalletPDCContext.Users.Where(x => (x.Manv == manv && x.Password == matkhau)).FirstOrDefaultAsync();
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
            if (hoten == "Administrator")
            {
                return RedirectToAction("Thongketrongngay", "Lichsus");
            }
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
                else
                {
                    StatusMessage = "Phải nhập đầy đủ thông tin!";
                }
            }
            int dupmode = _checkPalletPDCContext.AdminSettings.Where(x => x.Mode == "duplicate").ToList().Select(x => x.Value).FirstOrDefault();
            session.SetInt32("dupmode", dupmode);

            return View();
        }

        public async Task<IActionResult> Xuly()
        {
            int dupmode = _checkPalletPDCContext.AdminSettings.Where(x => x.Mode == "duplicate").ToList().Select(x => x.Value).FirstOrDefault();

            if (TempData["thitruong"] != null && TempData["sopallet"] != null)
            {
                string thitruong = TempData["thitruong"].ToString();
                string sopallet = TempData["sopallet"].ToString();

                var truyvan = await _checkPalletPDCContext.Dulieuthitruongs.Where(x => thitruong.Contains(x.Mechandide)).FirstOrDefaultAsync();
                if (truyvan != null)
                {
                    int checktrungpallet = _checkPalletPDCContext.Lichsus.Where(x => sopallet.Contains(x.Mapallet)).Count();
                    if (dupmode == 0) //off tat chuc nang
                    {
                        if (checktrungpallet > 0)
                        {
                            StatusMessage = "Pallet này đã có dữ liệu kiểm tra! Thay đổi cài đặt để bật chức năng kiểm tra lại!";
                            return RedirectToAction("Index");
                        }
                    }
                    if (dupmode == 1) //on bat chuc nang
                    {
                        if (checktrungpallet > 0)
                        {
                            ViewBag.trangthaichecklai = "Kiểm tra lại pallet";
                        }
                    }
                    string tenmodel = truyvan.Model.ToString();
                    string tenthitruong = truyvan.Mechandide.ToString();
                    List<danhsachbody> danhsach = new List<danhsachbody>();
                    if (tenmodel == "L1231")
                    {
                        var list = await _l1231Context.JisekiFs.Where(x => (thitruong.Contains(x.JisDaio) && sopallet.Contains(x.JisPlno))).ToListAsync();
                        if (list.Count() > 0)
                        {
                            foreach (var i in list)
                            {
                                danhsachbody data = new danhsachbody();
                                data.bodydb = i.JisSile;
                                danhsach.Add(data);
                            }
                            ViewBag.ds = danhsach;
                            ViewBag.tenmodel = tenmodel;
                            string thitruong_hienthi = list.Select(x => x.JisDaio).FirstOrDefault();
                            ViewBag.thitruong_hienthi = thitruong_hienthi;
                            string mapallet_hienthi = list.Select(x => x.JisPlno).FirstOrDefault();
                            ViewBag.mapallet_hienthi = mapallet_hienthi;
                        }
                        else
                        {
                            StatusMessage = "Không có dữ liệu của pallet này trong database!";
                            return RedirectToAction("Index");
                        }
                    }
                    if (tenmodel == "T527")
                    {
                        var list = await _t527Context.JisekiFs.Where(x => (thitruong.Contains(x.JisDaio) && sopallet.Contains(x.JisPlno))).ToListAsync();
                        if (list.Count() > 0)
                        {
                            foreach (var i in list)
                            {
                                danhsachbody data = new danhsachbody();
                                data.bodydb = i.JisSile;
                                danhsach.Add(data);
                            }
                            ViewBag.ds = danhsach;
                            ViewBag.tenmodel = tenmodel;
                            string thitruong_hienthi = list.Select(x => x.JisDaio).FirstOrDefault();
                            ViewBag.thitruong_hienthi = thitruong_hienthi;
                            string mapallet_hienthi = list.Select(x => x.JisPlno).FirstOrDefault();
                            ViewBag.mapallet_hienthi = mapallet_hienthi;
                        }
                        else
                        {
                            StatusMessage = "Không có dữ liệu của pallet này trong database!";
                            return RedirectToAction("Index");
                        }
                    }
                    if (tenmodel == "T541")
                    {
                        var list = await _t541Context.JisekiFs.Where(x => (thitruong.Contains(x.JisDaio) && sopallet.Contains(x.JisPlno))).ToListAsync();
                        if (list.Count() > 0)
                        {
                            foreach (var i in list)
                            {
                                danhsachbody data = new danhsachbody();
                                data.bodydb = i.JisSile;
                                danhsach.Add(data);
                            }
                            ViewBag.ds = danhsach;
                            ViewBag.tenmodel = tenmodel;
                            string thitruong_hienthi = list.Select(x => x.JisDaio).FirstOrDefault();
                            ViewBag.thitruong_hienthi = thitruong_hienthi;
                            string mapallet_hienthi = list.Select(x => x.JisPlno).FirstOrDefault();
                            ViewBag.mapallet_hienthi = mapallet_hienthi;
                        }
                        else
                        {
                            StatusMessage = "Không có dữ liệu của pallet này trong database!";
                            return RedirectToAction("Index");
                        }
                    }
                    if (tenmodel == "T543")
                    {
                        var list = await _t527Context.JisekiFs.Where(x => (thitruong.Contains(x.JisDaio) && sopallet.Contains(x.JisPlno))).ToListAsync();
                        if (list.Count() > 0)
                        {
                            foreach (var i in list)
                            {
                                danhsachbody data = new danhsachbody();
                                data.bodydb = i.JisSile;
                                danhsach.Add(data);
                            }
                            ViewBag.ds = danhsach;
                            ViewBag.tenmodel = tenmodel;
                            string thitruong_hienthi = list.Select(x => x.JisDaio).FirstOrDefault();
                            ViewBag.thitruong_hienthi = thitruong_hienthi;
                            string mapallet_hienthi = list.Select(x => x.JisPlno).FirstOrDefault();
                            ViewBag.mapallet_hienthi = mapallet_hienthi;
                        }
                        else
                        {
                            StatusMessage = "Không có dữ liệu của pallet này trong database!";
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    StatusMessage = "Không có dữ liệu thị trường này trong database!";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                StatusMessage = "Phải nhập đầy đủ thông tin!";
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> luu([FromBody] List<danhsachbody> inputList)
        {
            ISession session = HttpContext.Session;

            foreach (var data in inputList)
            {
                Lichsu dulieu = new Lichsu();
                dulieu.Model = data.model;
                dulieu.Thitruong = data.thitruong;
                dulieu.Mapallet = data.mapallet;
                dulieu.Mabodydb = data.bodydb;
                dulieu.Mabodycheck = data.bodycheck;
                dulieu.Ngaygio = DateTime.Now;
                dulieu.Nguoithaotac = session.GetString("user").ToString();
                await _checkPalletPDCContext.AddAsync(dulieu);
                await _checkPalletPDCContext.SaveChangesAsync();
            }
            return Json(new { success = "đã lưu dữ liệu OK vào database thành công!" });
        }

        [HttpPost]
        public async Task<IActionResult> luuNG([FromBody] List<danhsachbody> inputList)
        {
            ISession session = HttpContext.Session;
            foreach (var data in inputList)
            {
                LichsuNg dulieuNG = new LichsuNg();
                dulieuNG.Model = data.model;
                dulieuNG.Thitruong = data.thitruong;
                dulieuNG.Mapallet = data.mapallet;
                dulieuNG.Mabodydb = data.bodydb;
                if (data.bodycheck.Length < 2)
                {
                    dulieuNG.Mabodycheck = "Không có mã body";
                }
                else
                {
                    dulieuNG.Mabodycheck = data.bodycheck;
                }
                dulieuNG.Ngaygio = DateTime.Now;
                dulieuNG.Nguoithaotac = session.GetString("user").ToString();
                await _checkPalletPDCContext.AddAsync(dulieuNG);
                await _checkPalletPDCContext.SaveChangesAsync();
            }
            return Json(new { success = "đã lưu dữ liệu NG vào database thành công!" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}