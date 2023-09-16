
using Radio_player._Entities.Concrete.DatabaseFirst;
using Radio_player.Core.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_player.DataAccess.Abstract
{
    public interface IRadioDAL : IEntityRepository<Radio>
    {
    }
}
