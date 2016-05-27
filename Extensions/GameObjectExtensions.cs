using UnityEngine;

namespace UnityUtils.Extensions {
    public static class GameObjectExtensions {
        public static bool GetComponent<T>(this GameObject gameObject, out T component)
            where T : Component
        {
            return component = gameObject.GetComponent<T>();
        }
    }
}