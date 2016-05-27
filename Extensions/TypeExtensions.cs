using System;

namespace UnityUtils.Extensions {
    public static class TypeExtensions {
        public static bool IsDerivedFromGenericType(this Type type, Type genericType) {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericType) {
                return true;
            }

            if (type.BaseType != null) {
                return IsDerivedFromGenericType(type.BaseType, genericType);
            }

            return false;
        }
    }
}