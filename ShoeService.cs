using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerShop
{
    public class ShoeService
    {
        private readonly IShoeRepository _shoeRepository;

        public ShoeService(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        public IEnumerable<Shoe> GetAllShoes()
        {
            return _shoeRepository.GetAllShoes();
        }

        public Shoe GetShoe(int id)
        {
            return _shoeRepository.GetShoe(id);
        }

        public void AddShoe(Shoe shoe)
        {
            _shoeRepository.AddShoe(shoe);
        }

        public void UpdateShoe(Shoe shoe)
        {
            _shoeRepository.UpdateShoe(shoe);
        }

        public void DeleteShoe(int id)
        {
            _shoeRepository.DeleteShoe(id);
        }

        
    }

}
