using UnityEngine;

[CreateAssetMenu(fileName = "new Goods", menuName = "Goods", order = 51)]
public class Goods : ScriptableObject
{
    [SerializeField] private string _lable;
    [SerializeField] private string _description;
    [SerializeField] private int _price;

    public string Lable => _lable;
    public string Description => _description;
    public int Price => _price;

    public void ShowInfoByGoods() => Debug.Log($"����� ���������� {_lable}, {_description}, �� {_price}.");
    public void BuyGoods() => Debug.Log($"�� ������ {_lable} �� {_price} �������");
}