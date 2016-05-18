namespace UnityUtils.DataUtils {
    internal interface IDataProvider {
        int Load(string key, int defaultValue);
        float Load(string key, float defaultValue);
        string Load(string key, string defaultValue);
        void Save(string key, int value);
        void Save(string key, float value);
        void Save(string key, string value);
    }
}
