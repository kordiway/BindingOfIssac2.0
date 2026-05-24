using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    void OnCollisionEnter2D(Collision2D other)
{
    if (other.gameObject.CompareTag("HitDummy"))
    {
        other.gameObject.GetComponent<HitDummy>().TakeHit(damage);
    }
}
}