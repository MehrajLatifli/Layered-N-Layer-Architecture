
using Radio_player._Entities.Concrete.DatabaseFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_player.Business.Abstract
{
    public interface IRadioService
    {
        List<Radio> GetAll();

        void Add(Radio item);
        void Update(Radio item);
        void Delete(Radio item);
        Radio GetById(int Id);
    }
}
