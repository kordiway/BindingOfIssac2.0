using UnityEngine;

public class EnemyArrow : MonoBehaviour {
    public float speed = 6f;
    public float lifetime = 3f;
    public int damage = 1;
    private Vector2 direction;

    public void Init(Vector2 dir) {
        direction = dir;
        Destroy(gameObject, lifetime);
    }

    void Update() {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            // Spot for code when arrow hits player
            Destroy(gameObject);
        }
    }
}