using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private GameObject healthBarPrefab;
    private float currentHealth;
    private EnemyHealthBar healthBar;

    void Awake()
    {
        currentHealth = maxHealth;
        GameObject bar = Instantiate(healthBarPrefab, transform.position + Vector3.up * 0.7f, Quaternion.identity);
        healthBar = bar.GetComponent<EnemyHealthBar>();
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (healthBar != null)
        {
            healthBar.transform.position = transform.position + Vector3.up * 0.7f;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(healthBar.gameObject);
            Destroy(gameObject);
        }
    }
}