using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(LevelClass))]
public class LevelHelpClass : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EditorGUILayout.HelpBox("This is a help box", MessageType.Info);
    }
}