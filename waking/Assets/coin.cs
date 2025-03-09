using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure the Player has the "Player" tag
        {
            // Call the function in GameManage
            FindObjectOfType<GameManage>().CoinCollected();

            // Disable the coin's visuals and collider
            GetComponent<MeshRenderer>().enabled = false; // Hides the coin
            GetComponent<Collider>().enabled = false; // Disables collision
        }
    }
}