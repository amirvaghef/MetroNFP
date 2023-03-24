using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Ticket.DataAccess
{
    class ProcessingAlgorithmOperationKindDAL
    {
        private ProcessingAlgorithmOperationKind FillEntity(IDataReader reader)
        {
            ProcessingAlgorithmOperationKind processingAlgorithmOperationKind = new ProcessingAlgorithmOperationKind();
            processingAlgorithmOperationKind.ProcessingAlgorithmOperationKindID = short.Parse(reader.GetValue(reader.GetOrdinal("ProcessingAlgorithmOperationKindID")).ToString());
            processingAlgorithmOperationKind.ProcessingAlgorithmOperationKindName = reader.GetValue(reader.GetOrdinal("ProcessingAlgorithmOperationKindName")).ToString();

            return processingAlgorithmOperationKind;
        }

        public List<global::Common.ProcessingAlgorithmOperationKind> GetList()
        {
            List<ProcessingAlgorithmOperationKind> list = new List<ProcessingAlgorithmOperationKind>();
            if (Common.Utility.Setting.DBType == Common.Utility.DataBaseType.SqlServer)
            {
                SqlConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as SqlConnection;
                try
                {

                    SqlCommand command = new SqlCommand("Ticket.NFPspProcessingAlgorithmOperationKindGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as SqlTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
            else
            {
                OleDbConnection connection = Common.Utility.ConnectionManager.Instance.GetConnection() as OleDbConnection;
                try
                {
                    OleDbCommand command = new OleDbCommand("Ticket.NFPspProcessingAlgorithmOperationKindGetList", connection, Common.Utility.ConnectionManager.Instance.ActiveTransaction as OleDbTransaction);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        list.Add(FillEntity(reader));
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Common.Utility.ConnectionManager.Instance.FreeConnection(connection);
                }
                return list;
            }
        }
    }
}
