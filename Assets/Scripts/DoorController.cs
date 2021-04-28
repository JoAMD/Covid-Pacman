using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Transform door;
    public bool isPlayerInRange = false;
    private bool isOpen = true;

    private void Update()
    {
        //for now its in this script
        if (isOpen && isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            print("close door");
            door.DOLocalRotate(Vector3.zero, 1);
            isOpen = false;
        }
    }
}
