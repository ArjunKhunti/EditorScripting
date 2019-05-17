using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(LevelScript))]
public class LevelScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LevelScript ls = (LevelScript)target;

        ls.exp = EditorGUILayout.IntField("Experience", ls.exp);
        EditorGUILayout.LabelField("Level", ls.Level.ToString());
    }
}
