using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class MediaKindBL
    {
        public List<global::Common.MediaKind> GetList()
        {
            try
            {
                return new MediaKindDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
