using UnityEngine;

namespace money
{
    public class Bank : MonoBehaviour
    {
        [SerializeField] private Wallet _wallet;

        public void AddMoney()
        {
            _wallet.Money++;
            _wallet.UpdateMoneyText();

            if (_wallet.Money >= 999)
                _wallet.Money = 998;
        }
    }
}