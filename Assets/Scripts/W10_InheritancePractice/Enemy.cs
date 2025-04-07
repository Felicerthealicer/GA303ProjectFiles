using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange; //enemy's attack range 

    public float attackSpeed;
    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    [SerializeField]
    protected float aggroRange = 30f; //the range in which the enemy will attack you 

    protected bool hasSeenPlayer = false;

    [SerializeField]
    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
    }

    protected virtual void Update()
    {
        if(hasSeenPlayer == true)
        {
            //DOES THE ENEMY STILL SEE THE PLAYER & ARE THEY WITHIN THE AGGRO RANGE (general movement)
            if(navAgent.remainingDistance < 0.5f) //enemy reached the LAST KNOWN location of the player 
            {
                if(Vector3.Distance(this.transform.position, player.transform.position) > aggroRange) //if player is further than the aggro Range 
                {
                    hasSeenPlayer = false; //enemy no longer sees the player, will be forced to return to patrol path 
                }
                else //if player is NOT out of aggro range 
                {
                    if(IsPlayerInLoS() == true) //if the player is within line of sight 
                    {
                        navAgent.SetDestination(player.transform.position); //enemy sees the player and destination is set to player's position 
                        navAgent.isStopped = false; //make sure it is allowed to move
                    }
                    else //if the player is within range, but not within line of sight 
                    {
                        hasSeenPlayer = false; //player has not been seen 
                    }
                }
            }

            //IS THE PLAYER WITHIN THE ATTACK RANGE
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange) //If the player is NOT within the attack range...)
            {
                if(IsPlayerInLoS() == true) //if the player is within line of sight
                {
                    navAgent.SetDestination(player.transform.position); //chase the player 
                    navAgent.isStopped = false; //make sure it is allowed to move 
                }
            }
            else //if the player is within attack range...
            {

                if (IsPlayerInLoS() == true) //if the player is within line of sight...
                {
                    navAgent.isStopped = true; //stop the nav movement 
                    this.transform.LookAt(player.transform.position); //keep looking at player

                    attackTimer += Time.deltaTime; //increase the attack timer

                    if (attackTimer > attackSpeed) //once the attack timer reaches the attack speed 
                    {
                        Attack(); //ATTACK 
                        attackTimer = 0; //reset the timer to 0
                    }
                }
                else //if the player is not within the line of sight 
                {
                    navAgent.isStopped = false; //keep moving to the next patrol point 
                }
                
            }
        }
        else //if the player is not within line of sight 
        {
            if (navAgent.remainingDistance < 0.5f) //if the enemy reahces its destination...
            {
                patrolPointIndex++; //increase patrolPointIndex so it will move to the next patrol point 

                if (patrolPointIndex >= patrolPoints.Count) //if patrol point is not within range...
                {
                    patrolPointIndex = 0; //reset it to 0 so that it will go back to the first point 
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //set destination to determined point 
            }
        }
    }

    protected bool IsPlayerInLoS()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {

            Debug.Log(hit.collider.name);

            if (hit.collider.tag == "Player")
            {
                return true;
            }
        }

        return false;
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
        //Call an Animation to attack OR Deal Damage to the Player 
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }    

    public void Die()
    {
        //Call Death Animation OR Destroy the Object 
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEntered");
        if(other.tag == "Player")
        {
            hasSeenPlayer = true;
        }
    }

    public void SeePLayer()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if(Physics.Raycast(this.transform.position, dir, out hit))
        {
            if(hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
        }
    }
}
