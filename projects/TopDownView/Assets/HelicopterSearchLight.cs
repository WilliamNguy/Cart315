using UnityEngine;

public class HelicopterSearchlight : MonoBehaviour
{
    public GameOverManager gameOverManager;
    public Transform player;

    [Header("Search Area")]
    public Vector2 searchAreaCenter = Vector2.zero;
    public Vector2 searchAreaSize = new Vector2(20f, 12f);

    [Header("Movement")]
    public float searchSpeed = 2f;
    public float chaseSpeed = 4f;
    public float pointReachDistance = 0.2f;

    [Header("Catch Settings")]
    public float catchTime = 5f;

    private Vector2 currentTarget;
    private bool chasingPlayer = false;
    private bool playerInsideLight = false;
    private float caughtTimer = 0f;

    void Start()
    {
        PickRandomSearchTarget();
    }

    void Update()
    {
        if (chasingPlayer && player != null)
        {
            MoveTowardsTarget(player.position, chaseSpeed);
        }
        else
        {
            MoveTowardsTarget(currentTarget, searchSpeed);

            float distance = Vector2.Distance(transform.position, currentTarget);
            if (distance < pointReachDistance)
            {
                PickRandomSearchTarget();
            }
        }

        if (playerInsideLight)
        {
            caughtTimer += Time.deltaTime;

            if (caughtTimer >= catchTime)
            {
                gameOverManager.GameOver();
            }
        }
        else
        {
            caughtTimer = 0f;
        }
    }

    void MoveTowardsTarget(Vector2 targetPosition, float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    void PickRandomSearchTarget()
    {
        float randomX = Random.Range(
            searchAreaCenter.x - searchAreaSize.x / 2f,
            searchAreaCenter.x + searchAreaSize.x / 2f
        );

        float randomY = Random.Range(
            searchAreaCenter.y - searchAreaSize.y / 2f,
            searchAreaCenter.y + searchAreaSize.y / 2f
        );

        currentTarget = new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            chasingPlayer = true;
            playerInsideLight = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideLight = false;
            chasingPlayer = false;
            PickRandomSearchTarget();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(searchAreaCenter, searchAreaSize);
    }
}