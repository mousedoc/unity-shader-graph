using UnityEditor;
using System.Diagnostics.CodeAnalysis;

public class GameObjectShortcut
{
    [MenuItem("Tools/GameObject/Active DeActive %g", priority = 12)]
    [SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "Called by Unity editor")]
    private static void ChangeActiveState()
    {
        if (Selection.gameObjects == null)
            return;

        var selected = Selection.gameObjects;
        foreach (var elem in selected)
        {
            elem.SetActive(!elem.activeSelf);
            EditorUtility.SetDirty(elem);
        }
    }
}
