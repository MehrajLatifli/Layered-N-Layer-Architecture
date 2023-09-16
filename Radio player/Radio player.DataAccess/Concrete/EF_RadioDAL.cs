
using Radio_player._Entities.Concrete.DatabaseFirst;
using Radio_player.Core.Data_Access.EntityFrameworkCore;
using Radio_player.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_player.DataAccess.Concrete
{
    public class EF_RadioDAL : EF_EntityRepositoryBase<Radio, RadioPlayer_DbContext>, IRadioDAL
    {

    }
}
