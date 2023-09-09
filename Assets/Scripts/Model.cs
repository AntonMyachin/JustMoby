using System.Collections.Generic;
using UnityEngine;

public class Model
{
    private DataFromDB _data;

    public Model(DataFromDB data)
    {
        _data = data;
    }

    public string GetTradeWindowHeader()
    {
        return _data.Header;
    }
    
    public string GetTradeWindowDiscription()
    {
        return _data.Discription;
    }

    public List<Sprite> GetItemsForTradeWindow(int quantity)
    {
        List<Sprite> items = new List<Sprite>();
        for (int i = 0; i < quantity; i++)
        {
            items.Add(_data.Items[i]);
        }
        return items;
    }

    public Sprite GetMainImage()
    {
        return _data.MainImage;
    }

    public int GetTradeWindowPrice()
    {
        return _data.Price;
    }

    public float GetTradeWindowDiscount()
    {
        return _data.Discount;
    }
}
