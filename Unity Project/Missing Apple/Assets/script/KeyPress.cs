using UnityEngine;
using UnityEditor;

class KeyPress : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
        }
        if (Input.GetButtonDown("FullScreen"))
        {
            //Debug.Log("Toggle FullScreen");
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}
