using UnityEngine;

namespace UnityUtils.DataUtils {
    public static class Data {
        private static IDataProvider dataProvider;

        private static IDataProvider DataProvider {
            get {
                return dataProvider ?? LoadDataProvider();
            }
        }

        private static IDataProvider LoadDataProvider() {
            return dataProvider = GetPlatformDataProvider();
        }

        private static IDataProvider GetPlatformDataProvider() {
            if (Application.isEditor) {
                return new PlayerPrefsProvider();
            }
            else {
                return new SecurePlayerPrefsProvider();
            }
        }

        public static int Load(string key, int defaultValue) {
            return DataProvider.Load(key, defaultValue);
        }

        public static float Load(string key, float defaultValue) {
            return DataProvider.Load(key, defaultValue);
        }

        public static string Load(string key, string defaultValue) {
            return DataProvider.Load(key, defaultValue);
        }

        public static void Save(string key, int value) {
            DataProvider.Save(key, value);
        }

        public static void Save(string key, float value) {
            DataProvider.Save(key, value);
        }

        public static void Save(string key, string value) {
            DataProvider.Save(key, value);
        }
    }
}