using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class ProcessingBL
    {
        public List<global::Common.Processing> GetList()
        {
            try
            {
                return new ProcessingDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
