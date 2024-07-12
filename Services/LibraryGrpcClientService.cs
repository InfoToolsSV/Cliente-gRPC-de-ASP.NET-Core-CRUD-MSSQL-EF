using Grpc.Net.Client;
using LibraryMvcClient.Protos;

namespace LibraryMvcClient.Services
{
    public class LibraryGrpcClientService
    {
        private readonly LibraryService.LibraryServiceClient _client;

        public LibraryGrpcClientService()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5228");
            _client = new LibraryService.LibraryServiceClient(channel);
        }

        public async Task<CreateBookResponse> CreateBookAsync(Book book)
        {
            var request = new CreateBookRequest { Book = book };
            return await _client.CreateBookAsync(request);
        }

        public async Task<GetBookResponse> GetBookAsync(string id)
        {
            var request = new GetBookRequest { Id = id };
            return await _client.GetBookAsync(request);
        }

        public async Task<UpdateBookResponse> UpdateBookAsync(Book book)
        {
            var request = new UpdateBookRequest { Book = book };
            return await _client.UpdateBookAsync(request);
        }

        public async Task<DeleteBookResponse> DeleteBookAsync(string id)
        {
            var request = new DeleteBookRequest { Id = id };
            return await _client.DeleteBookAsync(request);
        }

        public async Task<ListBooksResponse> ListBooksAsync()
        {
            var request = new ListBooksRequest();
            return await _client.ListBooksAsync(request);
        }
    }
}