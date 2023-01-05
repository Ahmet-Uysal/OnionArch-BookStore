using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BookStore.Application.Abstractions;

namespace BookStore.Infrastructure.Services
{
    public class ObjectOperations : IObjectOperations
    {
        public void CopyProperties<T, E>(T source, E target) where T : class where E : class
        {
            foreach (var sProp in source.GetType().GetProperties())
            {
                bool isMatched = target.GetType().GetProperties().Any(tProp => tProp.Name == sProp.Name && tProp.GetType() == sProp.GetType() && tProp.CanWrite);
                if (isMatched)
                {
                    var value = sProp.GetValue(source);
                    PropertyInfo propertyInfo = target.GetType().GetProperty(sProp.Name);
                    propertyInfo.SetValue(target, value);
                }
            }
        }


    }
}