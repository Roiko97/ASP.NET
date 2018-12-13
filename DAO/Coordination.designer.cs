﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Coordination")]
	public partial class CoordinationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertusers(users instance);
    partial void Updateusers(users instance);
    partial void Deleteusers(users instance);
    partial void Insertteam(team instance);
    partial void Updateteam(team instance);
    partial void Deleteteam(team instance);
    #endregion
		
		public CoordinationDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CoordinationConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CoordinationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoordinationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoordinationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoordinationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<users> users
		{
			get
			{
				return this.GetTable<users>();
			}
		}
		
		public System.Data.Linq.Table<team> team
		{
			get
			{
				return this.GetTable<team>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _student_id;
		
		private string _student_name;
		
		private string _password;
		
		private string _avatar;
		
		private string _mark;
		
		private System.Nullable<int> _states;
		
		private string _position;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onstudent_idChanging(string value);
    partial void Onstudent_idChanged();
    partial void Onstudent_nameChanging(string value);
    partial void Onstudent_nameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnavatarChanging(string value);
    partial void OnavatarChanged();
    partial void OnmarkChanging(string value);
    partial void OnmarkChanged();
    partial void OnstatesChanging(System.Nullable<int> value);
    partial void OnstatesChanged();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    #endregion
		
		public users()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_id", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string student_id
		{
			get
			{
				return this._student_id;
			}
			set
			{
				if ((this._student_id != value))
				{
					this.Onstudent_idChanging(value);
					this.SendPropertyChanging();
					this._student_id = value;
					this.SendPropertyChanged("student_id");
					this.Onstudent_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string student_name
		{
			get
			{
				return this._student_name;
			}
			set
			{
				if ((this._student_name != value))
				{
					this.Onstudent_nameChanging(value);
					this.SendPropertyChanging();
					this._student_name = value;
					this.SendPropertyChanged("student_name");
					this.Onstudent_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_avatar", DbType="VarChar(200)")]
		public string avatar
		{
			get
			{
				return this._avatar;
			}
			set
			{
				if ((this._avatar != value))
				{
					this.OnavatarChanging(value);
					this.SendPropertyChanging();
					this._avatar = value;
					this.SendPropertyChanged("avatar");
					this.OnavatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mark", DbType="VarChar(10)")]
		public string mark
		{
			get
			{
				return this._mark;
			}
			set
			{
				if ((this._mark != value))
				{
					this.OnmarkChanging(value);
					this.SendPropertyChanging();
					this._mark = value;
					this.SendPropertyChanged("mark");
					this.OnmarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_states", DbType="Int")]
		public System.Nullable<int> states
		{
			get
			{
				return this._states;
			}
			set
			{
				if ((this._states != value))
				{
					this.OnstatesChanging(value);
					this.SendPropertyChanging();
					this._states = value;
					this.SendPropertyChanged("states");
					this.OnstatesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="VarChar(30)")]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.team")]
	public partial class team : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _mark;
		
		private string _heading;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmarkChanging(string value);
    partial void OnmarkChanged();
    partial void OnheadingChanging(string value);
    partial void OnheadingChanged();
    #endregion
		
		public team()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mark", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string mark
		{
			get
			{
				return this._mark;
			}
			set
			{
				if ((this._mark != value))
				{
					this.OnmarkChanging(value);
					this.SendPropertyChanging();
					this._mark = value;
					this.SendPropertyChanged("mark");
					this.OnmarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_heading", DbType="VarChar(30)")]
		public string heading
		{
			get
			{
				return this._heading;
			}
			set
			{
				if ((this._heading != value))
				{
					this.OnheadingChanging(value);
					this.SendPropertyChanging();
					this._heading = value;
					this.SendPropertyChanged("heading");
					this.OnheadingChanged();
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
