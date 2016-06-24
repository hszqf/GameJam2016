using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

static public class EditorTool 
{
    #region KeChen
	[MenuItem("Tools/Start Preload Scene %H", false)]
    private static void StartPreloadScene()
    {
        if(EditorApplication.isPlaying)
            return;
		EditorApplication.OpenScene("Assets/Scenes/test/LoadDatabase/LoadDatabase.unity");
        EditorApplication.isPlaying = true;
    }

    [MenuItem("Tools/Start KeChen's Test Scene #%H", false)]
    private static void StartKeChenUIScene()
    {
        if(EditorApplication.isPlaying)
            return;
		EditorApplication.OpenScene("Assets/Scenes/test/LoadDatabase/LoadDatabase.unity");
    }

	[MenuItem("Tools/Replace Sprite With Widget", false)]
	private static void ReplaceUISpriteWithUIWidget()
	{
		GameObject selectedObject = Selection.activeGameObject;
		UISprite spriteCpt = selectedObject.GetComponent<UISprite>();
		if(spriteCpt != null)
		{
			UIWidget widget = selectedObject.AddComponent<UIWidget>();
			widget.pivot = spriteCpt.pivot;
			widget.leftAnchor = spriteCpt.leftAnchor;
			widget.rightAnchor = spriteCpt.rightAnchor;
			widget.topAnchor = spriteCpt.topAnchor;
			widget.bottomAnchor = spriteCpt.bottomAnchor;
			widget.updateAnchors = spriteCpt.updateAnchors;
			widget.SetDimensions((int)spriteCpt.localSize.x, (int)spriteCpt.localSize.y);
			widget.autoResizeBoxCollider = spriteCpt.autoResizeBoxCollider;
			widget.depth = spriteCpt.depth;
		}
	}

//    [MenuItem("Tools/KeChen/Log Component Recursively", false)]
//    private static void LogComponentRecursively()
//    {
//        GameObject selectedObject = Selection.activeGameObject;
//        if(selectedObject == null)
//            return;
//        //手动替换组件
//        LabelSpriteComponent[] components = selectedObject.GetComponentsInChildren<LabelSpriteComponent>();
//        foreach(var cpt in components)
//        {
//            Debug.Log(cpt.gameObject.name + " -- ", cpt.gameObject);
//        }
//    }

//    [MenuItem("Tools/KeChen/Normalize Label", false)]
//    private static void NormalizeLabel()
//    {
//        GameObject selectedObject = Selection.activeGameObject;
//        if(selectedObject == null)
//            return;
//        UILabel[] labels = selectedObject.GetComponentsInChildren<UILabel>();
//        int count = 0;
//        foreach(var label in labels)
//        {
//            label.applyGradient = false;
//            label.effectStyle = UILabel.Effect.None;
//            count++;
//        }
//        Debug.Log(count + " label normalized");
//    }

    [MenuItem("Tools/ShowHideObject %G", false)]
    private static void ShowHideObject()
    {
        GameObject[] gos = Selection.gameObjects;
        Undo.RecordObjects(gos, "Show hide objects");
        foreach(GameObject go in gos)
        {
            go.SetActive(!go.activeSelf);
        }
    }

	public static void ClearConsole () {
		// This simply does "LogEntries.Clear()" the long way:
		var logEntries = System.Type.GetType("UnityEditorInternal.LogEntries,UnityEditor.dll");
		var clearMethod = logEntries.GetMethod("Clear", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
		clearMethod.Invoke(null,null);
	}
   
    #endregion
}
