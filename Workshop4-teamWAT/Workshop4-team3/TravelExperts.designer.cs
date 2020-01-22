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

namespace Workshop4_team3
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TravelExperts")]
	public partial class TravelExpertsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPackage(Package instance);
    partial void UpdatePackage(Package instance);
    partial void DeletePackage(Package instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertProducts_Supplier(Products_Supplier instance);
    partial void UpdateProducts_Supplier(Products_Supplier instance);
    partial void DeleteProducts_Supplier(Products_Supplier instance);
    partial void InsertSupplier(Supplier instance);
    partial void UpdateSupplier(Supplier instance);
    partial void DeleteSupplier(Supplier instance);
    partial void InsertPackages_Products_Supplier(Packages_Products_Supplier instance);
    partial void UpdatePackages_Products_Supplier(Packages_Products_Supplier instance);
    partial void DeletePackages_Products_Supplier(Packages_Products_Supplier instance);
    #endregion
		
		public TravelExpertsDataContext() : 
				base(global::Workshop4_team3.Properties.Settings.Default.TravelExpertsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TravelExpertsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TravelExpertsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TravelExpertsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TravelExpertsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Package> Packages
		{
			get
			{
				return this.GetTable<Package>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Products_Supplier> Products_Suppliers
		{
			get
			{
				return this.GetTable<Products_Supplier>();
			}
		}
		
		public System.Data.Linq.Table<Supplier> Suppliers
		{
			get
			{
				return this.GetTable<Supplier>();
			}
		}
		
		public System.Data.Linq.Table<Packages_Products_Supplier> Packages_Products_Suppliers
		{
			get
			{
				return this.GetTable<Packages_Products_Supplier>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Packages")]
	public partial class Package : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PackageId;
		
		private string _PkgName;
		
		private System.Nullable<System.DateTime> _PkgStartDate;
		
		private System.Nullable<System.DateTime> _PkgEndDate;
		
		private string _PkgDesc;
		
		private decimal _PkgBasePrice;
		
		private System.Nullable<decimal> _PkgAgencyCommission;
		
		private EntitySet<Packages_Products_Supplier> _Packages_Products_Suppliers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPackageIdChanging(int value);
    partial void OnPackageIdChanged();
    partial void OnPkgNameChanging(string value);
    partial void OnPkgNameChanged();
    partial void OnPkgStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPkgStartDateChanged();
    partial void OnPkgEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPkgEndDateChanged();
    partial void OnPkgDescChanging(string value);
    partial void OnPkgDescChanged();
    partial void OnPkgBasePriceChanging(decimal value);
    partial void OnPkgBasePriceChanged();
    partial void OnPkgAgencyCommissionChanging(System.Nullable<decimal> value);
    partial void OnPkgAgencyCommissionChanged();
    #endregion
		
		public Package()
		{
			this._Packages_Products_Suppliers = new EntitySet<Packages_Products_Supplier>(new Action<Packages_Products_Supplier>(this.attach_Packages_Products_Suppliers), new Action<Packages_Products_Supplier>(this.detach_Packages_Products_Suppliers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PackageId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PackageId
		{
			get
			{
				return this._PackageId;
			}
			set
			{
				if ((this._PackageId != value))
				{
					this.OnPackageIdChanging(value);
					this.SendPropertyChanging();
					this._PackageId = value;
					this.SendPropertyChanged("PackageId");
					this.OnPackageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PkgName
		{
			get
			{
				return this._PkgName;
			}
			set
			{
				if ((this._PkgName != value))
				{
					this.OnPkgNameChanging(value);
					this.SendPropertyChanging();
					this._PkgName = value;
					this.SendPropertyChanged("PkgName");
					this.OnPkgNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgStartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> PkgStartDate
		{
			get
			{
				return this._PkgStartDate;
			}
			set
			{
				if ((this._PkgStartDate != value))
				{
					this.OnPkgStartDateChanging(value);
					this.SendPropertyChanging();
					this._PkgStartDate = value;
					this.SendPropertyChanged("PkgStartDate");
					this.OnPkgStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgEndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> PkgEndDate
		{
			get
			{
				return this._PkgEndDate;
			}
			set
			{
				if ((this._PkgEndDate != value))
				{
					this.OnPkgEndDateChanging(value);
					this.SendPropertyChanging();
					this._PkgEndDate = value;
					this.SendPropertyChanged("PkgEndDate");
					this.OnPkgEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgDesc", DbType="NVarChar(50)")]
		public string PkgDesc
		{
			get
			{
				return this._PkgDesc;
			}
			set
			{
				if ((this._PkgDesc != value))
				{
					this.OnPkgDescChanging(value);
					this.SendPropertyChanging();
					this._PkgDesc = value;
					this.SendPropertyChanged("PkgDesc");
					this.OnPkgDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgBasePrice", DbType="Money NOT NULL")]
		public decimal PkgBasePrice
		{
			get
			{
				return this._PkgBasePrice;
			}
			set
			{
				if ((this._PkgBasePrice != value))
				{
					this.OnPkgBasePriceChanging(value);
					this.SendPropertyChanging();
					this._PkgBasePrice = value;
					this.SendPropertyChanged("PkgBasePrice");
					this.OnPkgBasePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PkgAgencyCommission", DbType="Money")]
		public System.Nullable<decimal> PkgAgencyCommission
		{
			get
			{
				return this._PkgAgencyCommission;
			}
			set
			{
				if ((this._PkgAgencyCommission != value))
				{
					this.OnPkgAgencyCommissionChanging(value);
					this.SendPropertyChanging();
					this._PkgAgencyCommission = value;
					this.SendPropertyChanged("PkgAgencyCommission");
					this.OnPkgAgencyCommissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Package_Packages_Products_Supplier", Storage="_Packages_Products_Suppliers", ThisKey="PackageId", OtherKey="PackageId")]
		public EntitySet<Packages_Products_Supplier> Packages_Products_Suppliers
		{
			get
			{
				return this._Packages_Products_Suppliers;
			}
			set
			{
				this._Packages_Products_Suppliers.Assign(value);
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
		
		private void attach_Packages_Products_Suppliers(Packages_Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Package = this;
		}
		
		private void detach_Packages_Products_Suppliers(Packages_Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Package = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _ProdName;
		
		private EntitySet<Products_Supplier> _Products_Suppliers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProdNameChanging(string value);
    partial void OnProdNameChanged();
    #endregion
		
		public Product()
		{
			this._Products_Suppliers = new EntitySet<Products_Supplier>(new Action<Products_Supplier>(this.attach_Products_Suppliers), new Action<Products_Supplier>(this.detach_Products_Suppliers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProdName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProdName
		{
			get
			{
				return this._ProdName;
			}
			set
			{
				if ((this._ProdName != value))
				{
					this.OnProdNameChanging(value);
					this.SendPropertyChanging();
					this._ProdName = value;
					this.SendPropertyChanged("ProdName");
					this.OnProdNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Products_Supplier", Storage="_Products_Suppliers", ThisKey="ProductId", OtherKey="ProductId")]
		public EntitySet<Products_Supplier> Products_Suppliers
		{
			get
			{
				return this._Products_Suppliers;
			}
			set
			{
				this._Products_Suppliers.Assign(value);
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
		
		private void attach_Products_Suppliers(Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Products_Suppliers(Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products_Suppliers")]
	public partial class Products_Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductSupplierId;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _SupplierId;
		
		private EntitySet<Packages_Products_Supplier> _Packages_Products_Suppliers;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Supplier> _Supplier;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductSupplierIdChanging(int value);
    partial void OnProductSupplierIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnSupplierIdChanging(System.Nullable<int> value);
    partial void OnSupplierIdChanged();
    #endregion
		
		public Products_Supplier()
		{
			this._Packages_Products_Suppliers = new EntitySet<Packages_Products_Supplier>(new Action<Packages_Products_Supplier>(this.attach_Packages_Products_Suppliers), new Action<Packages_Products_Supplier>(this.detach_Packages_Products_Suppliers));
			this._Product = default(EntityRef<Product>);
			this._Supplier = default(EntityRef<Supplier>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductSupplierId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductSupplierId
		{
			get
			{
				return this._ProductSupplierId;
			}
			set
			{
				if ((this._ProductSupplierId != value))
				{
					this.OnProductSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._ProductSupplierId = value;
					this.SendPropertyChanged("ProductSupplierId");
					this.OnProductSupplierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierId", DbType="Int")]
		public System.Nullable<int> SupplierId
		{
			get
			{
				return this._SupplierId;
			}
			set
			{
				if ((this._SupplierId != value))
				{
					if (this._Supplier.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._SupplierId = value;
					this.SendPropertyChanged("SupplierId");
					this.OnSupplierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Supplier_Packages_Products_Supplier", Storage="_Packages_Products_Suppliers", ThisKey="ProductSupplierId", OtherKey="ProductSupplierId")]
		public EntitySet<Packages_Products_Supplier> Packages_Products_Suppliers
		{
			get
			{
				return this._Packages_Products_Suppliers;
			}
			set
			{
				this._Packages_Products_Suppliers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Products_Supplier", Storage="_Product", ThisKey="ProductId", OtherKey="ProductId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Products_Suppliers.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Products_Suppliers.Add(this);
						this._ProductId = value.ProductId;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Products_Supplier", Storage="_Supplier", ThisKey="SupplierId", OtherKey="SupplierId", IsForeignKey=true)]
		public Supplier Supplier
		{
			get
			{
				return this._Supplier.Entity;
			}
			set
			{
				Supplier previousValue = this._Supplier.Entity;
				if (((previousValue != value) 
							|| (this._Supplier.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Supplier.Entity = null;
						previousValue.Products_Suppliers.Remove(this);
					}
					this._Supplier.Entity = value;
					if ((value != null))
					{
						value.Products_Suppliers.Add(this);
						this._SupplierId = value.SupplierId;
					}
					else
					{
						this._SupplierId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Supplier");
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
		
		private void attach_Packages_Products_Suppliers(Packages_Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Products_Supplier = this;
		}
		
		private void detach_Packages_Products_Suppliers(Packages_Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Products_Supplier = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
	public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SupplierId;
		
		private string _SupName;
		
		private EntitySet<Products_Supplier> _Products_Suppliers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSupplierIdChanging(int value);
    partial void OnSupplierIdChanged();
    partial void OnSupNameChanging(string value);
    partial void OnSupNameChanged();
    #endregion
		
		public Supplier()
		{
			this._Products_Suppliers = new EntitySet<Products_Supplier>(new Action<Products_Supplier>(this.attach_Products_Suppliers), new Action<Products_Supplier>(this.detach_Products_Suppliers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SupplierId
		{
			get
			{
				return this._SupplierId;
			}
			set
			{
				if ((this._SupplierId != value))
				{
					this.OnSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._SupplierId = value;
					this.SendPropertyChanged("SupplierId");
					this.OnSupplierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupName", DbType="NVarChar(255)")]
		public string SupName
		{
			get
			{
				return this._SupName;
			}
			set
			{
				if ((this._SupName != value))
				{
					this.OnSupNameChanging(value);
					this.SendPropertyChanging();
					this._SupName = value;
					this.SendPropertyChanged("SupName");
					this.OnSupNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplier_Products_Supplier", Storage="_Products_Suppliers", ThisKey="SupplierId", OtherKey="SupplierId")]
		public EntitySet<Products_Supplier> Products_Suppliers
		{
			get
			{
				return this._Products_Suppliers;
			}
			set
			{
				this._Products_Suppliers.Assign(value);
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
		
		private void attach_Products_Suppliers(Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = this;
		}
		
		private void detach_Products_Suppliers(Products_Supplier entity)
		{
			this.SendPropertyChanging();
			entity.Supplier = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Packages_Products_Suppliers")]
	public partial class Packages_Products_Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PackageId;
		
		private int _ProductSupplierId;
		
		private EntityRef<Package> _Package;
		
		private EntityRef<Products_Supplier> _Products_Supplier;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPackageIdChanging(int value);
    partial void OnPackageIdChanged();
    partial void OnProductSupplierIdChanging(int value);
    partial void OnProductSupplierIdChanged();
    #endregion
		
		public Packages_Products_Supplier()
		{
			this._Package = default(EntityRef<Package>);
			this._Products_Supplier = default(EntityRef<Products_Supplier>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PackageId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PackageId
		{
			get
			{
				return this._PackageId;
			}
			set
			{
				if ((this._PackageId != value))
				{
					if (this._Package.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPackageIdChanging(value);
					this.SendPropertyChanging();
					this._PackageId = value;
					this.SendPropertyChanged("PackageId");
					this.OnPackageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductSupplierId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductSupplierId
		{
			get
			{
				return this._ProductSupplierId;
			}
			set
			{
				if ((this._ProductSupplierId != value))
				{
					if (this._Products_Supplier.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._ProductSupplierId = value;
					this.SendPropertyChanged("ProductSupplierId");
					this.OnProductSupplierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Package_Packages_Products_Supplier", Storage="_Package", ThisKey="PackageId", OtherKey="PackageId", IsForeignKey=true)]
		public Package Package
		{
			get
			{
				return this._Package.Entity;
			}
			set
			{
				Package previousValue = this._Package.Entity;
				if (((previousValue != value) 
							|| (this._Package.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Package.Entity = null;
						previousValue.Packages_Products_Suppliers.Remove(this);
					}
					this._Package.Entity = value;
					if ((value != null))
					{
						value.Packages_Products_Suppliers.Add(this);
						this._PackageId = value.PackageId;
					}
					else
					{
						this._PackageId = default(int);
					}
					this.SendPropertyChanged("Package");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Supplier_Packages_Products_Supplier", Storage="_Products_Supplier", ThisKey="ProductSupplierId", OtherKey="ProductSupplierId", IsForeignKey=true)]
		public Products_Supplier Products_Supplier
		{
			get
			{
				return this._Products_Supplier.Entity;
			}
			set
			{
				Products_Supplier previousValue = this._Products_Supplier.Entity;
				if (((previousValue != value) 
							|| (this._Products_Supplier.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Products_Supplier.Entity = null;
						previousValue.Packages_Products_Suppliers.Remove(this);
					}
					this._Products_Supplier.Entity = value;
					if ((value != null))
					{
						value.Packages_Products_Suppliers.Add(this);
						this._ProductSupplierId = value.ProductSupplierId;
					}
					else
					{
						this._ProductSupplierId = default(int);
					}
					this.SendPropertyChanged("Products_Supplier");
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
