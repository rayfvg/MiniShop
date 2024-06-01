using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Items> _goods;
    [SerializeField] private Wallet _wallet;

    [SerializeField] private Items _meat;
    [SerializeField] private Items _apple;
    [SerializeField] private Items _parrot;
    [SerializeField] private Items _fish;

    [SerializeField] private Button _buyMeatButton;
    [SerializeField] private Button _buyAppleButton;
    [SerializeField] private Button _buyParrotButton;
    [SerializeField] private Button _buyFishButton;

    private void Awake()
    {
        _buyMeatButton.onClick.AddListener(BuyMeat);
        _buyAppleButton.onClick.AddListener(BuyApple);
        _buyParrotButton.onClick.AddListener(BuyParrot);
        _buyFishButton.onClick.AddListener(BuyFish);
    }

    private void OnDestroy()
    {
        _buyMeatButton.onClick.RemoveListener(BuyMeat);
        _buyAppleButton.onClick.RemoveListener(BuyApple);
        _buyParrotButton.onClick.RemoveListener(BuyParrot);
        _buyFishButton.onClick.RemoveListener(BuyFish);
    }

    private void Update() => _wallet.UpdateMoneyText();

    public void BuyMeat()
    {
        if (_wallet.Money >= _meat.Price)
        {
            _wallet.Money -= _meat.Price;
            _meat.BuyItems();
            _buyMeatButton.enabled = false;
        }
    }

    public void BuyApple()
    {
        if (_wallet.Money >= _apple.Price)
        {
            _wallet.Money -= _apple.Price;
            _apple.BuyItems();
            _buyAppleButton.enabled = false;
        }
    }

    public void BuyParrot()
    {
        if (_wallet.Money >= _parrot.Price)
        {
            _wallet.Money -= _parrot.Price;
            _parrot.BuyItems();
            _buyParrotButton.enabled = false;
        }
    }

    public void BuyFish()
    {
        if (_wallet.Money >= _fish.Price)
        {
            _wallet.Money -= _fish.Price;
            _fish.BuyItems();
            _buyFishButton.enabled = false;
        }
    }
}