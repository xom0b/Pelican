using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(FitBoxColliderToSprite))]
public class FitBoxColliderToSpriteEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        FitBoxColliderToSprite script = (FitBoxColliderToSprite)target;

        if (GUILayout.Button("Fit Box Collider To Sprite"))
        {
            script.ResizeBoxColliderToSprite();
        }
    }
}
#endif
