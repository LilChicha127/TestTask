
using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObjects/Item")]
public class ItemData : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public int amount;
    public Item prefab;   // шаблон предмета
}
