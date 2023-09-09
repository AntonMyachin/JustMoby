using System.Collections.Generic;

public class Controller
{
    private UIView _view;
    private Model _model;

    private ItemPool<Item> _pool;
    private List<Item> _items = new List<Item>();
    public Controller(UIView view, Model model)
    {
        _view = view;
        _model = model;
    }

    public void CreatePool(Item itemPrefab)
    {
        _pool = new ItemPool<Item>(itemPrefab, 6);
    }

    public void DisplayTradeWindow(int countItem)
    {
        _view.SwithcStartWindow(false);
        _view.SwitchTradeWindow(true);
        
        _view.SetHeader(_model.GetTradeWindowHeader());
        _view.SetDiscription(_model.GetTradeWindowDiscription());
        _view.SetBigIcon(_model.GetMainImage());

        PoolIBildingMaterials(countItem);
        SetPrice();
    }

    private void PoolIBildingMaterials(int countItem)
    {
        if (countItem > 6)
            countItem = 6;
        var spritesForItems = _model.GetItemsForTradeWindow(countItem);
        for (int i = 0; i < countItem; i++)
        {
            var material = _pool.Get();
            _items.Add(material);
            material.SetSprite(spritesForItems[i]);
            _view.SetItems(material);
        }
    }

    private void SetPrice()
    {
        int price = _model.GetTradeWindowPrice();
        float discount = _model.GetTradeWindowDiscount();

        if (discount == 0)
        {
            _view.SetPrice("$" + price);
        }
        else
        {
            float discountPrice = price - price * discount;
            string newPrice = $"<b>${discountPrice}</b> \n <s>${price}</s>";
            _view.SetDiscount($"{discount * 100}", newPrice);
        }
    }

    public void DisplayStartWindow()
    {
        foreach (var item in _items)
        {
            _pool.Release(item);
        }

        _items.Clear();
        _view.SwitchTradeWindow(false);
        _view.SwithcStartWindow(true);
    }
}
