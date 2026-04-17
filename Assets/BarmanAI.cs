using Seagull.Bar_02.SceneProps;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class BarmanAI : MonoBehaviour
{
    public Animator barAnimator;
    public Transform player;
    public GameObject BarCenter;
    public bool MissionActiv = false;
    public Animator BarmanAnimator;
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
        if (MissionActiv == false)
        {
            BarmanAnimator.SetBool("Walk", true);
            changeDirectionTimer -= Time.deltaTime;


            if (changeDirectionTimer <= 0)
            {
                ChangeDirection();
            }

            agent.SetDestination(transform.position + randomDirection);          
        }

        if (MissionActiv == true)
        {
            if (Vector3.Distance(transform.position, player.position) < 1f)
            {
                agent.SetDestination(transform.position);
                if (AnimatorController.ShakingHands == true)
                {
                  
                }
            }
            transform.localEulerAngles = new Vector3(0, -90, 0);
            transform.position = new Vector3((float)-53.87, 0.2f, 7.7f);
            BarmanAnimator.SetBool("Idle", true);
        }

    }

    void ChangeDirection()
    {
        randomDirection = Random.insideUnitSphere * 10f;
        changeDirectionTimer = Random.Range(minChange, maxChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Wall");
        Debug.Log("столкнулись со стеной");
        agent.SetDestination(BarCenter.transform.position);
    }
}


