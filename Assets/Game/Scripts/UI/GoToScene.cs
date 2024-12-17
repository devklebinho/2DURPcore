using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScene : MonoBehaviour
{
    public string sceneName;
    public void GoToSceneClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
