using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MovingBall))]
public class MovingBallEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Move to next frame"))
        {
            MovingBall component = target as MovingBall;
            component.ManualUpdate();
        }
    }
}
