using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Dapper;
namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> listEmployee = con.Query<EmployeeModel>("SELECT * FROM dbo.employeeDetails").ToList();
            
            return listEmployee;
        }

        public int SaveEmployees(EmployeeModel emp)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EmpName",emp.EmpName);
            parameter.Add("@EmpSalary",emp.EmpSalary);

            int result = con.Execute("usp_saveEmployee",param: parameter, commandType:CommandType.StoredProcedure);

            return result;
        }

        public EmployeeModel GetEmployeesById(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EmpId",id);

            EmployeeModel result = con.QuerySingle<EmployeeModel>("sp_getNeerjaEmployeeDetailsById", param: parameter, commandType: CommandType.StoredProcedure);

            return result;


        }
    }
}