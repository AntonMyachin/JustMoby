using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private Image _image;
    public void SetSprite(Sprite item)
    {
        _image.sprite = item;
    }
}
