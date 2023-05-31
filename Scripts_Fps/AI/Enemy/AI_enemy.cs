using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_enemy : MonoBehaviour   
{
    public NavMeshAgent navMeshAgent;

    public Transform [] destinations;
    public float distanceToFolloWPath =2;
    private int i = 0; // indice

    [Header("------FolowPlayer------")]

    public bool followPlayer;
    private GameObject player;
    private float distanceToPlayer;
    public float distanceToFollowPlayer = 10;
 
    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position; 
        player = FindObjectOfType<PlayerMovement>().gameObject; // Posicion del jugador
    }

    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer <= distanceToFollowPlayer && followPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }
    }

    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].position;
        if(Vector3.Distance(transform.position, destinations[i].position) <= distanceToFolloWPath)
        {
            if(destinations[i] != destinations[destinations.Length -1])
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }
    }

    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }
}
