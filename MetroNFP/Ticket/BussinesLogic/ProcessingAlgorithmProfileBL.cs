using System;
using System.Collections.Generic;
using Ticket.DataAccess;

namespace Ticket.BussinesLogic
{
    class ProcessingAlgorithmProfileBL
    {
        public List<global::Common.ProcessingAlgorithmProfile> GetList()
        {
            try
            {
                return new ProcessingAlgorithmProfileDAL().GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertProcessingAlgorithmProfile(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().InsertProcessingAlgorithmProfile(processingAlgorithmProfile);
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

        public int UpdateProcessingAlgorithmProfile(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().UpdateProcessingAlgorithmProfile(processingAlgorithmProfile);
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

        public int DeleteProcessingAlgorithmProfile(int processingAlgorithmProfileID)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().DeleteProcessingAlgorithmProfile(processingAlgorithmProfileID);
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

        public int InsertProcessingAlgorithm(List<global::Common.ProcessingAlgorithmProfile> processingAlgorithmProfiles)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().InsertProcessingAlgorithm(processingAlgorithmProfiles);
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

        public int UpdateProcessingAlgorithm(global::Common.ProcessingAlgorithmProfile processingAlgorithmProfile, short Oldfk_ProcessingAlgorithmOperationKindID, short OldSequence)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().UpdateProcessingAlgorithm(processingAlgorithmProfile, Oldfk_ProcessingAlgorithmOperationKindID, OldSequence);
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

        public int DeleteProcessingAlgorithm(short processingAlgorithmOperationKind, short processingAlgorithmProfileID, short sequence)
        {
            try
            {
                Common.Utility.ConnectionManager.Instance.BeginTransaction();
                return new ProcessingAlgorithmProfileDAL().DeleteProcessingAlgorithm(processingAlgorithmOperationKind, processingAlgorithmProfileID, sequence);
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
