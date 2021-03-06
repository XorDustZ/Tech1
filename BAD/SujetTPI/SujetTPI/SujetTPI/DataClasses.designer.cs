﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SujetTPI
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SubjectBD")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    partial void Inserttype(type instance);
    partial void Updatetype(type instance);
    partial void Deletetype(type instance);
    partial void Insertsubject(subject instance);
    partial void Updatesubject(subject instance);
    partial void Deletesubject(subject instance);
    partial void Insertteacher(teacher instance);
    partial void Updateteacher(teacher instance);
    partial void Deleteteacher(teacher instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::SujetTPI.Properties.Settings.Default.SubjectBDConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<student> student
		{
			get
			{
				return this.GetTable<student>();
			}
		}
		
		public System.Data.Linq.Table<type> type
		{
			get
			{
				return this.GetTable<type>();
			}
		}
		
		public System.Data.Linq.Table<subject> subject
		{
			get
			{
				return this.GetTable<subject>();
			}
		}
		
		public System.Data.Linq.Table<teacher> teacher
		{
			get
			{
				return this.GetTable<teacher>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdStudent;
		
		private string _nameStudent;
		
		private string _firstNameStudent;
		
		private string _telStudent;
		
		private string _emailStudent;
		
		private System.Nullable<int> _idTeacher;
		
		private System.Nullable<int> _idSubject;
		
		private EntityRef<subject> _subject;
		
		private EntityRef<teacher> _teacher;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdStudentChanging(int value);
    partial void OnIdStudentChanged();
    partial void OnnameStudentChanging(string value);
    partial void OnnameStudentChanged();
    partial void OnfirstNameStudentChanging(string value);
    partial void OnfirstNameStudentChanged();
    partial void OntelStudentChanging(string value);
    partial void OntelStudentChanged();
    partial void OnemailStudentChanging(string value);
    partial void OnemailStudentChanged();
    partial void OnidTeacherChanging(System.Nullable<int> value);
    partial void OnidTeacherChanged();
    partial void OnidSubjectChanging(System.Nullable<int> value);
    partial void OnidSubjectChanged();
    #endregion
		
		public student()
		{
			this._subject = default(EntityRef<subject>);
			this._teacher = default(EntityRef<teacher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdStudent", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdStudent
		{
			get
			{
				return this._IdStudent;
			}
			set
			{
				if ((this._IdStudent != value))
				{
					this.OnIdStudentChanging(value);
					this.SendPropertyChanging();
					this._IdStudent = value;
					this.SendPropertyChanged("IdStudent");
					this.OnIdStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameStudent", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string nameStudent
		{
			get
			{
				return this._nameStudent;
			}
			set
			{
				if ((this._nameStudent != value))
				{
					this.OnnameStudentChanging(value);
					this.SendPropertyChanging();
					this._nameStudent = value;
					this.SendPropertyChanged("nameStudent");
					this.OnnameStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstNameStudent", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string firstNameStudent
		{
			get
			{
				return this._firstNameStudent;
			}
			set
			{
				if ((this._firstNameStudent != value))
				{
					this.OnfirstNameStudentChanging(value);
					this.SendPropertyChanging();
					this._firstNameStudent = value;
					this.SendPropertyChanged("firstNameStudent");
					this.OnfirstNameStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telStudent", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string telStudent
		{
			get
			{
				return this._telStudent;
			}
			set
			{
				if ((this._telStudent != value))
				{
					this.OntelStudentChanging(value);
					this.SendPropertyChanging();
					this._telStudent = value;
					this.SendPropertyChanged("telStudent");
					this.OntelStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailStudent", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string emailStudent
		{
			get
			{
				return this._emailStudent;
			}
			set
			{
				if ((this._emailStudent != value))
				{
					this.OnemailStudentChanging(value);
					this.SendPropertyChanging();
					this._emailStudent = value;
					this.SendPropertyChanged("emailStudent");
					this.OnemailStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTeacher", DbType="Int")]
		public System.Nullable<int> idTeacher
		{
			get
			{
				return this._idTeacher;
			}
			set
			{
				if ((this._idTeacher != value))
				{
					if (this._teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTeacherChanging(value);
					this.SendPropertyChanging();
					this._idTeacher = value;
					this.SendPropertyChanged("idTeacher");
					this.OnidTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSubject", DbType="Int")]
		public System.Nullable<int> idSubject
		{
			get
			{
				return this._idSubject;
			}
			set
			{
				if ((this._idSubject != value))
				{
					if (this._subject.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidSubjectChanging(value);
					this.SendPropertyChanging();
					this._idSubject = value;
					this.SendPropertyChanged("idSubject");
					this.OnidSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subject_student", Storage="_subject", ThisKey="idSubject", OtherKey="IdSubject", IsForeignKey=true)]
		public subject subject
		{
			get
			{
				return this._subject.Entity;
			}
			set
			{
				subject previousValue = this._subject.Entity;
				if (((previousValue != value) 
							|| (this._subject.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._subject.Entity = null;
						previousValue.student.Remove(this);
					}
					this._subject.Entity = value;
					if ((value != null))
					{
						value.student.Add(this);
						this._idSubject = value.IdSubject;
					}
					else
					{
						this._idSubject = default(Nullable<int>);
					}
					this.SendPropertyChanged("subject");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teacher_student", Storage="_teacher", ThisKey="idTeacher", OtherKey="IdTeacher", IsForeignKey=true)]
		public teacher teacher
		{
			get
			{
				return this._teacher.Entity;
			}
			set
			{
				teacher previousValue = this._teacher.Entity;
				if (((previousValue != value) 
							|| (this._teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._teacher.Entity = null;
						previousValue.student.Remove(this);
					}
					this._teacher.Entity = value;
					if ((value != null))
					{
						value.student.Add(this);
						this._idTeacher = value.IdTeacher;
					}
					else
					{
						this._idTeacher = default(Nullable<int>);
					}
					this.SendPropertyChanged("teacher");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.type")]
	public partial class type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdType;
		
		private string _nameType;
		
		private EntitySet<subject> _subject;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTypeChanging(int value);
    partial void OnIdTypeChanged();
    partial void OnnameTypeChanging(string value);
    partial void OnnameTypeChanged();
    #endregion
		
		public type()
		{
			this._subject = new EntitySet<subject>(new Action<subject>(this.attach_subject), new Action<subject>(this.detach_subject));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdType", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdType
		{
			get
			{
				return this._IdType;
			}
			set
			{
				if ((this._IdType != value))
				{
					this.OnIdTypeChanging(value);
					this.SendPropertyChanging();
					this._IdType = value;
					this.SendPropertyChanged("IdType");
					this.OnIdTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameType", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string nameType
		{
			get
			{
				return this._nameType;
			}
			set
			{
				if ((this._nameType != value))
				{
					this.OnnameTypeChanging(value);
					this.SendPropertyChanging();
					this._nameType = value;
					this.SendPropertyChanged("nameType");
					this.OnnameTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_subject", Storage="_subject", ThisKey="IdType", OtherKey="idType")]
		public EntitySet<subject> subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				this._subject.Assign(value);
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
		
		private void attach_subject(subject entity)
		{
			this.SendPropertyChanging();
			entity.type = this;
		}
		
		private void detach_subject(subject entity)
		{
			this.SendPropertyChanging();
			entity.type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.subject")]
	public partial class subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdSubject;
		
		private int _idType;
		
		private string _nameSubject;
		
		private string _dateSubject;
		
		private string _placeSubject;
		
		private string _titleSubject;
		
		private string _environnementSubject;
		
		private string _objectiveSubject;
		
		private string _descriptionSubject;
		
		private string _conceptualSubject;
		
		private string _stepsInventorySubject;
		
		private string _equipmentSubject;
		
		private string _deliverableSubject;
		
		private string _mesurableSubject;
		
		private int _idCreator;
		
		private EntitySet<student> _student;
		
		private EntityRef<type> _type;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSubjectChanging(int value);
    partial void OnIdSubjectChanged();
    partial void OnidTypeChanging(int value);
    partial void OnidTypeChanged();
    partial void OnnameSubjectChanging(string value);
    partial void OnnameSubjectChanged();
    partial void OndateSubjectChanging(string value);
    partial void OndateSubjectChanged();
    partial void OnplaceSubjectChanging(string value);
    partial void OnplaceSubjectChanged();
    partial void OntitleSubjectChanging(string value);
    partial void OntitleSubjectChanged();
    partial void OnenvironnementSubjectChanging(string value);
    partial void OnenvironnementSubjectChanged();
    partial void OnobjectiveSubjectChanging(string value);
    partial void OnobjectiveSubjectChanged();
    partial void OndescriptionSubjectChanging(string value);
    partial void OndescriptionSubjectChanged();
    partial void OnconceptualSubjectChanging(string value);
    partial void OnconceptualSubjectChanged();
    partial void OnstepsInventorySubjectChanging(string value);
    partial void OnstepsInventorySubjectChanged();
    partial void OnequipmentSubjectChanging(string value);
    partial void OnequipmentSubjectChanged();
    partial void OndeliverableSubjectChanging(string value);
    partial void OndeliverableSubjectChanged();
    partial void OnmesurableSubjectChanging(string value);
    partial void OnmesurableSubjectChanged();
    partial void OnidCreatorChanging(int value);
    partial void OnidCreatorChanged();
    #endregion
		
		public subject()
		{
			this._student = new EntitySet<student>(new Action<student>(this.attach_student), new Action<student>(this.detach_student));
			this._type = default(EntityRef<type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSubject", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdSubject
		{
			get
			{
				return this._IdSubject;
			}
			set
			{
				if ((this._IdSubject != value))
				{
					this.OnIdSubjectChanging(value);
					this.SendPropertyChanging();
					this._IdSubject = value;
					this.SendPropertyChanged("IdSubject");
					this.OnIdSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idType", DbType="Int NOT NULL")]
		public int idType
		{
			get
			{
				return this._idType;
			}
			set
			{
				if ((this._idType != value))
				{
					if (this._type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTypeChanging(value);
					this.SendPropertyChanging();
					this._idType = value;
					this.SendPropertyChanged("idType");
					this.OnidTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string nameSubject
		{
			get
			{
				return this._nameSubject;
			}
			set
			{
				if ((this._nameSubject != value))
				{
					this.OnnameSubjectChanging(value);
					this.SendPropertyChanging();
					this._nameSubject = value;
					this.SendPropertyChanged("nameSubject");
					this.OnnameSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string dateSubject
		{
			get
			{
				return this._dateSubject;
			}
			set
			{
				if ((this._dateSubject != value))
				{
					this.OndateSubjectChanging(value);
					this.SendPropertyChanging();
					this._dateSubject = value;
					this.SendPropertyChanged("dateSubject");
					this.OndateSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_placeSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string placeSubject
		{
			get
			{
				return this._placeSubject;
			}
			set
			{
				if ((this._placeSubject != value))
				{
					this.OnplaceSubjectChanging(value);
					this.SendPropertyChanging();
					this._placeSubject = value;
					this.SendPropertyChanged("placeSubject");
					this.OnplaceSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titleSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string titleSubject
		{
			get
			{
				return this._titleSubject;
			}
			set
			{
				if ((this._titleSubject != value))
				{
					this.OntitleSubjectChanging(value);
					this.SendPropertyChanging();
					this._titleSubject = value;
					this.SendPropertyChanged("titleSubject");
					this.OntitleSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_environnementSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string environnementSubject
		{
			get
			{
				return this._environnementSubject;
			}
			set
			{
				if ((this._environnementSubject != value))
				{
					this.OnenvironnementSubjectChanging(value);
					this.SendPropertyChanging();
					this._environnementSubject = value;
					this.SendPropertyChanged("environnementSubject");
					this.OnenvironnementSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_objectiveSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string objectiveSubject
		{
			get
			{
				return this._objectiveSubject;
			}
			set
			{
				if ((this._objectiveSubject != value))
				{
					this.OnobjectiveSubjectChanging(value);
					this.SendPropertyChanging();
					this._objectiveSubject = value;
					this.SendPropertyChanged("objectiveSubject");
					this.OnobjectiveSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descriptionSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string descriptionSubject
		{
			get
			{
				return this._descriptionSubject;
			}
			set
			{
				if ((this._descriptionSubject != value))
				{
					this.OndescriptionSubjectChanging(value);
					this.SendPropertyChanging();
					this._descriptionSubject = value;
					this.SendPropertyChanged("descriptionSubject");
					this.OndescriptionSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_conceptualSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string conceptualSubject
		{
			get
			{
				return this._conceptualSubject;
			}
			set
			{
				if ((this._conceptualSubject != value))
				{
					this.OnconceptualSubjectChanging(value);
					this.SendPropertyChanging();
					this._conceptualSubject = value;
					this.SendPropertyChanged("conceptualSubject");
					this.OnconceptualSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stepsInventorySubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string stepsInventorySubject
		{
			get
			{
				return this._stepsInventorySubject;
			}
			set
			{
				if ((this._stepsInventorySubject != value))
				{
					this.OnstepsInventorySubjectChanging(value);
					this.SendPropertyChanging();
					this._stepsInventorySubject = value;
					this.SendPropertyChanged("stepsInventorySubject");
					this.OnstepsInventorySubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_equipmentSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string equipmentSubject
		{
			get
			{
				return this._equipmentSubject;
			}
			set
			{
				if ((this._equipmentSubject != value))
				{
					this.OnequipmentSubjectChanging(value);
					this.SendPropertyChanging();
					this._equipmentSubject = value;
					this.SendPropertyChanged("equipmentSubject");
					this.OnequipmentSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deliverableSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string deliverableSubject
		{
			get
			{
				return this._deliverableSubject;
			}
			set
			{
				if ((this._deliverableSubject != value))
				{
					this.OndeliverableSubjectChanging(value);
					this.SendPropertyChanging();
					this._deliverableSubject = value;
					this.SendPropertyChanged("deliverableSubject");
					this.OndeliverableSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mesurableSubject", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string mesurableSubject
		{
			get
			{
				return this._mesurableSubject;
			}
			set
			{
				if ((this._mesurableSubject != value))
				{
					this.OnmesurableSubjectChanging(value);
					this.SendPropertyChanging();
					this._mesurableSubject = value;
					this.SendPropertyChanged("mesurableSubject");
					this.OnmesurableSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCreator", DbType="Int NOT NULL")]
		public int idCreator
		{
			get
			{
				return this._idCreator;
			}
			set
			{
				if ((this._idCreator != value))
				{
					this.OnidCreatorChanging(value);
					this.SendPropertyChanging();
					this._idCreator = value;
					this.SendPropertyChanged("idCreator");
					this.OnidCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="subject_student", Storage="_student", ThisKey="IdSubject", OtherKey="idSubject")]
		public EntitySet<student> student
		{
			get
			{
				return this._student;
			}
			set
			{
				this._student.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_subject", Storage="_type", ThisKey="idType", OtherKey="IdType", IsForeignKey=true)]
		public type type
		{
			get
			{
				return this._type.Entity;
			}
			set
			{
				type previousValue = this._type.Entity;
				if (((previousValue != value) 
							|| (this._type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._type.Entity = null;
						previousValue.subject.Remove(this);
					}
					this._type.Entity = value;
					if ((value != null))
					{
						value.subject.Add(this);
						this._idType = value.IdType;
					}
					else
					{
						this._idType = default(int);
					}
					this.SendPropertyChanged("type");
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
		
		private void attach_student(student entity)
		{
			this.SendPropertyChanging();
			entity.subject = this;
		}
		
		private void detach_student(student entity)
		{
			this.SendPropertyChanging();
			entity.subject = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.teacher")]
	public partial class teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdTeacher;
		
		private string _nameTeacher;
		
		private string _firstNameTeacher;
		
		private string _telTeacher;
		
		private string _emailTeacher;
		
		private int _nbStudentTeacher;
		
		private EntitySet<student> _student;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTeacherChanging(int value);
    partial void OnIdTeacherChanged();
    partial void OnnameTeacherChanging(string value);
    partial void OnnameTeacherChanged();
    partial void OnfirstNameTeacherChanging(string value);
    partial void OnfirstNameTeacherChanged();
    partial void OntelTeacherChanging(string value);
    partial void OntelTeacherChanged();
    partial void OnemailTeacherChanging(string value);
    partial void OnemailTeacherChanged();
    partial void OnnbStudentTeacherChanging(int value);
    partial void OnnbStudentTeacherChanged();
    #endregion
		
		public teacher()
		{
			this._student = new EntitySet<student>(new Action<student>(this.attach_student), new Action<student>(this.detach_student));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTeacher", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdTeacher
		{
			get
			{
				return this._IdTeacher;
			}
			set
			{
				if ((this._IdTeacher != value))
				{
					this.OnIdTeacherChanging(value);
					this.SendPropertyChanging();
					this._IdTeacher = value;
					this.SendPropertyChanged("IdTeacher");
					this.OnIdTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nameTeacher", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string nameTeacher
		{
			get
			{
				return this._nameTeacher;
			}
			set
			{
				if ((this._nameTeacher != value))
				{
					this.OnnameTeacherChanging(value);
					this.SendPropertyChanging();
					this._nameTeacher = value;
					this.SendPropertyChanged("nameTeacher");
					this.OnnameTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstNameTeacher", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string firstNameTeacher
		{
			get
			{
				return this._firstNameTeacher;
			}
			set
			{
				if ((this._firstNameTeacher != value))
				{
					this.OnfirstNameTeacherChanging(value);
					this.SendPropertyChanging();
					this._firstNameTeacher = value;
					this.SendPropertyChanged("firstNameTeacher");
					this.OnfirstNameTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telTeacher", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string telTeacher
		{
			get
			{
				return this._telTeacher;
			}
			set
			{
				if ((this._telTeacher != value))
				{
					this.OntelTeacherChanging(value);
					this.SendPropertyChanging();
					this._telTeacher = value;
					this.SendPropertyChanged("telTeacher");
					this.OntelTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailTeacher", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string emailTeacher
		{
			get
			{
				return this._emailTeacher;
			}
			set
			{
				if ((this._emailTeacher != value))
				{
					this.OnemailTeacherChanging(value);
					this.SendPropertyChanging();
					this._emailTeacher = value;
					this.SendPropertyChanged("emailTeacher");
					this.OnemailTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbStudentTeacher", DbType="Int NOT NULL")]
		public int nbStudentTeacher
		{
			get
			{
				return this._nbStudentTeacher;
			}
			set
			{
				if ((this._nbStudentTeacher != value))
				{
					this.OnnbStudentTeacherChanging(value);
					this.SendPropertyChanging();
					this._nbStudentTeacher = value;
					this.SendPropertyChanged("nbStudentTeacher");
					this.OnnbStudentTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teacher_student", Storage="_student", ThisKey="IdTeacher", OtherKey="idTeacher")]
		public EntitySet<student> student
		{
			get
			{
				return this._student;
			}
			set
			{
				this._student.Assign(value);
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
		
		private void attach_student(student entity)
		{
			this.SendPropertyChanging();
			entity.teacher = this;
		}
		
		private void detach_student(student entity)
		{
			this.SendPropertyChanging();
			entity.teacher = null;
		}
	}
}
#pragma warning restore 1591
