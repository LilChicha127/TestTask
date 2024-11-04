using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartScreen : MonoBehaviour
{
    public GameObject windowPrefab; // ссылка на префаб окна
    public Button openWindowButton;

    private void Start()
    {
        openWindowButton.onClick.AddListener(OpenWindow);
    }

    private void OpenWindow()
    {
       
        GameObject window = Instantiate(windowPrefab, this.transform);
        window.SetActive(true); 
        Destroy(openWindowButton.gameObject);
    }
}
