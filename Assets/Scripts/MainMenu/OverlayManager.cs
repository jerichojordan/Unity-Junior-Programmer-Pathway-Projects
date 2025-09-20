using UnityEngine;
using UnityEngine.SceneManagement;
public class OverlayManager : MonoBehaviour
{
    public void HandleOpenProjectButton(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void HandleCloseButton()
    {
        gameObject.SetActive(false);
    }
}
