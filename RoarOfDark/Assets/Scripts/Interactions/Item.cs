using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Interactions
{
    public class Item : Interactable
    {
        public override void Interact()
        {
            print("interact with Item");
        }
    }
}