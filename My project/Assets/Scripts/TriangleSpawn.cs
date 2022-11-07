using UnityEngine;

public class TriangleSpawn : MonoBehaviour
{
    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;
    [SerializeField] private GameObject triangle;

    private void Awake()
    {
        RandomSpawn(1, 3, 1, pos1, triangle);
        RandomSpawn(1, 3, 1, pos2, triangle);

    }

    private void RandomSpawn(int minRange, int maxRange, int randomRange, Transform posSpawn, GameObject prefabSpawn)
    {
        int x = Random.Range(minRange, maxRange);
        if (x == randomRange)
        {
            GameObject _prefabSpawn = Instantiate(prefabSpawn) as GameObject;
            _prefabSpawn.transform.position = posSpawn.position;
        }

    }
}
