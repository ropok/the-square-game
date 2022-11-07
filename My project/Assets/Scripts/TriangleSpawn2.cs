using UnityEngine;

public class TriangleSpawn2 : MonoBehaviour
{
    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;
    public GameObject triangle;

    private void Start()
    {
        int x = Random.Range(1, 3);
        if (x == 1)
        {
            GameObject Triangle = Instantiate(triangle) as GameObject;
            Triangle.transform.position = pos1.position;
            Triangle.transform.SetParent(transform);
        }
        x = Random.Range(1, 3);
        if (x == 1)
        {
            GameObject Triangle = Instantiate(triangle) as GameObject;
            Triangle.transform.position = pos2.position;
            Triangle.transform.SetParent(transform);
        }
    }
}
