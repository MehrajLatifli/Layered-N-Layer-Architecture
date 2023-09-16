
using Radio_player._Entities.Concrete.DatabaseFirst;
using Radio_player.Business.Abstract;
using Radio_player.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_player.Business.Concrete
{
    public class RadioManager : IRadioService
    {
        private IRadioDAL _radioDAL;

        public RadioManager(IRadioDAL radioDAL)
        {
            _radioDAL = radioDAL;
        }

        public void Add(Radio item)
        {
            _radioDAL.Add(item);
        }

        public void Delete(Radio item)
        {
            _radioDAL.Delete(item);
        }

        public List<Radio> GetAll()
        {
            return _radioDAL.GetList();
        }

        public Radio GetById(int Id)
        {
            return _radioDAL.Get(p => p.IdRadio == Id);
        }

        public void Update(Radio item)
        {
            _radioDAL.Update(item);
        }
    }
}
