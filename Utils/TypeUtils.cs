using System;
using System.Linq;
using System.Reflection;

namespace UnityUtils.Utils {
    public static class TypeUtils {
        public static bool IsDerivedOfGenericType(Type type, Type genericType) {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericType) {
                return true;
            }

            if (type.BaseType != null) {
                return IsDerivedOfGenericType(type.BaseType, genericType);
            }
            
            return false;
        }

        public static Type[] GetAssemblyTypes(string assemblyName, Func<Type, bool> where) {
            return GetAssembly(assemblyName)
                .GetTypes()
                .Where(where)
                .ToArray();
        }

        private static Assembly GetAssembly(string assemblyName) {
            return Assembly.Load(new AssemblyName(assemblyName));
        }
    }
}