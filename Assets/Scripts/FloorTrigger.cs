using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    [SerializeField] private float _destroyCountdown = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        // if it hits the floor, it destorys itself after the countdown
        if (collision.rigidbody.CompareTag("Apple"))
        {
            Destroy(collision.gameObject, _destroyCountdown);
        }
    }
}