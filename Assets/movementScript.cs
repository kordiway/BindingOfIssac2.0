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

    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 direction = mousePos - transform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
    transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}