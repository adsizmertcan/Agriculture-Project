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
    public class TeamsManager : ITeamsService
    {
        private readonly ITeamsDal _teamsDal;

        public TeamsManager(ITeamsDal teamsDal)
        {
            _teamsDal = teamsDal;
        }

        public void TDelete(Team t)
        {
            _teamsDal.Delete(t);
        }

        public Team TGetById(int id)
        {
            return _teamsDal.GetById(id);
        }

        public List<Team> TGetList()
        {
            return _teamsDal.GetList();
        }

        public void TInsert(Team t)
        {
            _teamsDal.Insert(t);
        }

        public void TUpdate(Team t)
        {
            _teamsDal.Update(t);
        }
    }
}
