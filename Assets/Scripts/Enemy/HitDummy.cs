using UnityEngine;
using TMPro;
public class HitDummy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject damagePopupPrefab;

public void TakeHit(int damage)
{
    GameObject popup = Instantiate(damagePopupPrefab, transform.position, Quaternion.identity);
    popup.GetComponent<DamagePopup>().SetDamageText(damage);
    GetComponent<Health>().TakeDamage(damage);
}
}
