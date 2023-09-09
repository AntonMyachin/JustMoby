using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStartup : MonoBehaviour
{
    [SerializeField] private UIView _uiView;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _buyButton;
    [SerializeField] private TMP_InputField _countItem;
    [SerializeField] private DataFromDB _data;
    [SerializeField] private Item _itemPrefab;

    private void Awake()
    {
        Model _model = new Model(_data);
        Controller _controller = new Controller(_uiView, _model);

        _controller.CreatePool(_itemPrefab);
        _startButton.onClick.AddListener(() =>
        {
            int numericValue;
            if (int.TryParse(_countItem.text, out numericValue))
                _controller.DisplayTradeWindow(int.Parse(_countItem.text));
        });

        _buyButton.onClick.AddListener(() =>
        {
            _controller.DisplayStartWindow();
        });
    }
}
