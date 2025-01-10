using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float speed = 5f; // Speed of upward movement

    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
