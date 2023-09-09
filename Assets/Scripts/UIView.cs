using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    [SerializeField] private Transform _startWindow;
    [SerializeField] private Transform _tradeWindow;
    [SerializeField] private Transform _buildingMaterialsParent;
    [SerializeField] private Image _mainImage;
    [SerializeField] private TMP_Text _header;
    [SerializeField] private TMP_Text _discription;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Transform _discount;

    public void SwithcStartWindow(bool v)
    {
        _startWindow.gameObject.SetActive(v);
    }

    public void SwitchTradeWindow(bool v)
    {
        _tradeWindow.gameObject.SetActive(v);
    }

    public void SetHeader(string head)
    {
        _header.text = head;
    }

    public void SetDiscription(string discription)
    {
        _discription.text = discription;
    }

    public void SetItems(Item item)
    {
        item.transform.SetParent(_buildingMaterialsParent);
    }

    public void SetPrice(string price)
    {
        _price.text = price;
    }

    public void SetDiscount(string textDiscount, string price)
    {
        _discount.gameObject.SetActive(true);
        _discount.GetComponentInChildren<TMP_Text>().text = textDiscount + "%";
        _price.text = price;
    }

    public void SetBigIcon(Sprite sprite)
    {
        _mainImage.sprite = sprite;
        _mainImage.preserveAspect = true;
    }
}
