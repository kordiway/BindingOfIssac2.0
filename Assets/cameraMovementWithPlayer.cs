using UnityEngine;

public class cameraMovementWithPlayer : MonoBehaviour {
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    // Happens when the player collides with the key
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<PlayerMovement>().hasKey = true;
            Destroy(gameObject);
        }
    }
}
