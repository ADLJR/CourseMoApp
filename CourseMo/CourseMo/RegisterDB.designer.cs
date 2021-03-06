﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseMo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RegisterDB")]
	public partial class RegisterDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertRegistered(Registered instance);
    partial void UpdateRegistered(Registered instance);
    partial void DeleteRegistered(Registered instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertWaitlist(Waitlist instance);
    partial void UpdateWaitlist(Waitlist instance);
    partial void DeleteWaitlist(Waitlist instance);
    #endregion
		
		public RegisterDBDataContext() : 
				base(global::CourseMo.Properties.Settings.Default.RegisterDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RegisterDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegisterDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegisterDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegisterDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Registered> Registereds
		{
			get
			{
				return this.GetTable<Registered>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Waitlist> Waitlists
		{
			get
			{
				return this.GetTable<Waitlist>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CRN;
		
		private string _Abbrev;
		
		private int _CID;
		
		private string _Semester;
		
		private System.Nullable<int> _Term;
		
		private string _CType;
		
		private string _CDay;
		
		private string _CTime;
		
		private System.Nullable<int> _CSize;
		
		private EntitySet<Registered> _Registereds;
		
		private EntitySet<Waitlist> _Waitlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnAbbrevChanging(string value);
    partial void OnAbbrevChanged();
    partial void OnCIDChanging(int value);
    partial void OnCIDChanged();
    partial void OnSemesterChanging(string value);
    partial void OnSemesterChanged();
    partial void OnTermChanging(System.Nullable<int> value);
    partial void OnTermChanged();
    partial void OnCTypeChanging(string value);
    partial void OnCTypeChanged();
    partial void OnCDayChanging(string value);
    partial void OnCDayChanged();
    partial void OnCTimeChanging(string value);
    partial void OnCTimeChanged();
    partial void OnCSizeChanging(System.Nullable<int> value);
    partial void OnCSizeChanged();
    #endregion
		
		public Course()
		{
			this._Registereds = new EntitySet<Registered>(new Action<Registered>(this.attach_Registereds), new Action<Registered>(this.detach_Registereds));
			this._Waitlists = new EntitySet<Waitlist>(new Action<Waitlist>(this.attach_Waitlists), new Action<Waitlist>(this.detach_Waitlists));
			OnCreated();
		}

    public override string ToString()
    {
      return String.Format("{0} : {1} {2}", _CRN, _Abbrev, _CID);
    }

    [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abbrev", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Abbrev
		{
			get
			{
				return this._Abbrev;
			}
			set
			{
				if ((this._Abbrev != value))
				{
					this.OnAbbrevChanging(value);
					this.SendPropertyChanging();
					this._Abbrev = value;
					this.SendPropertyChanged("Abbrev");
					this.OnAbbrevChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CID", DbType="Int NOT NULL")]
		public int CID
		{
			get
			{
				return this._CID;
			}
			set
			{
				if ((this._CID != value))
				{
					this.OnCIDChanging(value);
					this.SendPropertyChanging();
					this._CID = value;
					this.SendPropertyChanged("CID");
					this.OnCIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Semester", DbType="NVarChar(64)")]
		public string Semester
		{
			get
			{
				return this._Semester;
			}
			set
			{
				if ((this._Semester != value))
				{
					this.OnSemesterChanging(value);
					this.SendPropertyChanging();
					this._Semester = value;
					this.SendPropertyChanged("Semester");
					this.OnSemesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Term", DbType="Int")]
		public System.Nullable<int> Term
		{
			get
			{
				return this._Term;
			}
			set
			{
				if ((this._Term != value))
				{
					this.OnTermChanging(value);
					this.SendPropertyChanging();
					this._Term = value;
					this.SendPropertyChanged("Term");
					this.OnTermChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CType", DbType="NVarChar(64)")]
		public string CType
		{
			get
			{
				return this._CType;
			}
			set
			{
				if ((this._CType != value))
				{
					this.OnCTypeChanging(value);
					this.SendPropertyChanging();
					this._CType = value;
					this.SendPropertyChanged("CType");
					this.OnCTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDay", DbType="NVarChar(64)")]
		public string CDay
		{
			get
			{
				return this._CDay;
			}
			set
			{
				if ((this._CDay != value))
				{
					this.OnCDayChanging(value);
					this.SendPropertyChanging();
					this._CDay = value;
					this.SendPropertyChanged("CDay");
					this.OnCDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTime", DbType="NVarChar(64)")]
		public string CTime
		{
			get
			{
				return this._CTime;
			}
			set
			{
				if ((this._CTime != value))
				{
					this.OnCTimeChanging(value);
					this.SendPropertyChanging();
					this._CTime = value;
					this.SendPropertyChanged("CTime");
					this.OnCTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSize", DbType="Int")]
		public System.Nullable<int> CSize
		{
			get
			{
				return this._CSize;
			}
			set
			{
				if ((this._CSize != value))
				{
					this.OnCSizeChanging(value);
					this.SendPropertyChanging();
					this._CSize = value;
					this.SendPropertyChanged("CSize");
					this.OnCSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Registered", Storage="_Registereds", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<Registered> Registereds
		{
			get
			{
				return this._Registereds;
			}
			set
			{
				this._Registereds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Waitlist", Storage="_Waitlists", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<Waitlist> Waitlists
		{
			get
			{
				return this._Waitlists;
			}
			set
			{
				this._Waitlists.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Registereds(Registered entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Registereds(Registered entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
		
		private void attach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Registered")]
	public partial class Registered : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RIN;
		
		private int _CRN;
		
		private string _NetID;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRINChanging(int value);
    partial void OnRINChanged();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    #endregion
		
		public Registered()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RIN", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RIN
		{
			get
			{
				return this._RIN;
			}
			set
			{
				if ((this._RIN != value))
				{
					this.OnRINChanging(value);
					this.SendPropertyChanging();
					this._RIN = value;
					this.SendPropertyChanged("RIN");
					this.OnRINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL")]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Registered", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Registereds.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Registereds.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Registered", Storage="_Student", ThisKey="NetID", OtherKey="NetID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Registereds.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Registereds.Add(this);
						this._NetID = value.NetID;
					}
					else
					{
						this._NetID = default(string);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NetID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private EntitySet<Registered> _Registereds;
		
		private EntitySet<Waitlist> _Waitlists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    #endregion
		
		public Student()
		{
			this._Registereds = new EntitySet<Registered>(new Action<Registered>(this.attach_Registereds), new Action<Registered>(this.detach_Registereds));
			this._Waitlists = new EntitySet<Waitlist>(new Action<Waitlist>(this.attach_Waitlists), new Action<Waitlist>(this.detach_Waitlists));
			OnCreated();
		}

    public override string ToString()
    {
      return string.Format("{0}, {1} < {2} >" , _LastName, _FirstName, _NetID);
    }

    [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(64) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Registered", Storage="_Registereds", ThisKey="NetID", OtherKey="NetID")]
		public EntitySet<Registered> Registereds
		{
			get
			{
				return this._Registereds;
			}
			set
			{
				this._Registereds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Waitlist", Storage="_Waitlists", ThisKey="NetID", OtherKey="NetID")]
		public EntitySet<Waitlist> Waitlists
		{
			get
			{
				return this._Waitlists;
			}
			set
			{
				this._Waitlists.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Registereds(Registered entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Registereds(Registered entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Waitlists(Waitlist entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Waitlist")]
	public partial class Waitlist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WID;
		
		private int _CRN;
		
		private string _NetID;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWIDChanging(int value);
    partial void OnWIDChanged();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    #endregion
		
		public Waitlist()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WID
		{
			get
			{
				return this._WID;
			}
			set
			{
				if ((this._WID != value))
				{
					this.OnWIDChanging(value);
					this.SendPropertyChanging();
					this._WID = value;
					this.SendPropertyChanged("WID");
					this.OnWIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL")]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Waitlist", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Waitlists.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Waitlists.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Waitlist", Storage="_Student", ThisKey="NetID", OtherKey="NetID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Waitlists.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Waitlists.Add(this);
						this._NetID = value.NetID;
					}
					else
					{
						this._NetID = default(string);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
