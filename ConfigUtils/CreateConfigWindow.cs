using System;
using System.Linq;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityUtils.ConfigUtils;
using UnityUtils.Extensions;
using UnityUtils.Utils;

namespace UnityUtilsEditor.ConfigUtils {

    // Must be top level class instead of nested in CreateConfigWindow for some reason...
    internal class EndNameEdit : EndNameEditAction {
        public override void Action(int instanceId, string pathName, string resourceFile) {
            AssetDatabase.CreateAsset(
                EditorUtility.InstanceIDToObject(instanceId),
                AssetDatabase.GenerateUniqueAssetPath(pathName));
        }
    }

    public class CreateConfigWindow : EditorWindow {
        private int selectionIndex;
        private Type[] configTypes;
        private string[] configNames;

        public void Init() {
            configTypes = GetConfigTypes();
            configNames = GetConfigNames();
        }

        private static Type[] GetConfigTypes() {
            const string PROJECT_ASSEMBLY_NAME = "Assembly-CSharp";

            return TypeUtil.GetAssemblyTypes(PROJECT_ASSEMBLY_NAME, IsConfig);
        }

        private static bool IsConfig(Type type) {
            return type.IsDerivedFromGenericType(typeof(Config<>));
        }

        private string[] GetConfigNames() {
            return configTypes
                .Select(configType => configType.FullName)
                .ToArray();
        }

        public void OnGUI() {
            SelectConfig();
            CheckCreateButton();
        }

        private void SelectConfig() {
            GUILayout.Label("Config Class");
            selectionIndex = EditorGUILayout.Popup(selectionIndex, configNames);
        }

        private void CheckCreateButton() {
            if (GUILayout.Button("Create")) {
                CreateConfig();
            }
        }

        private void CreateConfig() {
            var config = CreateInstance(configTypes[selectionIndex]);

            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
                instanceID: config.GetInstanceID(),
                endAction: CreateInstance<EndNameEdit>(),
                pathName: configNames[selectionIndex] + ".asset",
                icon: AssetPreview.GetMiniThumbnail(config),
                resourceFile: null);

            Close();
        }
    }
}