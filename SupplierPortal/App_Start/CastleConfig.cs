﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;
using SupplierPortal.Models;

namespace SupplierPortal
{
  public class CastleConfig
  {
    public static void Register()
    {
      ActiveRecordStarter.Initialize(ActiveRecordSectionHandler.Instance, 
        typeof(SupplierUser));
      /*
      InPlaceConfigurationSource source = new InPlaceConfigurationSource();
      source.Add(typeof(GysmhActiveRecordBase), CreateOracleConfig(
        "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.85.12.17)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)));"+
        "Persist Security Info=True;User ID=gysmh;Password=oracle;enlist=false"));
      source.Add(typeof(KingdeeActiveRecordBase), CreateOracleConfig(
        "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.85.12.247)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)));"+
        "Persist Security Info=True;User ID=gysmh;Password=oracle;enlist=false"));
      ActiveRecordStarter.Initialize(source, typeof(SupplierUser));*/
    }
    public static IDictionary<string, string> CreateOracleConfig(string connectionString)
    {
      IDictionary<string, string> properties = new Dictionary<string, string>();

      properties.Add("connection.driver_class", "NHibernate.Driver.OracleClientDriver");
      properties.Add("dialect", "NHibernate.Dialect.Oracle10gDialect");
      properties.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
      properties.Add("proxyfactory.factory_class", "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle");
      properties.Add("connection.connection_string", connectionString);
      return properties;  
    }

  }
}