using UnityEngine;

namespace UnityUtils.Extensions {
    public static class TransformExtensions {
        public static T InstantiateChild<T>(this Transform transform, Object childPrefab)
            where T : Component
        {
            return transform.InstantiateChild<T>(childPrefab, transform.position);
        }

        public static T InstantiateChild<T>(
            this Transform transform,
            Object childPrefab,
            Vector3 position)
            where T : Component
        {
            return transform.InstantiateChild<T>(
                childPrefab,
                transform.position,
                Quaternion.identity);
        }

        public static T InstantiateChild<T>(
            this Transform transform,
            Object childPrefab,
            Vector3 position,
            Quaternion rotation)
            where T : Component
        {
            var child = childPrefab.InstantiateAs<T>(position, rotation);
            child.transform.SetParent(transform);
            return child;
        }
    }
}