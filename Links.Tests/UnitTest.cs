using System;
using System.IO;
using System.Reflection;
using MediatR;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;

namespace Links.Tests
{
    public class UnitTest
    {
        public IMediator Mediator { get; private set; }

        public UnitTest()
        {
            Mediator = BuildMediator();
        }

        private static IMediator BuildMediator()
        {
            var container = new UnityContainer();
            container.RegisterTypes(AllClasses.FromAssemblies(Assembly.Load("Links.Models")), WithMappings.FromAllInterfaces);
            container.RegisterTypes(AllClasses.FromAssemblies(typeof(IMediator).Assembly), WithMappings.FromAllInterfaces);
            container.RegisterInstance(Console.Out);

            var serviceLocator = new UnityServiceLocator(container);
            var serviceLocatorProvider = new ServiceLocatorProvider(() => serviceLocator);
            container.RegisterInstance(serviceLocatorProvider);

            var mediator = container.Resolve<IMediator>();

            return mediator;
        }
        
        [TestInitialize]
        public void Initialize()
        {
            
        }

        public static int Compare<T>(T x, T y)
        {
            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public);
            var fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public);
            var compareValue = 0;

            foreach (var property in properties)
            {
                var valx = property.GetValue(x, null) as IComparable;
                if (valx == null)
                    continue;
                var valy = property.GetValue(y, null);
                compareValue = valx.CompareTo(valy);
                if (compareValue != 0)
                    return compareValue;
            }
            foreach (var field in fields)
            {
                var valx = field.GetValue(x) as IComparable;
                if (valx == null)
                    continue;
                var valy = field.GetValue(y);
                compareValue = valx.CompareTo(valy);
                if (compareValue != 0)
                    return compareValue;
            }

            return compareValue;
        }
    }
}
