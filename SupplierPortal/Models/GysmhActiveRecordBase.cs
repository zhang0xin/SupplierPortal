using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;
using NHibernate;
using NHibernate.Criterion;

namespace SupplierPortal.Models
{
  public abstract class GysmhActiveRecordBase : ActiveRecordBase
  {
  }
  [Serializable]
  public abstract class GysmhActiveRecordBase<T> : GysmhActiveRecordBase
  {
    protected internal static void Create(T instance)
    {
      ActiveRecordBase.Create(instance);
    }

    protected internal static void Delete(T instance)
    {
      ActiveRecordBase.Delete(instance);
    }
    public static void DeleteAll()
    {
      DeleteAll(typeof(T));
    }

    public static void DeleteAll(String where)
    {
      DeleteAll(typeof(T), where);
    }
    public static int DeleteAll(IEnumerable pkValues)
    {
      return DeleteAll(typeof(T), pkValues);
    }

    protected internal static void Refresh(T instance)
    {
      ActiveRecordBase.Refresh(instance);
    }

    protected internal static void Update(T instance)
    {
      ActiveRecordBase.Update(instance);
    }

    protected internal static void Save(T instance)
    {
      ActiveRecordBase.Save(instance);
    }

    protected internal static T SaveCopy(T instance)
    {
      return (T)ActiveRecordBase.SaveCopy(instance);
    }
    protected static object Execute(NHibernateDelegate call, object instance)
    {
      return Execute(typeof(T), call, instance);
    }
    protected internal static R ExecuteQuery2<R>(IActiveRecordQuery<R> query)
    {
      object result = ExecuteQuery(query);
      if (result == null) return default(R);

      if (!typeof(R).IsAssignableFrom(result.GetType()))
        throw new NHibernate.QueryException(
          string.Format("Problem: A query was executed requesting {0} as result, but the query returned an object of type {1}.", typeof(R).Name, result.GetType().Name));
      return (R)result;
    }
    protected internal static int Count()
    {
      return Count(typeof(T));
    }
    protected internal static int Count(String filter, params object[] args)
    {
      return Count(typeof(T), filter, args);
    }

    protected internal static int Count(params ICriterion[] criteria)
    {
      return Count(typeof(T), criteria);
    }
    protected internal static int Count(DetachedCriteria detachedCriteria)
    {
      return Count(typeof(T), detachedCriteria);
    }

    public static bool Exists()
    {
      return ActiveRecordBase.Exists(typeof(T));
    }
    public static bool Exists(String filter, params object[] args)
    {
      return Exists(typeof(T), filter, args);
    }
    public static bool Exists<PkType>(PkType id)
    {
      if (typeof(ICriterion).IsAssignableFrom(typeof(PkType)))
        return Exists(new ICriterion[] { (ICriterion)id });
      return Exists(typeof(T), id);
    }
    public static bool Exists(params ICriterion[] criteria)
    {
      return Exists(typeof(T), criteria);
    }
    public static bool Exists(DetachedCriteria detachedCriteria)
    {
      return Exists(typeof(T), detachedCriteria);
    }

    public static bool Exists(IDetachedQuery detachedQuery)
    {
      return Exists(typeof(T), detachedQuery);
    }

    public static T[] FindAll(DetachedCriteria criteria, params Order[] orders)
    {
      return (T[])FindAll(typeof(T), criteria, orders);
    }
    public static T[] FindAll()
    {
      return (T[])FindAll(typeof(T));
    }
    public static T[] FindAll(Order order, params ICriterion[] criteria)
    {
      return (T[])FindAll(typeof(T), new[] { order }, criteria);
    }

    public static T[] FindAll(Order[] orders, params ICriterion[] criteria)
    {
      return (T[])FindAll(typeof(T), orders, criteria);
    }
    public static T[] FindAll(params ICriterion[] criteria)
    {
      return (T[])FindAll(typeof(T), criteria);
    }
    public static T[] FindAll(IDetachedQuery detachedQuery)
    {
      return (T[])FindAll(typeof(T), detachedQuery);
    }
    public static T[] FindAllByProperty(String property, object value)
    {
      return (T[])FindAllByProperty(typeof(T), property, value);
    }
    public static T[] FindAllByProperty(String orderByColumn, String property, object value)
    {
      return (T[])FindAllByProperty(typeof(T), orderByColumn, property, value);
    }
    public static T Find(object id)
    {
      return (T)FindByPrimaryKey(typeof(T), id, true);
    }
    public static T TryFind(object id)
    {
      return (T)FindByPrimaryKey(typeof(T), id, false);
    }
    protected internal static T FindByPrimaryKey(object id)
    {
      return (T)FindByPrimaryKey(typeof(T), id);
    }
    protected internal static T FindByPrimaryKey(object id, bool throwOnNotFound)
    {
      return (T)FindByPrimaryKey(typeof(T), id, throwOnNotFound);
    }
    public static T FindFirst(DetachedCriteria criteria, params Order[] orders)
    {
      return (T)FindFirst(typeof(T), criteria, orders);
    }
    public static T FindFirst(Order order, params ICriterion[] criteria)
    {
      return (T)FindFirst(typeof(T), new Order[] { order }, criteria);
    }
    public static T FindFirst(Order[] orders, params ICriterion[] criteria)
    {
      return (T)FindFirst(typeof(T), orders, criteria);
    }
    public static T FindFirst(params ICriterion[] criteria)
    {
      return (T)FindFirst(typeof(T), criteria);
    }

    public static T FindFirst(IDetachedQuery detachedQuery)
    {
      return (T)FindFirst(typeof(T), detachedQuery);
    }

    public static T FindOne(params ICriterion[] criteria)
    {
      return (T)FindOne(typeof(T), criteria);
    }

    public static T FindOne(DetachedCriteria criteria)
    {
      return (T)FindOne(typeof(T), criteria);
    }

    public static T FindOne(IDetachedQuery detachedQuery)
    {
      return (T)FindOne(typeof(T), detachedQuery);
    }
    public static T[] SlicedFindAll(int firstResult, int maxResults, Order[] orders,
                                    params ICriterion[] criteria)
    {
      return (T[])SlicedFindAll(typeof(T), firstResult, maxResults, orders, criteria);
    }

    public static T[] SlicedFindAll(int firstResult, int maxResults,
                                    params ICriterion[] criteria)
    {
      return (T[])SlicedFindAll(typeof(T), firstResult, maxResults, criteria);
    }

    public static T[] SlicedFindAll(int firstResult, int maxResults, DetachedCriteria criteria, params Order[] orders)
    {
      return (T[])SlicedFindAll(typeof(T), firstResult, maxResults, orders, criteria);
    }

    public static T[] SlicedFindAll(int firstResult, int maxResults, IDetachedQuery detachedQuery)
    {
      return (T[])SlicedFindAll(typeof(T), firstResult, maxResults, detachedQuery);
    }
  }
}