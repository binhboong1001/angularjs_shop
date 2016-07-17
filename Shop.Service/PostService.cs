using Shop.Data.Infrastructure;
using Shop.Data.Repositories;
using Shop.Model.Model;
using System.Collections.Generic;
using System.Linq;
namespace Shop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Detele(Post post);
        void Detele(int id);

        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int toltalRow);
        Post GetById(int Id);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWorkRepository;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWorkRepository = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public void Detele(Post post)
        {
            _postRepository.Delete(post);
        }
        public void Detele(int id)
        {
            _postRepository.Delete(id);
        }
        /// <summary>
        /// lấy thêm cả chuyên mục kèm theo bài viết
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public void SaveChanges()
        {
            _unitOfWorkRepository.Commit();
        }
        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }
    }
}
