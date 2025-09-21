using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private GameObject[] overlayGameobjects;
    public void HandleOpenProject()
    {
        overlayGameobjects[dropdown.value].SetActive(true);
    }
}
