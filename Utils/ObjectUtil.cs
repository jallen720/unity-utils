using UnityEngine;
using UObject = UnityEngine.Object;

namespace UnityUtils.Utils {
    public static class ObjectUtil {
        public static GameObject Instantiate(UObject obj, Vector2 position, Quaternion rotation) {
            return (GameObject)UObject.Instantiate(obj, position, rotation);
        }
    }
}