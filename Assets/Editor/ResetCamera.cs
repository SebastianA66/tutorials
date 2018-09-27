using System.Reflection;
using UnityEditor;

public class ResetCamera
{
    [MenuItem("ToolBar/Reset")]
    static void Reset()
    {
        if (SceneView.lastActiveSceneView != null)
        {
            MethodInfo info = SceneView.lastActiveSceneView.GetType().
                GetMethod("OnNewProjectLayoutWasCreated", BindingFlags.Instance | BindingFlags.NonPublic);
            info.Invoke(SceneView.lastActiveSceneView, null);
        }
    }
}