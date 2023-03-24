using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class ProcessingAlgorithmOperationKindBL
    {
        public List<global::Common.ProcessingAlgorithmOperationKind> GetList()
        {
            try
            {
                return new ProcessingAlgorithmOperationKindDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
