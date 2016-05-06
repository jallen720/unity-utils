namespace UnityUtils.Managers {
    public class Singleton<T> where T : Singleton<T>, new() {
        private static T instance;

        protected static T Instance {
            get {
                return instance ?? LoadInstance();
            }
        }

        private static T LoadInstance() {
            return instance = new T();
        }
    }
}