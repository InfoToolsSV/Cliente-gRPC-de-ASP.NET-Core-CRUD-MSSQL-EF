using LibraryMvcClient.Protos;
using LibraryMvcClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMvcClient.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryGrpcClientService _grpcClient;

        public LibraryController(LibraryGrpcClientService grpcClient)
        {
            _grpcClient = grpcClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _grpcClient.ListBooksAsync();
            return View(response.Books);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            await _grpcClient.CreateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string id)
        {
            var response = await _grpcClient.GetBookAsync(id);
            return View(response.Book);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            await _grpcClient.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            var response = await _grpcClient.GetBookAsync(id);
            return View(response.Book);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _grpcClient.DeleteBookAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}