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

namespace StoreProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Store")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertauthorizeduser(authorizeduser instance);
    partial void Updateauthorizeduser(authorizeduser instance);
    partial void Deleteauthorizeduser(authorizeduser instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::StoreProject.Properties.Settings.Default.StoreConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<authorizeduser> authorizedusers
		{
			get
			{
				return this.GetTable<authorizeduser>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.authorizedusers")]
	public partial class authorizeduser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _email;
		
		private string _userPassword;
		
		private System.Nullable<decimal> _balance;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnuserPasswordChanging(string value);
    partial void OnuserPasswordChanged();
    partial void OnbalanceChanging(System.Nullable<decimal> value);
    partial void OnbalanceChanged();
    #endregion
		
		public authorizeduser()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPassword", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string userPassword
		{
			get
			{
				return this._userPassword;
			}
			set
			{
				if ((this._userPassword != value))
				{
					this.OnuserPasswordChanging(value);
					this.SendPropertyChanging();
					this._userPassword = value;
					this.SendPropertyChanged("userPassword");
					this.OnuserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authorizeduser_order", Storage="_orders", ThisKey="id", OtherKey="customerID")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
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
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.authorizeduser = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.authorizeduser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _itemName;
		
		private decimal _itemCost;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnitemNameChanging(string value);
    partial void OnitemNameChanged();
    partial void OnitemCostChanging(decimal value);
    partial void OnitemCostChanged();
    #endregion
		
		public Item()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string itemName
		{
			get
			{
				return this._itemName;
			}
			set
			{
				if ((this._itemName != value))
				{
					this.OnitemNameChanging(value);
					this.SendPropertyChanging();
					this._itemName = value;
					this.SendPropertyChanged("itemName");
					this.OnitemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemCost", DbType="Decimal(5,2) NOT NULL")]
		public decimal itemCost
		{
			get
			{
				return this._itemCost;
			}
			set
			{
				if ((this._itemCost != value))
				{
					this.OnitemCostChanging(value);
					this.SendPropertyChanging();
					this._itemCost = value;
					this.SendPropertyChanged("itemCost");
					this.OnitemCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_order", Storage="_orders", ThisKey="id", OtherKey="ItemID")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
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
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customerID;
		
		private int _ItemID;
		
		private int _quantity;
		
		private System.DateTime _datePurchased;
		
		private EntityRef<authorizeduser> _authorizeduser;
		
		private EntityRef<Item> _Item;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncustomerIDChanging(int value);
    partial void OncustomerIDChanged();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OndatePurchasedChanging(System.DateTime value);
    partial void OndatePurchasedChanged();
    #endregion
		
		public order()
		{
			this._authorizeduser = default(EntityRef<authorizeduser>);
			this._Item = default(EntityRef<Item>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int customerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((this._customerID != value))
				{
					if (this._authorizeduser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("customerID");
					this.OncustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datePurchased", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime datePurchased
		{
			get
			{
				return this._datePurchased;
			}
			set
			{
				if ((this._datePurchased != value))
				{
					this.OndatePurchasedChanging(value);
					this.SendPropertyChanging();
					this._datePurchased = value;
					this.SendPropertyChanged("datePurchased");
					this.OndatePurchasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authorizeduser_order", Storage="_authorizeduser", ThisKey="customerID", OtherKey="id", IsForeignKey=true)]
		public authorizeduser authorizeduser
		{
			get
			{
				return this._authorizeduser.Entity;
			}
			set
			{
				authorizeduser previousValue = this._authorizeduser.Entity;
				if (((previousValue != value) 
							|| (this._authorizeduser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._authorizeduser.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._authorizeduser.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._customerID = value.id;
					}
					else
					{
						this._customerID = default(int);
					}
					this.SendPropertyChanged("authorizeduser");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_order", Storage="_Item", ThisKey="ItemID", OtherKey="id", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._ItemID = value.id;
					}
					else
					{
						this._ItemID = default(int);
					}
					this.SendPropertyChanged("Item");
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