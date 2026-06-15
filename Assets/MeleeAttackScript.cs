using UnityEngine;
using System.Collections;

public class MeleeAttackScript : MonoBehaviour {
     public GameObject hitbox;
    public float attackDuration = 0.2f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack() {
        hitbox.SetActive(true);
        yield return new WaitForSeconds(attackDuration);
        hitbox.SetActive(false);
    }
}
