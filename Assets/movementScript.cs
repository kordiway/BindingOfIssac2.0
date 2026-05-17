using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 5f;
    public bool hasKey = false;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(x, y).normalized;
        rb.linearVelocity = movement * speed;
    }
}