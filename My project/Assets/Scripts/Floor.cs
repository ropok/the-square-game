using UnityEngine;

public class Floor : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < (player.transform.position.x - 10))
        {
            Destroy(gameObject);
        }

    }
}
