using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DeliveryManager : MonoBehaviour
{
public AudioManager audioManager;
	public GameObject restaurantPickup;
    public GameOverManager gameOverManager;
    public Transform[] deliveryPoints;
    public Transform deliveryMarker;
    public float deliveryTime = 10f;

    public TMP_Text scoreText;
    public TMP_Text statusText;
    public Image timerBarFill;

    private int currentPointIndex = -1;
    private int score = 0;
    private float timer;
    private bool hasFood = false;
    private bool deliveryActive = false;

    void Start()
    {
        timer = deliveryTime;
        deliveryMarker.gameObject.SetActive(false);
        UpdateUI();
    }

    void Update()
    {
        if (deliveryActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                gameOverManager.GameOver();
            }
        }

        UpdateUI();
    }

    public void PickupFood()
{
    if (hasFood) return;

    hasFood = true;
    deliveryActive = true;
    timer = deliveryTime;

    MoveMarkerToRandomPoint();
    deliveryMarker.gameObject.SetActive(true);
    restaurantPickup.SetActive(false);

audioManager.PlayPickupSound();

    Debug.Log("Food picked up! Deliver it now.");
    UpdateUI();
}

    public void MoveMarkerToRandomPoint()
    {
        if (deliveryPoints.Length == 0) return;

        int newIndex = Random.Range(0, deliveryPoints.Length);

        while (newIndex == currentPointIndex && deliveryPoints.Length > 1)
        {
            newIndex = Random.Range(0, deliveryPoints.Length);
        }

        currentPointIndex = newIndex;
        deliveryMarker.position = deliveryPoints[currentPointIndex].position;
    }

    public void DeliveryCompleted()
{
    if (!hasFood || !deliveryActive) return;

    score++;
    hasFood = false;
    deliveryActive = false;
    timer = deliveryTime;

    deliveryMarker.gameObject.SetActive(false);
    restaurantPickup.SetActive(true);
audioManager.PlayDeliverySound();
    Debug.Log("Delivery complete! Score: " + score);
    UpdateUI();
}

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;

        if (deliveryActive)
        {
            timerBarFill.fillAmount = timer / deliveryTime;
        }
        else
        {
            timerBarFill.fillAmount = 0f;
        }

        if (hasFood)
        {
            statusText.text = "Deliver the food!";
        }
        else
        {
            statusText.text = "Go to the restaurant";
        }
    }
}