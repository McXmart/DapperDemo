using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DapperDemo.Utils;
using Dapper;

namespace DapperDemo
{
    public class QueryStoredProcedureDemo
    {
        static void Main5(string[] args)
        //static void Main(string[] args)
        {
            QueryStoredProcedureDemo clientSPQuery = new QueryStoredProcedureDemo();
            dynamic spResultDynamic = null;

            #region 如何调用存储过程

            Console.WriteLine("开始执行ProcedureWithOutAndReturnParameter()：");
            spResultDynamic = clientSPQuery.ProcedureWithOutAndReturnParameter();
            if (spResultDynamic != null)
            {
                Console.WriteLine("执行成功：{0}。", spResultDynamic.NameResult);
            }
            Console.ReadLine();           

            #endregion
        }

        public dynamic ProcedureWithOutAndReturnParameter()
        {
            int successCode = -1;
            string resultMessage = string.Empty;
            using (IDbConnection connection = Common.OpenConnection())
            {
                DynamicParameters parameter = new DynamicParameters();
                string name = "test";
                parameter.Add("@Name", name);             
                parameter.Add("@SuccessCode", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameter.Add("@ResultMessage", dbType: DbType.String, direction: ParameterDirection.Output, size: 255);
                parameter.Add("@Result", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                IEnumerable<dynamic> result = connection.Query(sql: "DapperNETDemoSPExample_get", param: parameter, commandType: CommandType.StoredProcedure);
                                
                successCode = parameter.Get<int>("SuccessCode");
                resultMessage = parameter.Get<string>("ResultMessage");

                dynamic row = result.Single();
                return row;               
            }
        }
    }
}
