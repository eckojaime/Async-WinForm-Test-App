using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDataAsyncWinForm
{
  public partial class StudentForm : Form
  {

    private delegate void SafeTextBoxDelegate(string text);
    private delegate void SafeDataGridViewDelegate(List<Student> students);
    public StudentForm()
    {
      InitializeComponent();
    }

    #region Button Clicks
    private async void buttonGetStudents_Click(object sender, EventArgs e)
    {
      ClearLogAndDataGridView();

      List<Student> students = new List<Student>();
      IStudentDataAccess dataAccess = new StudentSQLDataAccess();

      UpdateLog("Starting: GetStudents Async/Await");
      students = await dataAccess.GetStudentsAsync();
      UpdateLog("Finished: GetStudents Async/Await");

      UpdateLog("Starting: Binding to DataGridView");
      dataGridViewStudents.DataSource = students;      
      UpdateLog("Finished: Binding to DataGridView");
    }


    private async void buttonGetStudentsAsyncAwaitDelay_Click(object sender, EventArgs e)
    {
      ClearLogAndDataGridView();      

      List<Student> students = new List<Student>();
      IStudentDataAccess dataAccess = new StudentSQLDataAccess();
            
      UpdateLog("Starting: GetStudents Async/Await Delay");
      students = await dataAccess.GetStudentsAsync();

      UpdateLog("Delaying: Delaying for 5 seconds...");
      await Task.Delay(1000);

      UpdateLog("Delaying: Delaying for 4 seconds...");
      await Task.Delay(1000);

      UpdateLog("Delaying: Delaying for 3 seconds...");
      await Task.Delay(1000);

      UpdateLog("Delaying: Delaying for 2 seconds...");
      await Task.Delay(1000);

      UpdateLog("Delaying: Delaying for 1 second...");
      await Task.Delay(1000);

      UpdateLog("Finished: GetStudents Async/Await Delay");

      UpdateLog("Starting: Binding to DataGridView");
      dataGridViewStudents.DataSource = students;
      UpdateLog("Finished: Binding to DataGridView");
    }

    private void ButtonGetStudentsNonResponsive_Click(object sender, EventArgs e)
    {
      ClearLogAndDataGridView();

      List<Student> students = new List<Student>();
      IStudentDataAccess dataAccess = new StudentSQLDataAccess();

      UpdateLog("Starting: GetStudents Non Responsive");
      UpdateLog("Delaying: Delaying for 5 seconds...");

      var task = Task.Factory.StartNew(async () => students = await dataAccess.GetStudentsAsync());
      task.Wait();

      Task.Delay(5000).Wait();
      UpdateLog("Finished: GetStudents Non Responsive");

      UpdateLog("Starting: Binding to DataGridView");
      dataGridViewStudents.DataSource = students;
      UpdateLog("Finished: Binding to DataGridView");
    }


    private void BtnGetStudentsAsyncAwait2_Click(object sender, EventArgs e)
    {
      ClearLogAndDataGridView();

      List<Student> students = new List<Student>();
      IStudentDataAccess dataAccess = new StudentSQLDataAccess();

      UpdateLog("Starting: GetStudents Async/Await 2");
      Task.Factory.StartNew(async () => 
      {
        students = await dataAccess.GetStudentsAsync();
        WriteTextSafe("Finished: GetStudents Async/Await 2");

        WriteTextSafe("Starting: Binding to DataGridView");
        UpdateDataGridViewSafe(students);
        WriteTextSafe("Finished: Binding to DataGridView");
      });      
    }
    private void buttonBreakApp_Click(object sender, EventArgs e)
    {
      ClearLogAndDataGridView();

      List<Student> students = new List<Student>();
      IStudentDataAccess dataAccess = new StudentSQLDataAccess();

      UpdateLog("Starting: GetStudents Result");
      UpdateLog("Broken: It broke... Oh oh....");
      students = dataAccess.GetStudentsAsync().Result;
      UpdateLog("Finished: How though?!");

      UpdateLog("Starting: Binding to DataGridView");
      dataGridViewStudents.DataSource = students;
      UpdateLog("Finished: Binding to DataGridView");
    }
    #endregion

    #region Helper Methods
    private void UpdateLog(string message)
    {
      textBoxLog.Text = textBoxLog.Text + Environment.NewLine + message;
    }

    private void ClearLogAndDataGridView()
    {
      textBoxLog.Text = string.Empty;
      dataGridViewStudents.DataSource = null;
    }

    private void WriteTextSafe(string message)
    {
      if (textBoxLog.InvokeRequired)
      {
        var d = new SafeTextBoxDelegate(WriteTextSafe);
        textBoxLog.Invoke(d, new object[] { message });
      }
      else
      {
        textBoxLog.Text = textBoxLog.Text + Environment.NewLine + message;
      }
    }

    private void UpdateDataGridViewSafe(List<Student> students)
    {
      if (textBoxLog.InvokeRequired)
      {
        var d = new SafeDataGridViewDelegate(UpdateDataGridViewSafe);
        dataGridViewStudents.Invoke(d, new object[] { students });
      }
      else
      {
        dataGridViewStudents.DataSource = students;
      }
    }

    #endregion
  }
}
