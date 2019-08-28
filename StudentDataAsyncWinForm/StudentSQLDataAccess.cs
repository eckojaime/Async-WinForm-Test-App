using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataAsyncWinForm
{
  public class StudentSQLDataAccess : IStudentDataAccess
  {
    public async Task<List<Student>> GetStudentsAsync()
    {
      List<Student> students = new List<Student>();
      string sConnectionString = "Data Source=db;Initial Catalog=Students;Integrated Security=SSPI;";
      string sSQL = "SELECT TOP (1000) [StudentId],[FirstName],[MiddleName],[LastName],[Gender],[StudentStatus],[EnrollmentTerm]FROM[Students].[dbo].[Students]";   
      
      var task = Task<List<Student>>.Run(() =>
      {
        using (var connection = new SqlConnection(sConnectionString))
        using (var adapter = new SqlDataAdapter(sSQL, connection))
        {
          adapter.SelectCommand.CommandType = CommandType.Text;  
          DataSet dataSet = new DataSet();
          adapter.Fill(dataSet);

          var reader = dataSet.CreateDataReader();
          if(reader.HasRows)
          {
            while (reader.Read())
            {
              Student student = new Student()
              {
                StudentId = (int)reader["StudentId"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Gender = reader["Gender"].ToString().ToCharArray()[0],
                StudentStatus = reader["StudentStatus"].ToString().ToCharArray()[0],
                EnrollmentTerm = reader["EnrollmentTerm"].ToString()
              };
              students.Add(student);
            }
          }
          
          return students;          
        }
      });

      return await task;
    }

    public async Task<List<Student>> GetStudentsAsync(TextBox textBoxLog)
    {      
      var students = await GetStudentsAsync();
      textBoxLog.Text = "I update here"; //blows up
      return students;
    }
  }
}
