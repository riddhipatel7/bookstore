using BookStore.Models.DataModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly bookstoreContext _context = new bookstoreContext();
    }
}
