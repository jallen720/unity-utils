using System;
using System.Linq;
using System.Reflection;

namespace UnityUtils.Utils {
    public static class TypeUtil {
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