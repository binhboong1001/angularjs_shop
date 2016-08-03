using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Model;
using System;
using System.Collections.Generic;

namespace Shop.Service
{
    interface IMenuGroupService
    {
        void Add(MenuGroup _menuGroup);
        void Update(MenuGroup _menuGroup);
        MenuGroup Delete(int _id);
        IEnumerable<MenuGroup> GetAll();
        MenuGroup GetById(int _id);
        void SaveChange();
    }
    public class MenuGroupService : IMenuGroupService
    {
        IMenuGroupRepository _menuRepository;
        IUnitOfWork _unitOfWork;
        public MenuGroupService(IMenuGroupRepository _menuRepository, IUnitOfWork _unitOfWork)
        {
            this._menuRepository = _menuRepository;
            this._unitOfWork = _unitOfWork;
        }

        public void Add(MenuGroup _menuGroup)
        {
            throw new NotImplementedException();
        }

        public void Update(MenuGroup _menuGroup)
        {
            throw new NotImplementedException();
        }

        public MenuGroup Delete(int _id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            throw new NotImplementedException();
        }

        public MenuGroup GetById(int _id)
        {
            throw new NotImplementedException();
        }
        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
    }
}
