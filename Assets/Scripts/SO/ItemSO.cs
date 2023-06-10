using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int attck;
    public int health;
    public Sprite sprite;
    public float percent;
}



[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO", order = 0)]
public class ItemSO : ScriptableObject 
{
    public Item[] items;
    
}
