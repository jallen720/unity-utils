using UnityEngine;

namespace UnityUtils.DataUtils {
    internal sealed class SecurePlayerPrefsProvider : IDataProvider {
        public SecurePlayerPrefsProvider() {
            ZPlayerPrefs.Initialize("8295saiYaABA3jao9i90dd", SystemInfo.deviceUniqueIdentifier);
        }

        string IDataProvider.Load(string key, string defaultValue) {
            return ZPlayerPrefs.GetString(key, defaultValue);
        }

        float IDataProvider.Load(string key, float defaultValue) {
            return ZPlayerPrefs.GetFloat(key, defaultValue);
        }

        int IDataProvider.Load(string key, int defaultValue) {
            return ZPlayerPrefs.GetInt(key, defaultValue);
        }

        void IDataProvider.Save(string key, string value) {
            ZPlayerPrefs.SetString(key, value);
        }

        void IDataProvider.Save(string key, float value) {
            ZPlayerPrefs.SetFloat(key, value);
        }

        void IDataProvider.Save(string key, int value) {
            ZPlayerPrefs.SetInt(key, value);
        }
    }
}