using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowModel : MonoBehaviour
{
    public string title;
    public string description;
    public List<ItemData> items;
    public float price;
    public float discount;
    public string iconName;

    public WindowModel(string title, string description, List<ItemData> items, float price, float discount, string iconName)
    {
        this.title = title;
        this.description = description;
        this.items = items;
        this.price = price;
        this.discount = discount;
        this.iconName = iconName;
    }
}
