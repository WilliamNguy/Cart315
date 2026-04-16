using UnityEngine;

public class RestaurantPickup : MonoBehaviour
{
    public DeliveryManager deliveryManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            deliveryManager.PickupFood();
        }
    }
}