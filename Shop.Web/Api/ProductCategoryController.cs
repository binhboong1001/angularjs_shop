using Shop.Service;
using Shop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Shop.Web.Api
{
    public class ProductCategoryController:ApiControllerBase
    {
        IProductCategoryService _productCategoryService;

        public ProductCategoryController(IErrorService errorSerivce,IProductCategoryService productCategoryService)
            : base(errorSerivce)
        {
            this._productCategoryService = productCategoryService;
        }

        //public HttpRequestMessage GetAll(HttpRequestMessage request)
        //{ 
        //retur
        //}


    }
}