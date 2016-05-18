using UnityEditor;

namespace UnityUtilsEditor.ConfigUtils {
    public static class ConfigFactory {

        [MenuItem("Assets/Create/Config")]
        public static void CreateConfig() {
            var createConfigWindow = EditorWindow.GetWindow<CreateConfigWindow>(
                utility: true,
                title: "Create Configuration Asset",
                focus: true
            );

            createConfigWindow.ShowPopup();
            createConfigWindow.Init();
        }
    }
}