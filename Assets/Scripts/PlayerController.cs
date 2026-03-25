using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private GameManager gameManager;
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if(gameManager.isGameActive){
            float verticalInput = Input.GetAxis("Vertical");
            float horizontalInput = Input.GetAxis("Horizontal");

            playerRb.AddForce(Vector3.forward * verticalInput * speed, ForceMode.Force);
            playerRb.AddForce(Vector3.right * horizontalInput * speed, ForceMode.Force);
        }
        
    }
}
