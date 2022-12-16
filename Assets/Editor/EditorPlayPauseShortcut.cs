using System.Diagnostics.CodeAnalysis;
using UnityEditor;

public class EditorPlayPauseShortcut
{
#if UNITY_EDITOR_WIN

    [MenuItem("Tools/Editor/Play %q", priority = 10)]
    [SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "Called by Unity editor")]
    private static void SetPlay()
    {
        EditorApplication.isPlaying = !EditorApplication.isPlaying;
    }

    [MenuItem("Tools/Editor/Pause %e", priority = 11)]
    [SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "Called by Unity editor")]
    private static void SetPause()
    {
        EditorApplication.isPaused = !EditorApplication.isPaused;
    }

#endif
}

