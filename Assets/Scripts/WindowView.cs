using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WindowView : MonoBehaviour
{
    public Text titleText;
    public Text descriptionText;
    public Transform itemsContainer; 
    public Button priceButton;
    public float price;


    public void Init(WindowModel model)
    {
        titleText.text = model.title;
        descriptionText.text = model.description;

        foreach (Transform child in itemsContainer)
        {
            Destroy(child.gameObject); 
        }

        foreach (var item in model.items)
        {
            
            Item itemObj =  Instantiate(item.prefab, itemsContainer);
            itemObj.SetUI(item.sprite,item.amount);


        }

        UpdatePrice(model.price, model.discount);
    }

    public void UpdatePrice(float price, float discount)
    {
        this.price = price;
        priceButton.GetComponentInChildren<Text>().text = $"Price: {price} (Discount: {discount})";
    }

    public void OnPriceButtonClick()
    {
       
        Debug.Log("Price button");
    }
}
