using System;
using System.Collections.Generic;
using Network.DataAccess;

namespace Network.BusinnesLogic
{
    public class SectionBL
    {
        public List<global::Common.Section> GetList()
        {
            try
            {
                return new SectionDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(global::Common.Section section)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new SectionDAL().Update(section);
            }
            catch (Exception ex)
            {
                Common.Utility.ConnectionManager.Instance.RollbackTransaction();
                throw ex;
            }
            finally
            {
                Common.Utility.ConnectionManager.Instance.CommitTransaction();
            }
        }
    }
}
