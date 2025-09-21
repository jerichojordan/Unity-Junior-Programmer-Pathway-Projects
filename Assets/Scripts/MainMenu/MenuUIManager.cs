using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    public void HandleOpenProject()
    {
        SceneManager.LoadScene(dropdown.value);
    }
}
