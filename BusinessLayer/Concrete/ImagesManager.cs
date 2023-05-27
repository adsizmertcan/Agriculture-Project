using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImagesManager : IImagesService
    {
        private readonly IImagesDal _ımagesDal;

        public ImagesManager(IImagesDal ımagesDal)
        {
            _ımagesDal = ımagesDal;
        }

        public void TDelete(Image t)
        {
            _ımagesDal.Delete(t);
        }

        public Image TGetById(int id)
        {
            return _ımagesDal.GetById(id);
        }

        public List<Image> TGetList()
        {
            return _ımagesDal.GetList();
        }

        public void TInsert(Image t)
        {
            _ımagesDal.Insert(t);
        }

        public void TUpdate(Image t)
        {
            _ımagesDal.Update(t);
        }
    }
}
