using TMPro;
using UnityEngine;

[CreateAssetMenu (fileName = "new Goods", menuName = "Goods", order = 51)]
public class Goods : ScriptableObject
{
    [SerializeField] private string _lable;
    [SerializeField] private string _description;
    [SerializeField] private int _price;
    [SerializeField] private Wallet _wallet;
    public void ShowInfoByGoods() => Debug.Log($"Можем предложить {_lable}, {_description}, за {_price}."); 

    public void BuyGoods() => Debug.Log($"Вы купили {_lable} за {_price} денюжек");
}