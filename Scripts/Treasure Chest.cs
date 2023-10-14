using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject itemPrefab; // Reference to the item prefab inside the chest

    public void Open()
    {
        GameObject item = Instantiate(itemPrefab, transform.position, Quaternion.identity);

        item.transform.SetParent(transform);

        
        Collider2D itemCollider = item.GetComponent<Collider2D>();
        if (itemCollider != null)
        {
            itemCollider.enabled = false;
        }
    }
}
