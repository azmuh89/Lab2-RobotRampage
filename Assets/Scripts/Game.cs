using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static Game singleton;

    [SerializeField]
    RobotSpawn[] spawns;

    public int enemiesLeft;

    // Initialize the singleton and call SpawnRobots()
    void Start()
    {
        singleton = this;
        SpawnRobots();
    }
    // Go through each RObotSpawn in array and cal SpawnRobot() to actually spawn robot
    private void SpawnRobots()
    {
        foreach (RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }
    
    void Update()
    {
        
    }
}
