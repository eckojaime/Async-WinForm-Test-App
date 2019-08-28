using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataAsyncWinForm
{
  public interface IStudentDataAccess
  {
    Task<List<Student>> GetStudentsAsync();

    Task<List<Student>> GetStudentsAsync(TextBox textBoxLog);
  }
}
