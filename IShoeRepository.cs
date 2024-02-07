using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerShop
{
    public interface IShoeRepository
    {
        Shoe GetShoe(int id);
        IEnumerable<Shoe> GetAllShoes();
        void AddShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoe(int id);
    }

}
