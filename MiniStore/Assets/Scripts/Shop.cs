using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Goods> _goods;
    [SerializeField] private Wallet _wallet;

    private void Start()
    {
        foreach (var good in _goods)
            good.ShowInfoByGoods();
    }
}