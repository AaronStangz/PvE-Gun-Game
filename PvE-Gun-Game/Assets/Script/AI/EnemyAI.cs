using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float walkSpeed = 3f; // Speed while walking
    public float runSpeed = 5f; // Speed while running
    public float chaseDistance = 20f; // Distance to start chasing the player
    public float idleTimeMin = 2f; // Minimum time for idle walk
    public float idleTimeMax = 5f; // Maximum time for idle walk
    public Animator animator;

    public SphereCollider RunningToPlayer; // Collider for running behavior
    public SphereCollider WalkingToPlayer; // Collider for walking behavior

    public bool ActiveIdle = true;
    public bool ActiveRunningToPlayer = false;
    public bool ActiveWalkingToPlayer = false;

    private NavMeshAgent agent; // Reference to the NavMeshAgent component
    private Vector3 randomDestination; // For random idle walking
    private float idleTimer; // Timer for idle walking

    private void Start()
    {
        //player = player.transform.Find("Player");
        if (player == null)
        {
            Debug.LogError("Player not assigned in the Inspector.");
        }

        agent = GetComponent<NavMeshAgent>();
        SetRandomDestination();
        idleTimer = Random.Range(idleTimeMin, idleTimeMax);
    }

    private void Update()
    {
        if (ActiveIdle)
        {
            IdleWalk();
        }
        else if (ActiveRunningToPlayer)
        {
            ChasePlayer();
        }
        else if (ActiveWalkingToPlayer)
        {
            WalkPlayer();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        // Check if the collider belongs to the player
        if (collider.CompareTag("Player"))
        {
            float distanceToPlayer = Vector3.Distance(transform.position, collider.transform.position);

            if (distanceToPlayer < chaseDistance) // chaseDistance is a threshold for running
            {
                ActiveIdle = false;
                ActiveRunningToPlayer = true;
                ActiveWalkingToPlayer = false;
            }
            else
            {
                ActiveIdle = false;
                ActiveRunningToPlayer = false;
                ActiveWalkingToPlayer = true;
            }
        }
    }

    private void IdleWalk()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            idleTimer -= Time.deltaTime;
            if (idleTimer <= 0)
            {
                SetRandomDestination();
                idleTimer = Random.Range(idleTimeMin, idleTimeMax);
            }
        }
        agent.speed = walkSpeed;
    }

    private void ChasePlayer()
    {
        agent.destination = player.position;
        agent.speed = runSpeed;
    }

    private void WalkPlayer()
    {
        agent.destination = player.position;
        agent.speed = walkSpeed;
    }

    private void SetRandomDestination()
    {
        animator.SetTrigger("TrWalking");
        float randomRadius = 20f;
        Vector3 randomPoint = transform.position + Random.insideUnitSphere * randomRadius;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomPoint, out hit, randomRadius, NavMesh.AllAreas);
        randomDestination = hit.position;
        agent.SetDestination(randomDestination);
    }
}

