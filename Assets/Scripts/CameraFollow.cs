using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0 , 2.5f , -1.5f);

    private void Update()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        transform.position = player.transform.position + offset;
    }

}
