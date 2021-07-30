using Assets.Scripts.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


namespace Assets.Scripts
{
    public class WorldInteraction : MonoBehaviour
    {
        NavMeshAgent playerAgent;

        private void Start()
        {
            playerAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                GetInteraction();
            }
        }

        private void GetInteraction()
        {
            Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit interactionInfo;
            if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
            {
                GameObject interactedObject = interactionInfo.collider.gameObject;
                if (interactedObject.CompareTag("Interaction"))
                {
                    interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
                }
                else
                {
                    playerAgent.stoppingDistance = 0f;
                    playerAgent.SetDestination(interactionInfo.point);
                }
            }
        }
    }
}
