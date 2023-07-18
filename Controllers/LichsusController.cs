using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pdc.Helpers;
using pdc.Models.Lichsu;

namespace pdc.Controllers
{
    public class LichsusController : Controller
    {
        private readonly CheckPalletPDCContext _context;

        private readonly string _lichsuconnectionString;

        public LichsusController(CheckPalletPDCContext context, IConfiguration config)
        {
            _context = context;
            _lichsuconnectionString = config.GetConnectionString("lichsuConnectionString");
        }

        [TempData]
        public string StatusMessage { get; set; }

        // GET: Lichsus
        public async Task<IActionResult> Index(string ngaybatdau, string ngayketthuc, string mapallet, string mabody)
        {
            if (!String.IsNullOrEmpty(ngaybatdau) && !String.IsNullOrEmpty(ngayketthuc)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                DateTime start = DateTime.Parse(ngaybatdau);
                start = start.ChangeTime(1, 0, 10);
                DateTime end = DateTime.Parse(ngayketthuc);
                end = end.ChangeTime(23, 0, 10);
                var list = await _context.Lichsus
                               .Where(x => x.Ngaygio >= start && x.Ngaygio <= end)
                               .ToListAsync();
                TempData["chedo"] = "ngay";
                TempData["ngaybatdau"] = start.ToString("yyyy/MM/dd");
                TempData["ngayketthuc"] = end.ToString("yyyy/MM/dd");

                TempData["sl_l1231"] = list.Where(x => x.Model == "L1231").Count();
                TempData["sl_t527"] = list.Where(x => x.Model == "T527").Count();
                TempData["sl_t541"] = list.Where(x => x.Model == "T541").Count();
                TempData["sl_t543"] = list.Where(x => x.Model == "T543").Count();

                return View(list);
            }
            if (!String.IsNullOrEmpty(mapallet) && String.IsNullOrEmpty(mabody))
            {
                string ma = mapallet.Trim();
                var list = await _context.Lichsus
                               .Where(x => x.Mapallet == ma)
                               .ToListAsync();
                TempData["chedo"] = "mapl";
                TempData["mapallet"] = ma;
                TempData["sl_l1231"] = list.Where(x => x.Model == "L1231").Count();
                TempData["sl_t527"] = list.Where(x => x.Model == "T527").Count();
                TempData["sl_t541"] = list.Where(x => x.Model == "T541").Count();
                TempData["sl_t543"] = list.Where(x => x.Model == "T543").Count();
                return View(list);
            }
            if (!String.IsNullOrEmpty(mabody) && String.IsNullOrEmpty(mapallet))
            {
                string ma = mabody.Trim();
                var list = await _context.Lichsus
                               .Where(x => x.Mabodycheck == ma)
                               .ToListAsync();
                TempData["chedo"] = "mabd";
                TempData["mabody"] = ma;
                TempData["sl_l1231"] = list.Where(x => x.Model == "L1231").Count();
                TempData["sl_t527"] = list.Where(x => x.Model == "T527").Count();
                TempData["sl_t541"] = list.Where(x => x.Model == "T541").Count();
                TempData["sl_t543"] = list.Where(x => x.Model == "T543").Count();
                return View(list);
            }
            if (!String.IsNullOrEmpty(mapallet) && !String.IsNullOrEmpty(mabody))
            {
                string mapl = mapallet.Trim();
                string mabd = mabody.Trim();
                var list = await _context.Lichsus
                               .Where(x => (x.Mapallet == mapl && x.Mabodycheck == mabd))
                               .ToListAsync();
                TempData["chedo"] = "ma2";
                TempData["mapallet"] = mapl;
                TempData["mabody"] = mabd;
                TempData["sl_l1231"] = list.Where(x => x.Model == "L1231").Count();
                TempData["sl_t527"] = list.Where(x => x.Model == "T527").Count();
                TempData["sl_t541"] = list.Where(x => x.Model == "T541").Count();
                TempData["sl_t543"] = list.Where(x => x.Model == "T543").Count();
                return View(list);
            }
            return View();
        }

        public async Task<IActionResult> Thongketrongngay(int? id)
        {
            DateTime today = DateTime.Now;
            today = today.ChangeTime(1, 0, 10);
            var list = await _context.Lichsus.Where(x => x.Ngaygio >= today).ToListAsync();

            var listtong = _context.Lichsus
                .Where(x => x.Ngaygio >= today)
                .ToList();
            int totalNGtong = Convert.ToInt32(listtong.Count().ToString());
            // string connectionString = "Data Source=192.168.1.254;User Id=sa;Password=123;Initial Catalog=BaoLoi;Trusted_connection=false;TrustServerCertificate=True";
            string query = "SELECT[Model], COUNT(*) AS Soluong FROM dbo.lichsu WHERE Ngaygio >= '" + today + "' GROUP BY[Model] ORDER BY Soluong DESC";
            using (SqlConnection connection = new SqlConnection(_lichsuconnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> ten_model = new List<string>();
                List<int> soluong = new List<int>();
                List<double> tilephantram = new List<double>();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                int totalsoluong = 0;
                int i = 0;
                while (i < dataTable.Rows.Count)
                {
                    string ten;
                    int sl;
                    double percent;
                    if (i == 0)
                    {
                        DataRow row = dataTable.Rows[i];
                        ten = row["Model"].ToString();
                        sl = Convert.ToInt32(row["Soluong"]);
                        totalsoluong += sl;
                        percent = Math.Round(((double)sl / totalNGtong * 100), 1);
                    }
                    else
                    {
                        DataRow row = dataTable.Rows[i];
                        ten = row["Model"].ToString();
                        sl = Convert.ToInt32(row["Soluong"]);
                        totalsoluong += sl;
                        percent = Math.Round(((double)totalsoluong / totalNGtong * 100), 1);
                    }
                    ten_model.Add(ten);
                    soluong.Add(sl);
                    tilephantram.Add(percent);
                    i++;
                }
                ViewBag.tenmodel = ten_model;
                ViewBag.soluongsuco = soluong;
                ViewBag.tile = tilephantram;
                ViewBag.total = totalNGtong.ToString();
            }
            TempData["sl_l1231"] = list.Where(x => x.Model == "L1231").Count();
            TempData["sl_t527"] = list.Where(x => x.Model == "T527").Count();
            TempData["sl_t541"] = list.Where(x => x.Model == "T541").Count();
            TempData["sl_t543"] = list.Where(x => x.Model == "T543").Count();
            return View(list);
        }
    }
}