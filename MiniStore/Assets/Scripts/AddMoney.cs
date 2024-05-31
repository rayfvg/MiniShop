using UnityEngine;

public class AddMoney : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    public void AddMoreMoney()
    {
        _wallet.Money++;
        _wallet.UpdateMoneyText();

        if (_wallet.Money >= 999)
            _wallet.Money = 998;   // Органичение в 999 монет
    }
}