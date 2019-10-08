using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField]
    private string robotType;

    public int health;
    public int range;
    public float fireRate;

    public Transform missileFireSpot;
    UnityEngine.AI.NavMeshAgent agent;

    private Transform player;
    private float timeLastFired;

    private bool isDead;

    void Start()
    {
        // set agent and player values to navmesh agent and player components
        isDead = false;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // check if the robot is dead before continuing
        if (isDead)
        {
            return;
        }
        
        transform.LookAt(player); // make robot face player

        agent.SetDestination(player.position); // tell robot to use navmesh to find player

        // check to see if robot is within firing range of there's enough time between shots to fire again
        if (Vector3.Distance(transform.position, player.position) < range && Time.time - timeLastFired > fireRate)
        {
            timeLastFired = Time.time;
            fire();
        }
    }

    private void fire()
    {
        Debug.Log("Fire");
    }
}