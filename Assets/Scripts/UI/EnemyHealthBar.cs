using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private GameObject fill;
    private float maxHealth;
    private float currentHealth;

    public void SetMaxHealth(float health)
    {
        maxHealth = health;
        currentHealth = health;
        fill.transform.localScale = new Vector3(1, 0.3f, 1);
        fill.transform.localPosition = new Vector3(0, 0, -0.1f);
    }

    public void SetHealth(float health)
    {
        currentHealth = health;
        float fillAmount = currentHealth / maxHealth;
        fill.transform.localScale = new Vector3(fillAmount, 0.3f, 1);
        fill.transform.localPosition = new Vector3((-1 + fillAmount) / 2, 0, -0.1f);
    }
}