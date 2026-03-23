using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 20f;

    private void Start()
    {
       
    }

    private void Update()
    {
        RotateAround();
    }

    private void RotateAround()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime , Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}
