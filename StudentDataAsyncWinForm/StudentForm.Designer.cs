namespace StudentDataAsyncWinForm
{
  partial class StudentForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
      this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StudentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EnrollmentTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonGetStudentsAsyncAwait = new System.Windows.Forms.Button();
      this.buttonBreakApp = new System.Windows.Forms.Button();
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.buttonGetStudentsAsyncAwaitDelay = new System.Windows.Forms.Button();
      this.buttonGetStudentsNonResponsive = new System.Windows.Forms.Button();
      this.btnGetStudentsAsyncAwait2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewStudents
      // 
      this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.StudentStatus,
            this.EnrollmentTerm});
      this.dataGridViewStudents.Location = new System.Drawing.Point(13, 49);
      this.dataGridViewStudents.Name = "dataGridViewStudents";
      this.dataGridViewStudents.Size = new System.Drawing.Size(680, 349);
      this.dataGridViewStudents.TabIndex = 0;
      // 
      // StudentId
      // 
      this.StudentId.DataPropertyName = "StudentId";
      this.StudentId.HeaderText = "StudentId";
      this.StudentId.Name = "StudentId";
      // 
      // FirstName
      // 
      this.FirstName.DataPropertyName = "FirstName";
      this.FirstName.HeaderText = "FirstName";
      this.FirstName.Name = "FirstName";
      // 
      // LastName
      // 
      this.LastName.DataPropertyName = "LastName";
      this.LastName.HeaderText = "LastName";
      this.LastName.Name = "LastName";
      // 
      // Gender
      // 
      this.Gender.DataPropertyName = "Gender";
      this.Gender.HeaderText = "Gender";
      this.Gender.Name = "Gender";
      // 
      // StudentStatus
      // 
      this.StudentStatus.DataPropertyName = "StudentStatus";
      this.StudentStatus.HeaderText = "StudentStatus";
      this.StudentStatus.Name = "StudentStatus";
      // 
      // EnrollmentTerm
      // 
      this.EnrollmentTerm.DataPropertyName = "EnrollmentTerm";
      this.EnrollmentTerm.HeaderText = "EnrollmentTerm";
      this.EnrollmentTerm.Name = "EnrollmentTerm";
      // 
      // buttonGetStudentsAsyncAwait
      // 
      this.buttonGetStudentsAsyncAwait.Location = new System.Drawing.Point(13, 444);
      this.buttonGetStudentsAsyncAwait.Name = "buttonGetStudentsAsyncAwait";
      this.buttonGetStudentsAsyncAwait.Size = new System.Drawing.Size(167, 23);
      this.buttonGetStudentsAsyncAwait.TabIndex = 2;
      this.buttonGetStudentsAsyncAwait.Text = "Get Students Async/Await";
      this.buttonGetStudentsAsyncAwait.UseVisualStyleBackColor = true;
      this.buttonGetStudentsAsyncAwait.Click += new System.EventHandler(this.buttonGetStudents_Click);
      // 
      // buttonBreakApp
      // 
      this.buttonBreakApp.Location = new System.Drawing.Point(1040, 444);
      this.buttonBreakApp.Name = "buttonBreakApp";
      this.buttonBreakApp.Size = new System.Drawing.Size(75, 23);
      this.buttonBreakApp.TabIndex = 3;
      this.buttonBreakApp.Text = "Break App";
      this.buttonBreakApp.UseVisualStyleBackColor = true;
      this.buttonBreakApp.Click += new System.EventHandler(this.buttonBreakApp_Click);
      // 
      // textBoxLog
      // 
      this.textBoxLog.Location = new System.Drawing.Point(699, 49);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.Size = new System.Drawing.Size(417, 349);
      this.textBoxLog.TabIndex = 4;
      // 
      // buttonGetStudentsAsyncAwaitDelay
      // 
      this.buttonGetStudentsAsyncAwaitDelay.Location = new System.Drawing.Point(220, 444);
      this.buttonGetStudentsAsyncAwaitDelay.Name = "buttonGetStudentsAsyncAwaitDelay";
      this.buttonGetStudentsAsyncAwaitDelay.Size = new System.Drawing.Size(172, 23);
      this.buttonGetStudentsAsyncAwaitDelay.TabIndex = 5;
      this.buttonGetStudentsAsyncAwaitDelay.Text = "Get Student Async/Await Delay";
      this.buttonGetStudentsAsyncAwaitDelay.UseVisualStyleBackColor = true;
      this.buttonGetStudentsAsyncAwaitDelay.Click += new System.EventHandler(this.buttonGetStudentsAsyncAwaitDelay_Click);
      // 
      // buttonGetStudentsNonResponsive
      // 
      this.buttonGetStudentsNonResponsive.Location = new System.Drawing.Point(429, 444);
      this.buttonGetStudentsNonResponsive.Name = "buttonGetStudentsNonResponsive";
      this.buttonGetStudentsNonResponsive.Size = new System.Drawing.Size(180, 23);
      this.buttonGetStudentsNonResponsive.TabIndex = 6;
      this.buttonGetStudentsNonResponsive.Text = "Get Students Non Responsive";
      this.buttonGetStudentsNonResponsive.UseVisualStyleBackColor = true;
      this.buttonGetStudentsNonResponsive.Click += new System.EventHandler(this.ButtonGetStudentsNonResponsive_Click);
      // 
      // btnGetStudentsAsyncAwait2
      // 
      this.btnGetStudentsAsyncAwait2.Location = new System.Drawing.Point(863, 444);
      this.btnGetStudentsAsyncAwait2.Name = "btnGetStudentsAsyncAwait2";
      this.btnGetStudentsAsyncAwait2.Size = new System.Drawing.Size(160, 23);
      this.btnGetStudentsAsyncAwait2.TabIndex = 7;
      this.btnGetStudentsAsyncAwait2.Text = "Get Students Async/Await 2";
      this.btnGetStudentsAsyncAwait2.UseVisualStyleBackColor = true;
      this.btnGetStudentsAsyncAwait2.Click += new System.EventHandler(this.BtnGetStudentsAsyncAwait2_Click);
      // 
      // StudentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1128, 483);
      this.Controls.Add(this.btnGetStudentsAsyncAwait2);
      this.Controls.Add(this.buttonGetStudentsNonResponsive);
      this.Controls.Add(this.buttonGetStudentsAsyncAwaitDelay);
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.buttonBreakApp);
      this.Controls.Add(this.buttonGetStudentsAsyncAwait);
      this.Controls.Add(this.dataGridViewStudents);
      this.Name = "StudentForm";
      this.Text = "Async WinForm Students";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewStudents;
    private System.Windows.Forms.Button buttonGetStudentsAsyncAwait;
    private System.Windows.Forms.Button buttonBreakApp;
    private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
    private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
    private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    private System.Windows.Forms.DataGridViewTextBoxColumn StudentStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn EnrollmentTerm;
    private System.Windows.Forms.TextBox textBoxLog;
    private System.Windows.Forms.Button buttonGetStudentsAsyncAwaitDelay;
    private System.Windows.Forms.Button buttonGetStudentsNonResponsive;
    private System.Windows.Forms.Button btnGetStudentsAsyncAwait2;
  }
}

