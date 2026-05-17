public enum EnemyState
{
    Idle,
    Aggro,
    Attack
}
public class EnemyAI : MonoBehaviour
{

    [SerializeField] private float speed = 3f;
    [SerializeField] private float detectionRange = 10f;
    
    private Rigidbody2D rb;
    private Transform player;
    private EnemyState currentState = EnemyState.Idle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
        case EnemyState.Idle:
            CheckLineOfSight();
            break;
        case EnemyState.Aggro:
            CheckLineOfSight();
            MoveTowardPlayer();
            break;
        }
    }

void CheckLineOfSight()
{
    Vector2 directionToPlayer = (player.position - transform.position).normalized;
    int layerMask = ~LayerMask.GetMask("Enemy");
    RaycastHit2D hit = Physics2D.Raycast(transform.position, directionToPlayer, detectionRange, layerMask);

    if (hit.collider != null && hit.collider.CompareTag("Player"))
    {
        currentState = EnemyState.Aggro;
    }
    else
    {
        currentState = EnemyState.Idle;
    }
}

void MoveTowardPlayer()
{
    Vector2 directionToPlayer = (player.position - transform.position).normalized;
    rb.MovePosition(rb.position + directionToPlayer * speed * Time.fixedDeltaTime);
}
}
