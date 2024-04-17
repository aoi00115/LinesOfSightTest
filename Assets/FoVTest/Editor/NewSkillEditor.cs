using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (NewSkill))]
public class NewSkillEditor : Editor
{
    void OnSceneGUI()
    {
        NewSkill ns = (NewSkill)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(ns.transform.position,Vector3.up, Vector3.forward, 360, ns.viewRadius);
    }
}
