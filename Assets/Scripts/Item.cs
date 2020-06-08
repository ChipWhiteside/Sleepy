using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public ItemClass iclass;
    public Sprite icon = null;

    public void Use()
    {
        Debug.Log("Used " + name + " (" + iclass + " class)");
    }
}

public enum ItemClass { Physical, Spiritual, Pyro }