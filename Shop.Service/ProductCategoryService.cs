using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Model;
using System.Collections.Generic;

namespace Shop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory ProductCategory);

        void Update(ProductCategory ProductCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        ProductCategory GetById(int id);
        void SaveChange();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryReposotory _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryReposotory ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = ProductCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory ProductCategory)
        {
            _productCategoryRepository.Add(ProductCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

      
        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

        public void Update(ProductCategory ProductCategory)
        {
            _productCategoryRepository.Update(ProductCategory);
        }


        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
    }
}
