using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MouseMove : MonoBehaviour
{
    public Animator animator;
    public NavMeshAgent agent;
    [SerializeField] public float m_moveSpeed = 2;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                animator.Play("run", -1, 0);
                agent.destination = hit.point;
            }
        }
    }
}
