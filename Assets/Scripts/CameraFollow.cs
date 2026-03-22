using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0 , 1.5f , -3);

    private void Update()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        transform.position = player.transform.position + offset;
    }

}
