using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonstersMove : MonoBehaviour
{
    [SerializeField]
    Transform _destination1;
    [SerializeField]
    Transform _destination2;
    [SerializeField]
    Transform _destination3;
    [SerializeField]
    Transform _destination4;

    

    int moveDirection = 1;

    NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = 1;
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        
        if (_navMeshAgent == null)
        {
            Debug.Log("The nav mesh agent component is not attached to " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (_destination1 != null)
        {
            Vector3 targetVector = _destination1.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDirection == 1)
        {
            if ((_destination1.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination2.transform.position);
                Debug.Log(transform.position);
            }
            else if ((_destination2.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination3.transform.position);
                Debug.Log(transform.position);
            }
            else if ((_destination3.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination4.transform.position);
                Debug.Log(transform.position);
            }
            else if ((_destination4.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination1.transform.position);
                Debug.Log(transform.position);
                moveDirection = 2;
            }
        }
        else if (moveDirection == 2)
        {
            if ((_destination1.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination2.transform.position);
                Debug.Log(transform.position);
            }
            else if ((_destination2.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination3.transform.position);
                Debug.Log(transform.position);
            }
            else if ((_destination3.transform.position - transform.position).magnitude < 1)
            {
                _navMeshAgent.SetDestination(_destination4.transform.position);
                Debug.Log(transform.position);
                moveDirection = 1;
            }
        }

    }
}