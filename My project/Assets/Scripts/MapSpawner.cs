using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private Transform storage;
    [SerializeField] private int offset;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameObject floorpiece = Instantiate(floor) as GameObject;
            floorpiece.transform.position = new Vector3(transform.position.x + offset, -4.435f, 0);
            floorpiece.transform.SetParent(storage);
        }
    }

    public void ClearStorage()
    {
        for (int x = 0; x < storage.childCount; x++)
        {
            Destroy(storage.GetChild(x).gameObject);
        }
    }
}
