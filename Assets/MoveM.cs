using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveM : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Vector3 randomDirection;
    private float changeDirectionTimer;
    private float minChange = 3f;
    private float maxChange = 8f;
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
        ChangeDirection();
    }

    
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= 5f && Vector3.Distance(transform.position, player.position) >= 1f)
        {
            agent.SetDestination(player.position);
        }
        else if (Vector3.Distance(transform.position, player.position) < 1f)
        {
            agent.SetDestination(transform.position);
        }
        else
        {
            changeDirectionTimer -= Time.deltaTime;
            if (changeDirectionTimer <= 0)
            {
                ChangeDirection();
            }
            agent.SetDestination(transform.position + randomDirection);
        }
    }

    void ChangeDirection()
    {
        randomDirection = Random.insideUnitSphere * 10f;
        changeDirectionTimer = Random.Range(minChange, maxChange);
    }
}