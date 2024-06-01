using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Goods> _goods;
    [SerializeField] private Wallet _wallet;

    [SerializeField] private Goods _meat;
    [SerializeField] private Goods _apple;
    [SerializeField] private Goods _parrot;
    [SerializeField] private Goods _fish;

    [SerializeField] private Button _button;
    [SerializeField] private Button _button2;
    [SerializeField] private Button _button3;
    [SerializeField] private Button _button4;

    private void Start()
    {
        foreach (var good in _goods)
            good.ShowInfoByGoods();
    }

    public void BuyMeat()
    {
        if (_wallet.Money >= _meat.Price)
        {
            _wallet.Money -= _meat.Price;
            _wallet.UpdateMoneyText();
            _meat.BuyGoods();
            _button.gameObject.SetActive(false);
        }
    }

    public void BuyApple()
    {
        if (_wallet.Money >= _apple.Price)
        {
            _wallet.Money -= _apple.Price;
            _wallet.UpdateMoneyText();
            _apple.BuyGoods();
            _button2.gameObject.SetActive(false);
        }
    }

    public void BuyParrot()
    {
        if (_wallet.Money >= _parrot.Price)
        {
            _wallet.Money -= _parrot.Price;
            _wallet.UpdateMoneyText();
            _parrot.BuyGoods();
            _button3.gameObject.SetActive(false);
        }
    }

    public void BuyFish()
    {
        if (_wallet.Money >= _fish.Price)
        {
            _wallet.Money -= _fish.Price;
            _wallet.UpdateMoneyText();
            _fish.BuyGoods();
            _button4.gameObject.SetActive(false);
        }
    }
}