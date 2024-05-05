using UnityEngine;
using UnityEditor;

public class AssetBundleLoaderEditor : EditorWindow
{
    [MenuItem("Window/Load Asset Bundle")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(AssetBundleLoaderEditor));
    }

    string assetBundlePath = "Assets/AssetBundles/lethalextras";
    string prefabName = "MyPrefab";

    void OnGUI()
    {
        GUILayout.Label("Asset Bundle Loader", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        GUILayout.Label("Asset Bundle Path:");
        assetBundlePath = EditorGUILayout.TextField(assetBundlePath);

        GUILayout.Label("Prefab Name:");
        prefabName = EditorGUILayout.TextField(prefabName);

        if (GUILayout.Button("Load Prefab"))
        {
            LoadPrefabFromAssetBundle();
        }
    }

    void LoadPrefabFromAssetBundle()
    {
        AssetBundle assetBundle = AssetBundle.LoadFromFile(assetBundlePath);
        GameObject prefab = assetBundle.LoadAsset<GameObject>(
            $"Assets/LethalExtras/buyable/placeable/medstation/MedstationContainer.prefab");

        PrefabUtility.InstantiatePrefab(prefab);
        assetBundle.Unload(false);
    }
}