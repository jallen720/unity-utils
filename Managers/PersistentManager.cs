using UnityEngine;

namespace UnityUtils.Managers {
    public class PersistentManager<T> : MonoBehaviour where T : PersistentManager<T> {
        private void Awake() {
            // If this is a duplicate instance, destroy this instance.
            if (Instance != this) {
                Destroy(gameObject);
            }
            // Persist this instance's object through all scenes.
            else {
                DontDestroyOnLoad(gameObject);
                OnAwake();
            }
        }

        private void OnDestroy() {
            if (Instance == this) {
                instance = null;
            }
        }

        protected virtual void OnAwake() { }

        // Static members

        private static T instance;

        protected static T Instance {
            get {
                return instance ?? LoadInstance();
            }
        }

        private static T LoadInstance() {
            return instance = (LoadExistingInstance() ?? LoadNewInstance());
        }

        private static T LoadExistingInstance() {
            return FindObjectOfType<T>();
        }

        private static T LoadNewInstance() {
            const string RESOURCE_DIRECTORY = "PersistentManagers/";

            return Instantiate(Resources.Load<T>(RESOURCE_DIRECTORY + typeof(T).ToString()));
        }
    }
}

