using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class WeekDaysBL
    {
        public List<global::Common.WeekDays> GetList()
        {
            try
            {
                return new WeekDaysDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
