using UnityEngine;

public class GoodsViev : MonoBehaviour
{
    [SerializeField] private Goods _goods;

    [SerializeField] private string _lable;
    [SerializeField] private string _description;
    [SerializeField] private int _price;

    private void Start()
    {
        _lable = _goods.Lable;
        _description = _goods.Description;
        _price = _goods.Price;
    }
}