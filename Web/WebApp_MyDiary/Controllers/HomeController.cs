using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_MyDiary.Models;

namespace WebApp_MyDiary.Controllers
{
    public class HomeController : Controller
    {
        private readonly DiaryDBContext DiaryDB;

        public HomeController(DiaryDBContext DiaryDB)
        {
            this.DiaryDB = DiaryDB;
        }

        public IActionResult Index()
        {
            var diaData = DiaryDB.Diary.ToList();
            return View(diaData);
        }
        // GET: 삽입화면
        public IActionResult Create()
        {
            return View();
        }
        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("No,Title,Content,Date")] Diary diary)
        {
            if (ModelState.IsValid)  //비동기는 쉽지만 남발 할 시 피를 볼 수 있다.
            {
                DiaryDB.Add(diary);
                await DiaryDB.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diary);
        }
        public IActionResult Result(int? id)
        {
            // 데이터베이스 컨텍스트를 사용하여 id에 해당하는 Diary 데이터를 조회합니다.

            var diaData = DiaryDB.Diary.FirstOrDefault(d => d.No == id);
            return View(diaData);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || DiaryDB == null)
            {
                return NotFound(); // 데이터가 없을 경우 404 에러를 반환합니다.
            }
            var diaData = DiaryDB.Diary.Find(id);
            if (diaData == null)
            {
                return NotFound(); // 데이터가 없을 경우 404 에러를 반환합니다.
            }
            return View(diaData);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Diary dia)
        {
            if(ModelState.IsValid)
            {
                DiaryDB.Update(dia);
                DiaryDB.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(dia);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || DiaryDB == null)
            {
                return NotFound(); // 데이터가 없을 경우 404 에러를 반환합니다.
            }
            var diaData = DiaryDB.Diary.FirstOrDefault(x => x.No == id);
            if (diaData == null)
            {
                return NotFound(); // 데이터가 없을 경우 404 에러를 반환합니다.
            }
            return View(diaData);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var diaData = DiaryDB.Diary.Find(id);
            if(diaData != null)
            {
                DiaryDB.Diary.Remove(diaData);
            }
            DiaryDB.SaveChanges();

            return RedirectToAction("Index", "Home");
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