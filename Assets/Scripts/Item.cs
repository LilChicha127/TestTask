using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    public Image image;
    public Text amountText;

    public void SetUI(Sprite sprite, int amount)        
    {
        image.sprite = sprite;
        amountText.text = amount.ToString();                
    }
}
