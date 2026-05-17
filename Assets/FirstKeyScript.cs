using UnityEngine;

public class FirstKeyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    // If Collison detected
    void OnTriggerEnter2D(Collider2D other) {
        // If player tag specifically is detected
        if (other.CompareTag("Player")) {
            // Set player has key to true and destroy key object
            other.GetComponent<PlayerMovement>().hasKey = true;
            Destroy(gameObject);
        }
    }
}
