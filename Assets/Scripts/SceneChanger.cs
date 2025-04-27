using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SampleScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(SampleScene);
    }
}
