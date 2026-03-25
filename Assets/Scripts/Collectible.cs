using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 30f;
    private int scoreToAdd = 10;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        RotateAround();
    }

    private void RotateAround()
    {
        if(gameManager.isGameActive)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.UpdateScore(scoreToAdd);
    }


}
