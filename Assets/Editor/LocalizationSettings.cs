using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class LocalizationSettings : EditorWindow
{
    static string _filePath;

    VisualElement root;
    StyleSheet styleSheet;

    GroupBox creatingGroup;
    GroupBox settingsGroup;
    Button button;


    [MenuItem("Tools/Localization/Settings")]
    public static void ShowExample()
    {
        LocalizationSettings wnd = GetWindow<LocalizationSettings>();
        wnd.titleContent = new GUIContent("LocalizationSettings");
        _filePath = Application.persistentDataPath + "/Localizatoin/settings.txt";
    }

    public void CreateGUI()
    {
        root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/LocalizationSettings.uxml");
        visualTree.CloneTree(root);

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Localization.uss");
        root.styleSheets.Add(styleSheet);

        creatingGroup = root.Q<GroupBox>("CreatingSettings");
        settingsGroup = root.Q<GroupBox>("Settings");
        button = root.Q<Button>("ButtonCreatingSettings");

        creatingGroup.style.display = DisplayStyle.Flex;
        settingsGroup.style.display = DisplayStyle.None;

        if(!File.Exists(_filePath))
        {
            Debug.Log("No O_o?");
            creatingGroup.style.display = DisplayStyle.Flex;
            settingsGroup.style.display = DisplayStyle.None;
        }

    }

    private void OnInspectorUpdate()
    {
        button.clicked += () =>
        {
            creatingGroup.style.display = DisplayStyle.None;
            settingsGroup.style.display = DisplayStyle.Flex;
        };
    }
}