using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pickups;

    // Instantiates a random pickup and sets its position to that of the PickupSpawn GameObject
    void spawnPickup()
    {
        // Instantiate a random pickup
        GameObject pickup = Instantiate(pickups[Random.Range(0, pickups.Length)]);
        pickup.transform.position = transform.position;
        pickup.transform.parent = transform;
    }
    // Waits 20 seconds before calling spawnPickup()
    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }
    // Spawns a pickup as soon as the game begins
    void Start()
    {
        spawnPickup();
    }
    // Starts the coroutine to respawn when the player has pickup up something
    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }
    
    void Update()
    {
        
    }
}
