using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactsService
    {
        private readonly IContactsDal _contactsDal;

        public ContactManager(IContactsDal contactsDal)
        {
            _contactsDal = contactsDal;
        }

        public void TDelete(Contact t)
        {
            _contactsDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _contactsDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _contactsDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactsDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
