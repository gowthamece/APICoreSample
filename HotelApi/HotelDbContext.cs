using Microsoft.EntityFrameworkCore;

namespace HotelApi
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }
    }
}
