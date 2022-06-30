using UnityEditor;
using UnityEngine;

public class ExportFile
{
    [MenuItem("Tools/Localization/File/Export")]
    static public void Export()
    {
        var path = EditorUtility.SaveFilePanel("Export localization files", "", "Localization","txt");
        Debug.Log("Complite!" + path);
    }
}
