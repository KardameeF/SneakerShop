using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerShop
{
    public class ShoeRepository : IShoeRepository
    {
        private List<Shoe> _shoes = new List<Shoe>();

        public Shoe GetShoe(int id)
        {
            return _shoes.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Shoe> GetAllShoes()
        {
            return _shoes;
        }

        public void AddShoe(Shoe shoe)
        {
            _shoes.Add(shoe);
        }

        public void UpdateShoe(Shoe shoe)
        {
            var index = _shoes.FindIndex(s => s.Id == shoe.Id);
            if (index != -1)
            {
                _shoes[index] = shoe;
            }
        }

        public void DeleteShoe(int id)
        {
            _shoes.RemoveAll(s => s.Id == id);
        }
    }

}
