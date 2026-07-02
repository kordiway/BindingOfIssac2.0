using UnityEngine;
using System.Collections;

public class MeleeAttackScript : MonoBehaviour {
    [Header("Melee")]
    public GameObject hitbox;
    public float attackDuration = 0.2f;

    [Header("Ranged")]
    public GameObject arrowPrefab;
    public Transform bow; // drag your bow sub-object here
    public float shootCooldown = 0.3f;
    private float shootTimer;

    void Update() {
        // Melee
        if (Input.GetMouseButtonDown(1)) {
            StartCoroutine(Attack());
        }

        // Ranged
        shootTimer -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && shootTimer <= 0f) {
            ShootAtMouse();
        }
    }

    IEnumerator Attack() {
        hitbox.SetActive(true);
        yield return new WaitForSeconds(attackDuration);
        hitbox.SetActive(false);
    }

    void ShootAtMouse() {
        shootTimer = shootCooldown;

        // Get mouse position in world space
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0;

        // Direction from bow to mouse
        Vector2 dir = (mouseWorld - bow.position).normalized;

        GameObject arrow = Instantiate(arrowPrefab, bow.position, Quaternion.identity);
        arrow.GetComponent<ArrowScript>().Init(dir);
    }
}