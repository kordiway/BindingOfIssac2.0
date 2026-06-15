using UnityEngine;

public class MeleeDamageScript : MonoBehaviour
{
   [SerializeField] private int damage = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<HitDummy>().TakeHit(damage);
        }
    }
}
