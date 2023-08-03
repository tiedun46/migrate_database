using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MigrateDataPAKN.ModelsPostGre;
using MigrateDataPAKN.ModelsSQL;

namespace MigrateDataPAKN.Controllers
{
    public class MSSQLToPostGreSQLController : Controller
    {
        private readonly PhanAnhKienNghiContext _contextSQL;
        private readonly quanlyduanContext _contextPG;

        public MSSQLToPostGreSQLController(PhanAnhKienNghiContext contextSQL, quanlyduanContext contextPG)
        {
            _contextSQL = contextSQL;
            _contextPG = contextPG;
        }
        public IActionResult MigrateMSSQLToPostGreSQL_Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Index(string table)
        {
            switch (table)
            {
                case "dm500":
                    await MigrateMSSQLToPostGreSQL_Dm500();
                    break;
                case "dm501":
                    await MigrateMSSQLToPostGreSQL_Dm501();
                    break;
                case "dm502":
                    await MigrateMSSQLToPostGreSQL_Dm502();
                    break;
                case "dm503":
                    await MigrateMSSQLToPostGreSQL_Dm503();
                    break;
                case "dm504":
                    await MigrateMSSQLToPostGreSQL_Dm504();
                    break;
                case "dm505":
                    await MigrateMSSQLToPostGreSQL_Dm505();
                    break;
                case "dm506":
                    await MigrateMSSQLToPostGreSQL_Dm506();
                    break;
                case "dm507":
                    await MigrateMSSQLToPostGreSQL_Dm507();
                    break;
                case "dm508":
                    await MigrateMSSQLToPostGreSQL_Dm508();
                    break;
                case "dm509":
                    await MigrateMSSQLToPostGreSQL_Dm509();
                    break;
                case "dm510":
                    await MigrateMSSQLToPostGreSQL_Dm510();
                    break;
            }

            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm500()
        {
            var data = await _contextSQL.Dm500s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm500
            {
                Maloaisolieu = x.Maloaisolieu,
                Tenloaisolieu = x.Tenloaisolieu
            }).ToList();
            await _contextPG.Dm500s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM500 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm501()
        {
            var data = await _contextSQL.Dm501s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm501
            {
                Machitieu = x.Machitieu,
                Maloaisolieu = x.Maloaisolieu,
                Tenchitieu = x.Tenchitieu,
                Loaichitieu = x.Loaichitieu,
                Madonvitinh = x.Madonvitinh,
            }).ToList();
            await _contextPG.Dm501s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM501 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm502()
        {
            var data = await _contextSQL.Dm502s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm502
            {
                Machuongtrinh = x.Machuongtrinh,
                Tenchuongtrinh = x.Tenchuongtrinh,
            }).ToList();
            await _contextPG.Dm502s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM502 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm503()
        {
            var data = await _contextSQL.Dm503s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm503
            {
                Maduan = x.Maduan,
                Machuongtrinh = x.Machuongtrinh,
                Tenduan = x.Tenduan,
            }).ToList();
            await _contextPG.Dm503s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM503 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm504()
        {
            var data = await _contextSQL.Dm504s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm504
            {
                Maduan = x.Maduan,
                Machuongtrinh = x.Machuongtrinh,
                Manoidungthanhphan = x.Manoidungthanhphan,
                Tenthanhphan = x.Tenthanhphan,
            }).ToList();
            await _contextPG.Dm504s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM504 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }
        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm505()
        {
            var data = await _contextSQL.Dm505s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm505
            {
                Mathon = x.Mathon,
                Maxa = x.Maxa,
                Mahuyen = x.Mahuyen,
                Matinh = x.Matinh,
                Tenthon = x.Tenthon,
                Tenxa = x.Tenxa,
                Tenhuyen = x.Tenhuyen,
                Tentinh = x.Tentinh,
                Kinhdo = double.Parse(x.Kinhdo),
                Vido = double.Parse(x.Vido),
            }).ToList();
            await _contextPG.Dm505s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM505 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }
        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm506()
        {
            var data = await _contextSQL.Dm506s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm506
            {
                Madonvitinh = x.Madonvitinh,
                Tendonvitinh = x.Tendonvitinh,
            }).ToList();
            await _contextPG.Dm506s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM506 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }
        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm507()
        {
            var data = await _contextSQL.Dm507s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm507
            {
                Manguon = x.Manguon,
                Tennguon = x.Tennguon,
            }).ToList();
            await _contextPG.Dm507s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM507 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm508()
        {
            var data = await _contextSQL.Dm508s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm508
            {
                Macap = x.Macap,
                Tencap = x.Tencap,
            }).ToList();
            await _contextPG.Dm508s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM508 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }
        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm509()
        {
            var data = await _contextSQL.Dm509s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm509
            {
                Madonvi = x.Madonvi,
                Tendonvi = x.Tendonvi,
            }).ToList();
            await _contextPG.Dm509s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM509 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }

        public async Task<IActionResult> MigrateMSSQLToPostGreSQL_Dm510()
        {
            var data = await _contextSQL.Dm510s.ToListAsync();
            var newData = data.Select(x => new ModelsPostGre.Dm510
            {
                Maxa = x.Maxa,
                Mahuyen = x.Mahuyen,
                Matinh = x.Matinh,
                Tenxa = x.Tenxa,
                Tenhuyen = x.Tenhuyen,
                Tentinh = x.Tentinh,
                Kinhdo = double.Parse(x.Kinhdo),
                Vido = double.Parse(x.Vido),
            }).ToList();
            await _contextPG.Dm510s.AddRangeAsync(newData);
            await _contextPG.SaveChangesAsync();
            TempData["SuccessMessage"] = "Chuyển dữ liệu vào bảng DM510 từ MSSQL sang PosGreSQL thành công!";
            return RedirectToAction("MigrateMSSQLToPostGreSQL_Index");
        }
    }
}
