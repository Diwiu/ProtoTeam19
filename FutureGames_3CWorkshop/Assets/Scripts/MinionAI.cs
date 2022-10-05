using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class MinionAI : MonoBehaviour
{
    NavMeshAgent agent;

    GameObject target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        GoToTarget();
    }

    private void GoToTarget()
    {
        agent.SetDestination(target.transform.position);
    }
}
