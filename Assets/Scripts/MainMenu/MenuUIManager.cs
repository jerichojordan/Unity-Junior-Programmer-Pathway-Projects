using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private Transform overlayParent;
    public GameObject[] overlayGameobjects;
    void Start()
    {
        overlayGameobjects = new GameObject[overlayParent.childCount];

        for (int i = 0; i < overlayParent.childCount; i++)
        {
            overlayGameobjects[i] = overlayParent.transform.GetChild(i).gameObject;
        }

    }
    public void HandleOpenProject()
    {
        overlayGameobjects[dropdown.value].SetActive(true);
    }
}
