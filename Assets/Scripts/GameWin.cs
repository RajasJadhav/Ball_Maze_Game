using UnityEngine;

public class GameWin : MonoBehaviour
{
    private GameManager gameManager;
    private AudioSource audioSource;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioSource = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        gameManager.GameWin();
    }
}
