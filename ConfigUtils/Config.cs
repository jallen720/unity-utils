using UnityEngine;

namespace UnityUtils.ConfigUtils {
    public class Config<T> : ScriptableObject where T : Config<T> {
        private static T instance;

        protected static T Instance {
            get {
                return instance ?? LoadInstance();
            }
        }

        private static T LoadInstance() {
            return instance = Resources.Load<T>(GetConfigPath());
        }

        protected static string GetConfigPath() {
            const string RESOURCE_DIRECTORY = "Configs/";

            return RESOURCE_DIRECTORY + typeof(T).ToString();
        }
    }
}