using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[RequireComponent(typeof(TextMeshPro))]
public class TranslatedText : MonoBehaviour
{
    private int _index;
    private TextMeshPro _text;
}

#if UNITY_EDITOR
[CustomEditor(typeof(TranslatedText))]
public class TranslatedTextUI:Editor
{
    TranslatedText _translatedText;
    private void Awake()
    {
        _translatedText = (TranslatedText)target;
    }
}
#endif
