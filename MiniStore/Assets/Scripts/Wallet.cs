using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMoney;
    public int Money;

    public void UpdateMoneyText() => _textMoney.text = Money.ToString();

    private void Start() => UpdateMoneyText();
}