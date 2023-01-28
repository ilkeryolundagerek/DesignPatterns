using Data.AW2019;
using Utilities;

namespace Data.Repositories
{
    public class Base<T> : GenericRepository<T> where T : class
    {
        public Base() : base(aw2019Context.GetInstance()) { }
    }
}
