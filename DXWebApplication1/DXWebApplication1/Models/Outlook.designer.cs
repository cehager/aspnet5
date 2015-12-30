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

namespace DXWebApplication1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Data")]
	public partial class OutlookDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertAppointment(Appointment instance);
    partial void UpdateAppointment(Appointment instance);
    partial void DeleteAppointment(Appointment instance);
    #endregion
		
		public OutlookDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OutlookDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OutlookDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OutlookDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OutlookDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<Appointment> Appointments
		{
			get
			{
				return this.GetTable<Appointment>();
			}
		}
		
		public System.Data.Linq.Table<Resource> Resources
		{
			get
			{
				return this.GetTable<Resource>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Date;
		
		private string _From;
		
		private string _Subject;
		
		private string _Text;
		
		private bool _HasAttachment;
		
		private string _Folder;
		
		private bool _IsReply;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnHasAttachmentChanging(bool value);
    partial void OnHasAttachmentChanged();
    partial void OnFolderChanging(string value);
    partial void OnFolderChanged();
    partial void OnIsReplyChanging(bool value);
    partial void OnIsReplyChanged();
    #endregion
		
		public Message()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string From
		{
			get
			{
				return this._From;
			}
			set
			{
				if ((this._From != value))
				{
					this.OnFromChanging(value);
					this.SendPropertyChanging();
					this._From = value;
					this.SendPropertyChanged("From");
					this.OnFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasAttachment", DbType="Bit NOT NULL")]
		public bool HasAttachment
		{
			get
			{
				return this._HasAttachment;
			}
			set
			{
				if ((this._HasAttachment != value))
				{
					this.OnHasAttachmentChanging(value);
					this.SendPropertyChanging();
					this._HasAttachment = value;
					this.SendPropertyChanged("HasAttachment");
					this.OnHasAttachmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Folder", DbType="NVarChar(16)")]
		public string Folder
		{
			get
			{
				return this._Folder;
			}
			set
			{
				if ((this._Folder != value))
				{
					this.OnFolderChanging(value);
					this.SendPropertyChanging();
					this._Folder = value;
					this.SendPropertyChanged("Folder");
					this.OnFolderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsReply", DbType="Bit NOT NULL")]
		public bool IsReply
		{
			get
			{
				return this._IsReply;
			}
			set
			{
				if ((this._IsReply != value))
				{
					this.OnIsReplyChanging(value);
					this.SendPropertyChanging();
					this._IsReply = value;
					this.SendPropertyChanged("IsReply");
					this.OnIsReplyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Appointments")]
	public partial class Appointment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _EventType;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
		private System.Nullable<bool> _AllDay;
		
		private string _Subject;
		
		private string _Location;
		
		private string _Description;
		
		private System.Nullable<int> _Status;
		
		private System.Nullable<int> _Label;
		
		private System.Nullable<int> _ResourceID;
		
		private string _RecurrenceInfo;
		
		private string _ReminderInfo;
		
		private string _ContactInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEventTypeChanging(System.Nullable<int> value);
    partial void OnEventTypeChanged();
    partial void OnStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    partial void OnAllDayChanging(System.Nullable<bool> value);
    partial void OnAllDayChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnStatusChanging(System.Nullable<int> value);
    partial void OnStatusChanged();
    partial void OnLabelChanging(System.Nullable<int> value);
    partial void OnLabelChanged();
    partial void OnResourceIDChanging(System.Nullable<int> value);
    partial void OnResourceIDChanged();
    partial void OnRecurrenceInfoChanging(string value);
    partial void OnRecurrenceInfoChanged();
    partial void OnReminderInfoChanging(string value);
    partial void OnReminderInfoChanged();
    partial void OnContactInfoChanging(string value);
    partial void OnContactInfoChanged();
    #endregion
		
		public Appointment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventType", DbType="Int")]
		public System.Nullable<int> EventType
		{
			get
			{
				return this._EventType;
			}
			set
			{
				if ((this._EventType != value))
				{
					this.OnEventTypeChanging(value);
					this.SendPropertyChanging();
					this._EventType = value;
					this.SendPropertyChanged("EventType");
					this.OnEventTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AllDay", DbType="Bit")]
		public System.Nullable<bool> AllDay
		{
			get
			{
				return this._AllDay;
			}
			set
			{
				if ((this._AllDay != value))
				{
					this.OnAllDayChanging(value);
					this.SendPropertyChanging();
					this._AllDay = value;
					this.SendPropertyChanged("AllDay");
					this.OnAllDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(MAX)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(MAX)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Label", DbType="Int")]
		public System.Nullable<int> Label
		{
			get
			{
				return this._Label;
			}
			set
			{
				if ((this._Label != value))
				{
					this.OnLabelChanging(value);
					this.SendPropertyChanging();
					this._Label = value;
					this.SendPropertyChanged("Label");
					this.OnLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceID", DbType="Int")]
		public System.Nullable<int> ResourceID
		{
			get
			{
				return this._ResourceID;
			}
			set
			{
				if ((this._ResourceID != value))
				{
					this.OnResourceIDChanging(value);
					this.SendPropertyChanging();
					this._ResourceID = value;
					this.SendPropertyChanged("ResourceID");
					this.OnResourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecurrenceInfo", DbType="NVarChar(MAX)")]
		public string RecurrenceInfo
		{
			get
			{
				return this._RecurrenceInfo;
			}
			set
			{
				if ((this._RecurrenceInfo != value))
				{
					this.OnRecurrenceInfoChanging(value);
					this.SendPropertyChanging();
					this._RecurrenceInfo = value;
					this.SendPropertyChanged("RecurrenceInfo");
					this.OnRecurrenceInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReminderInfo", DbType="NVarChar(MAX)")]
		public string ReminderInfo
		{
			get
			{
				return this._ReminderInfo;
			}
			set
			{
				if ((this._ReminderInfo != value))
				{
					this.OnReminderInfoChanging(value);
					this.SendPropertyChanging();
					this._ReminderInfo = value;
					this.SendPropertyChanged("ReminderInfo");
					this.OnReminderInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactInfo", DbType="NVarChar(MAX)")]
		public string ContactInfo
		{
			get
			{
				return this._ContactInfo;
			}
			set
			{
				if ((this._ContactInfo != value))
				{
					this.OnContactInfoChanging(value);
					this.SendPropertyChanging();
					this._ContactInfo = value;
					this.SendPropertyChanged("ContactInfo");
					this.OnContactInfoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Resources")]
	public partial class Resource
	{
		
		private int _ID;
		
		private string _Name;
		
		public Resource()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
