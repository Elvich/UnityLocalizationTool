using UnityEditor;
using UnityEngine;

public class InportFile
{
    [MenuItem("Tools/Localization/File/Import")]
    static public void Import()
    {
        var path = EditorUtility.OpenFilePanel("Select localization files", "", "txt");
        Debug.Log("Complite!" + path);
    }
}
