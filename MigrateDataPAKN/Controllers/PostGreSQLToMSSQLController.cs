using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MigrateDataPAKN.ModelsPostGre;
using MigrateDataPAKN.ModelsSQL;

namespace MigrateDataPAKN.Controllers
{
    public class PostGreSQLToMSSQLController : Controller
    {
        private readonly PhanAnhKienNghiContext _contextSQL;
        private readonly quanlyduanContext _contextPG;

        public PostGreSQLToMSSQLController(PhanAnhKienNghiContext contextSQL, quanlyduanContext contextPG)
        {
            _contextSQL = contextSQL;
            _contextPG = contextPG;
        }
        public IActionResult MigratePostGreSQLToMSSQL_Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Index(string table)
        {
            switch (table)
            {
                case "dm500":
                   await MigratePostGreSQLToMSSQL_Dm500();
                    break;
                case "dm501":
                    await MigratePostGreSQLToMSSQL_Dm501();
                    break;
                case "dm502":
                    await MigratePostGreSQLToMSSQL_Dm502();
                    break;
                case "dm503":
                    await MigratePostGreSQLToMSSQL_Dm503();
                    break;
                case "dm504":
                    await MigratePostGreSQLToMSSQL_Dm504();
                    break;
                case "dm505":
                    await MigratePostGreSQLToMSSQL_Dm505();
                    break;
                case "dm506":
                    await MigratePostGreSQLToMSSQL_Dm506();
                    break;
                case "dm507":
                    await MigratePostGreSQLToMSSQL_Dm507();
                    break;
                case "dm508":
                    await MigratePostGreSQLToMSSQL_Dm508();
                    break;
                case "dm509":
                    await MigratePostGreSQLToMSSQL_Dm509();
                    break;
                case "dm510":
                    await MigratePostGreSQLToMSSQL_Dm510();
                    break;
            }

            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm500()
        {
            try
            {
            var data = await _contextPG.Dm500s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm500
            {
                Maloaisolieu = x.Maloaisolieu,
                Tenloaisolieu = x.Tenloaisolieu
            }).ToList();
            await _contextSQL.Dm500s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
                TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM500 từ PosGreSQL sang MSSQL thành công!";
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm501()
        {
            try
            {
                var data = await _contextPG.Dm501s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm501
            {
                Machitieu = x.Machitieu,
                Maloaisolieu = x.Maloaisolieu,
                Tenchitieu = x.Tenchitieu,
                Loaichitieu = x.Loaichitieu,
                Madonvitinh = x.Madonvitinh,
            }).ToList();
            await _contextSQL.Dm501s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM501 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm502()
        {
            try
            {
                var data = await _contextPG.Dm502s.ToListAsync();
                var newData = data.Select(x => new ModelsSQL.Dm502
            {
                Machuongtrinh = x.Machuongtrinh,
                Tenchuongtrinh = x.Tenchuongtrinh,
            }).ToList();
            await _contextSQL.Dm502s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM502 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm503()
        {
            try
            {
                var data = await _contextPG.Dm503s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm503
            {
                Maduan = x.Maduan,
                Machuongtrinh = x.Machuongtrinh,
                Tenduan = x.Tenduan,
            }).ToList();

            await _contextSQL.Dm503s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM503 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm504()
        {
            try
            {
                var data = await _contextPG.Dm504s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm504
            {
                Maduan = x.Maduan,
                Machuongtrinh = x.Machuongtrinh,
                Manoidungthanhphan = x.Manoidungthanhphan,
                Tenthanhphan = x.Tenthanhphan,
            }).ToList();

            await _contextSQL.Dm504s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM504 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm505()
        {
        try
        {
            var data = await _contextPG.Dm505s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm505
            {
                Mathon = x.Mathon,
                Maxa = x.Maxa,
                Mahuyen = x.Mahuyen,
                Matinh = x.Matinh,
                Tenthon = x.Tenthon,
                Tenxa = x.Tenxa,
                Tenhuyen = x.Tenhuyen,
                Tentinh = x.Tentinh,
                Kinhdo = x.Kinhdo.ToString(),
                Vido = x.Vido.ToString(),
            }).ToList();

            await _contextSQL.Dm505s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM505 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm506()
        {
            try { 
            var data = await _contextPG.Dm506s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm506
            {
                Madonvitinh = x.Madonvitinh,
                Tendonvitinh = x.Tendonvitinh,
            }).ToList();

            await _contextSQL.Dm506s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM506 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm507()
        {
            try { 
            var data = await _contextPG.Dm507s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm507
            {
                Manguon = x.Manguon,
                Tennguon = x.Tennguon,
            }).ToList();

            await _contextSQL.Dm507s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM507 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm508()
        {
            try { 
            var data = await _contextPG.Dm508s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm508
            {
                Macap = x.Macap,
                Tencap = x.Tencap,
            }).ToList();

            await _contextSQL.Dm508s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM508 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm509()
        {
            try { 
            var data = await _contextPG.Dm509s.ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm509
            {
                Madonvi = x.Madonvi,
                Tendonvi = x.Tendonvi,
            }).ToList();

            await _contextSQL.Dm509s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM509 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }

        public async Task<IActionResult> MigratePostGreSQLToMSSQL_Dm510()
        {
            try { 
            var data = await _contextPG.Dm510s.AsNoTracking().ToListAsync();
            var newData = data.Select(x => new ModelsSQL.Dm510
            {
                Maxa = x.Maxa,
                Mahuyen = x.Mahuyen,
                Matinh = x.Matinh,
                Tenxa = x.Tenxa,
                Tenhuyen = x.Tenhuyen,
                Tentinh = x.Tentinh,
                Kinhdo = x.Kinhdo.ToString(),
                Vido = x.Vido.ToString(),
            }).ToList();
            await _contextSQL.Dm510s.AddRangeAsync(newData);
            await _contextSQL.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM510 từ PosGreSQL sang MSSQL thành công!";
            return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã có lỗi xảy ra vui lòng thử lại sau!");
                return RedirectToAction("MigratePostGreSQLToMSSQL_Index");
            }
        }
    }
}
