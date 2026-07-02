using UnityEngine;

public class ArrowScript : MonoBehaviour {
    public float speed = 12f;
    public float lifetime = 3f;
    private Vector2 direction;

     [SerializeField] private int damage = 10;

    public void Init(Vector2 dir) {
        direction = dir;
        Destroy(gameObject, lifetime);
    }

    void Update() {
        transform.Translate(direction * speed * Time.deltaTime);
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<HitDummy>().TakeHit(damage);
            Destroy(gameObject);
        }
    }
}