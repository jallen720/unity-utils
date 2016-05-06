using UnityEngine;

namespace UnityUtils.Managers {
    public class SceneManager<T> : MonoBehaviour where T : SceneManager<T> {
        private static T instance;

        protected static T Instance {
            get {
                return instance ?? LoadInstance();
            }
        }

        private static T LoadInstance() {
            return instance = FindObjectOfType<T>();
        }

        private void OnDestroy() {
            instance = null;
        }
    }
}