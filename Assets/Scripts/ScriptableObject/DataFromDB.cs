using UnityEngine;

[CreateAssetMenu]
public class DataFromDB : ScriptableObject
{
    public string Header;
    public string Discription;
    public Sprite[] Items;
    public int Price;
    public float Discount;
    public Sprite MainImage;
}