using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + offset, transform.position.y, transform.position.z);
    }
}
