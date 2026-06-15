using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    private TextMeshPro damageText;
    private float fadeSpeed = 1f;
    private float moveUpSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        damageText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveUpSpeed * Time.deltaTime;

        Color color = damageText.color;
        color.a -= fadeSpeed * Time.deltaTime;
        damageText.color = color;

        if (color.a <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void SetDamageText(int damage)
    {
        damageText.text = damage.ToString();
    }
}
