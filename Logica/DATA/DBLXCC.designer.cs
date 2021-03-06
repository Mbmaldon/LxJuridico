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

namespace Logica.DATA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LXCC")]
	public partial class DBLXCCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DBLXCCDataContext() : 
				base(global::Logica.Properties.Settings.Default.LXCCConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBLXCCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLXCCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLXCCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLXCCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LXCCSPS_VALIDAR_USUARIO")]
		public ISingleResult<LXCCSPS_VALIDAR_USUARIOResult> LXCCSPS_VALIDAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(45)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(45)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, password);
			return ((ISingleResult<LXCCSPS_VALIDAR_USUARIOResult>)(result.ReturnValue));
		}
	}
	
	public partial class LXCCSPS_VALIDAR_USUARIOResult
	{
		
		private long _IdUsuario;
		
		private long _IdUsuarioTipo;
		
		private string _Nombre;
		
		private string _APaterno;
		
		private string _AMaterno;
		
		public LXCCSPS_VALIDAR_USUARIOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="BigInt NOT NULL")]
		public long IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this._IdUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuarioTipo", DbType="BigInt NOT NULL")]
		public long IdUsuarioTipo
		{
			get
			{
				return this._IdUsuarioTipo;
			}
			set
			{
				if ((this._IdUsuarioTipo != value))
				{
					this._IdUsuarioTipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APaterno", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string APaterno
		{
			get
			{
				return this._APaterno;
			}
			set
			{
				if ((this._APaterno != value))
				{
					this._APaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AMaterno", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string AMaterno
		{
			get
			{
				return this._AMaterno;
			}
			set
			{
				if ((this._AMaterno != value))
				{
					this._AMaterno = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
