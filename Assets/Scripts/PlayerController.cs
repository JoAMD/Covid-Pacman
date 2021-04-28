using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isActive = false;
    [SerializeField] private float speed = 1f;
    [SerializeField] private PersonManager personManager; //make singleton later

    //public void OnMouseClick()
    //{
    //    print("clicked me!");
    //    isActive = true;
    //}

    public void SetIsActive(bool isActive)
    {
        this.isActive = isActive;
    }

    private void OnMouseDown()
    {
        print("mouse down!");
        personManager.UpdateActivatePlayer(this);
        isActive = true;
    }

    private void Update()
    {
        if (isActive)
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);
        }
    }

    //For now its in this script
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DoorInteract"))
        {
            collision.TryGetComponent(out DoorController doorController);
            doorController.isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DoorInteract"))
        {
            collision.TryGetComponent(out DoorController doorController);
            doorController.isPlayerInRange = false;
        }
    }

}
