using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 10;

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null
        && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    // when a missile is intantiated, a coroutine called deathTimer() is started
    void Start()
    {
        StartCoroutine("deathTimer");
    }
    // Move the missile forward
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    // If missiles don't hit player, they auto-destruct
    IEnumerator deathTimer()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
