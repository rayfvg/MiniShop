using TMPro;
using UnityEngine;

namespace money
{
    public class Wallet : MonoBehaviour
    {
        public int Money { get => _money; set => _money = value; }

        [SerializeField] private int _money;
        [SerializeField] private TextMeshProUGUI _textMoney;

        public void UpdateMoneyText() => _textMoney.text = Money.ToString();

        private void Start() => UpdateMoneyText();
    }
}