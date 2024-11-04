using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    public WindowView view;
    public WindowModel model;

    private void Start()
    {
       

        view.Init(model);
        view.priceButton.onClick.AddListener(view.OnPriceButtonClick); 
    }
}
