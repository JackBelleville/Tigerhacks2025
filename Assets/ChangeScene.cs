using UnityEngine;
using UnityEngine.SceneManagement; // Needed to change scenes

public class ChangeScene : MonoBehaviour
{
    public string SampleScene; // This lets you type the scene name in Unity Inspector

    public void ChangeScenes()
    {
        SceneManager.LoadScene(SampleScene); // This line actually loads the new scene
    }
}