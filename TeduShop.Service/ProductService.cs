using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPaging(int page,int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        Product GetByID(int id);
        void Commit();
    }
    public class ProductService : IProductService
    {
        IProductRepository _productRespository;
        IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository,IUnitOfWork unitOfWork)
        {
            this._productRespository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product product)
        {
            _productRespository.Add(product);
        }

        public void Delete(int id)
        {
            _productRespository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRespository.GetAll(new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _productRespository.GetAllByTagPaging(tag,page,pageSize,out totalRow);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRespository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Product GetByID(int id)
        {
            return _productRespository.GetSingleById(id);
        }

        public void Commit()
        {
           _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRespository.Update(product);
        }
    }
}
