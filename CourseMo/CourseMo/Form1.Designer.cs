namespace CourseMo
{
  partial class Form1
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
      this.studentListBox = new System.Windows.Forms.ListBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.coursesListBox = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.semesterTextBox = new System.Windows.Forms.TextBox();
      this.yearTextBox = new System.Windows.Forms.TextBox();
      this.typeTextBox = new System.Windows.Forms.TextBox();
      this.dayTextBox = new System.Windows.Forms.TextBox();
      this.timeTextBox = new System.Windows.Forms.TextBox();
      this.classTextBox = new System.Windows.Forms.TextBox();
      this.enrollTextBox = new System.Windows.Forms.TextBox();
      this.waitTextBox = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.enrollListBox = new System.Windows.Forms.ListBox();
      this.waitListBox = new System.Windows.Forms.ListBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // studentListBox
      // 
      this.studentListBox.FormattingEnabled = true;
      this.studentListBox.ItemHeight = 31;
      this.studentListBox.Location = new System.Drawing.Point(12, 140);
      this.studentListBox.Name = "studentListBox";
      this.studentListBox.Size = new System.Drawing.Size(612, 717);
      this.studentListBox.TabIndex = 0;
      this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(2370, 49);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
      this.loadToolStripMenuItem.Text = "Load";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // resetDatabaseToolStripMenuItem
      // 
      this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
      this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
      this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(166, 32);
      this.label1.TabIndex = 2;
      this.label1.Text = "STUDENTS";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(678, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(154, 32);
      this.label2.TabIndex = 3;
      this.label2.Text = "COURSES";
      // 
      // coursesListBox
      // 
      this.coursesListBox.FormattingEnabled = true;
      this.coursesListBox.ItemHeight = 31;
      this.coursesListBox.Location = new System.Drawing.Point(675, 140);
      this.coursesListBox.Name = "coursesListBox";
      this.coursesListBox.Size = new System.Drawing.Size(459, 717);
      this.coursesListBox.TabIndex = 4;
      this.coursesListBox.SelectedIndexChanged += new System.EventHandler(this.coursesListBox_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(1198, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(170, 32);
      this.label3.TabIndex = 5;
      this.label3.Text = "SEMESTER";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(1413, 88);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 32);
      this.label4.TabIndex = 6;
      this.label4.Text = "YEAR";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(1638, 88);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 32);
      this.label5.TabIndex = 7;
      this.label5.Text = "TYPE";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(1851, 88);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 32);
      this.label6.TabIndex = 8;
      this.label6.Text = "DAY";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(1851, 228);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(81, 32);
      this.label7.TabIndex = 9;
      this.label7.Text = "TIME";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(1413, 228);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(177, 32);
      this.label8.TabIndex = 10;
      this.label8.Text = "CLASS SIZE";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(1634, 228);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(167, 32);
      this.label9.TabIndex = 11;
      this.label9.Text = "ENROLLED";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(1198, 228);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(143, 32);
      this.label10.TabIndex = 12;
      this.label10.Text = "WAITLIST";
      // 
      // semesterTextBox
      // 
      this.semesterTextBox.Location = new System.Drawing.Point(1204, 140);
      this.semesterTextBox.Name = "semesterTextBox";
      this.semesterTextBox.Size = new System.Drawing.Size(164, 38);
      this.semesterTextBox.TabIndex = 13;
      // 
      // yearTextBox
      // 
      this.yearTextBox.Location = new System.Drawing.Point(1419, 140);
      this.yearTextBox.Name = "yearTextBox";
      this.yearTextBox.Size = new System.Drawing.Size(164, 38);
      this.yearTextBox.TabIndex = 14;
      // 
      // typeTextBox
      // 
      this.typeTextBox.Location = new System.Drawing.Point(1644, 140);
      this.typeTextBox.Name = "typeTextBox";
      this.typeTextBox.Size = new System.Drawing.Size(164, 38);
      this.typeTextBox.TabIndex = 15;
      // 
      // dayTextBox
      // 
      this.dayTextBox.Location = new System.Drawing.Point(1857, 140);
      this.dayTextBox.Name = "dayTextBox";
      this.dayTextBox.Size = new System.Drawing.Size(164, 38);
      this.dayTextBox.TabIndex = 16;
      // 
      // timeTextBox
      // 
      this.timeTextBox.Location = new System.Drawing.Point(1857, 276);
      this.timeTextBox.Name = "timeTextBox";
      this.timeTextBox.Size = new System.Drawing.Size(164, 38);
      this.timeTextBox.TabIndex = 17;
      // 
      // classTextBox
      // 
      this.classTextBox.Location = new System.Drawing.Point(1425, 276);
      this.classTextBox.Name = "classTextBox";
      this.classTextBox.Size = new System.Drawing.Size(164, 38);
      this.classTextBox.TabIndex = 18;
      // 
      // enrollTextBox
      // 
      this.enrollTextBox.Location = new System.Drawing.Point(1204, 276);
      this.enrollTextBox.Name = "enrollTextBox";
      this.enrollTextBox.Size = new System.Drawing.Size(164, 38);
      this.enrollTextBox.TabIndex = 19;
      // 
      // waitTextBox
      // 
      this.waitTextBox.Location = new System.Drawing.Point(1640, 276);
      this.waitTextBox.Name = "waitTextBox";
      this.waitTextBox.Size = new System.Drawing.Size(164, 38);
      this.waitTextBox.TabIndex = 20;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(1198, 414);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(325, 32);
      this.label11.TabIndex = 21;
      this.label11.Text = "STUDENTS ENROLLED";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(1638, 414);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(350, 32);
      this.label12.TabIndex = 22;
      this.label12.Text = "STUDENTS ON WAITLIST";
      // 
      // enrollListBox
      // 
      this.enrollListBox.FormattingEnabled = true;
      this.enrollListBox.ItemHeight = 31;
      this.enrollListBox.Location = new System.Drawing.Point(1209, 479);
      this.enrollListBox.Name = "enrollListBox";
      this.enrollListBox.Size = new System.Drawing.Size(380, 376);
      this.enrollListBox.TabIndex = 23;
      // 
      // waitListBox
      // 
      this.waitListBox.FormattingEnabled = true;
      this.waitListBox.ItemHeight = 31;
      this.waitListBox.Location = new System.Drawing.Point(1640, 479);
      this.waitListBox.Name = "waitListBox";
      this.waitListBox.Size = new System.Drawing.Size(381, 376);
      this.waitListBox.TabIndex = 24;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(2370, 1096);
      this.Controls.Add(this.waitListBox);
      this.Controls.Add(this.enrollListBox);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.waitTextBox);
      this.Controls.Add(this.enrollTextBox);
      this.Controls.Add(this.classTextBox);
      this.Controls.Add(this.timeTextBox);
      this.Controls.Add(this.dayTextBox);
      this.Controls.Add(this.typeTextBox);
      this.Controls.Add(this.yearTextBox);
      this.Controls.Add(this.semesterTextBox);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.coursesListBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.studentListBox);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox studentListBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox coursesListBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox semesterTextBox;
    private System.Windows.Forms.TextBox yearTextBox;
    private System.Windows.Forms.TextBox typeTextBox;
    private System.Windows.Forms.TextBox dayTextBox;
    private System.Windows.Forms.TextBox timeTextBox;
    private System.Windows.Forms.TextBox classTextBox;
    private System.Windows.Forms.TextBox enrollTextBox;
    private System.Windows.Forms.TextBox waitTextBox;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ListBox enrollListBox;
    private System.Windows.Forms.ListBox waitListBox;
  }
}

