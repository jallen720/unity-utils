using UnityEngine;

namespace UnityUtils.DataUtils {
    public class PlayerPrefsProvider : IDataProvider {
        string IDataProvider.Load(string key, string defaultValue) {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        float IDataProvider.Load(string key, float defaultValue) {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }

        int IDataProvider.Load(string key, int defaultValue) {
            return PlayerPrefs.GetInt(key, defaultValue);
        }

        void IDataProvider.Save(string key, string value) {
            PlayerPrefs.SetString(key, value);
        }

        void IDataProvider.Save(string key, float value) {
            PlayerPrefs.SetFloat(key, value);
        }

        void IDataProvider.Save(string key, int value) {
            PlayerPrefs.SetInt(key, value);
        }
    }
}