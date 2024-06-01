using money;
using UnityEngine;
using UnityEngine.UI;

namespace shop
{
    public class Sale : MonoBehaviour
    {
        [SerializeField] private Button _buyButton;
        [SerializeField] private GameObject _sellImage;
        [SerializeField] private Wallet _wallet;
        [SerializeField] private string _label;
        [SerializeField] private string _description;
        [SerializeField] private int _price;

        public void Sell()
        {
            if (_wallet.Money >= _price)
            {
                _wallet.Money -= _price;
                _buyButton.gameObject.SetActive(false);
                _sellImage.SetActive(true);
                Debug.Log($"�� ������ {_label}, {_description} �� ������� {_price}.");
            }
            else
                Debug.Log($"� ��� �� ������� �����((");
        }

        private void Update() => _wallet.UpdateMoneyText();
    }
}