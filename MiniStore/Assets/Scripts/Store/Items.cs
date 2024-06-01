using money;
using UnityEngine;

[CreateAssetMenu(fileName = "new Goods", menuName = "Goods", order = 51)]
public class Items : ScriptableObject
{
    public string Label => _label;
    public string Description => _description;
    public int Price => _price;

    [SerializeField] private string _label;
    [SerializeField] private string _description;
    [SerializeField] private int _price;

    [SerializeField] private Wallet _wallet;

    public void BuyItems() => Debug.Log($"Вы купили {_label} за {_price} денюжек");
}