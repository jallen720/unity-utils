using System;
using UnityEngine;
using UnityUtils.Utils;
using UObject = UnityEngine.Object;

namespace UnityUtils.Extensions {
    public static class ObjectExtensions {
        public static T InstantiateAs<T>(this UObject obj) where T : Component {
            return obj.InstantiateAs<T>(Vector3.zero);
        }

        public static T InstantiateAs<T>(this UObject obj, Vector3 position) where T : Component {
            return obj.InstantiateAs<T>(position, Quaternion.identity);
        }

        public static T InstantiateAs<T>(this UObject obj, Vector3 position, Quaternion rotation)
            where T : Component
        {
            T component;

            if (ObjectUtil.Instantiate(obj, position, rotation).GetComponent(out component)) {
                return component;
            }
            else {
                throw new Exception(
                    "Cannot instantiate object as " + typeof(T).ToString() + " because the " +
                    "does not have a component of that type.");
            }
        }
    }
}