using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName  = "NewItem")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public int item;
    public GameObject itemPrefab;
    public GameObject handitemPrefab;


}
