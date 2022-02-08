using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.InteractiveTutorials;
using UnityEngine.Events;

public class Zombie : MonoBehaviour
{
    private Transform player;
    private Animator anim;
    private NavMeshAgent nav;
    public UnityEvent Collision;

    [SerializeField] int damage;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        nav = GetComponent<NavMeshAgent>();
    
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Forward", nav.desiredVelocity.magnitude, 0.1f, Time.deltaTime);
        nav.SetDestination(player.position);
        anim.SetBool("Walk", true);
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.transform.CompareTag("Player"))
        {
            Collision.Invoke();
            other.transform.GetComponent<MainStatus>().DecreaseHp(damage);
        }
    }

}
