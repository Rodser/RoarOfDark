using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts.Interactions
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private float stoppingDistance = 2f;
        NavMeshAgent playerAgent;

        public virtual void MoveToInteraction(NavMeshAgent playerAgent)
        {
            this.playerAgent = playerAgent;
            playerAgent.SetDestination(this.transform.position);
            playerAgent.stoppingDistance = stoppingDistance;
            Interact();
        }

        public virtual void Interact()
        {
            print("interact witn base");
        }
    }
}