using UnityEngine;

public class ItemsView : MonoBehaviour
{
    [SerializeField] private Items _goods;

    [SerializeField] private string _label;
    [SerializeField] private string _description;
    [SerializeField] private int _price;

    private void Start()
    {
        _label = _goods.Label;
        _description = _goods.Description;
        _price = _goods.Price;
    }
}