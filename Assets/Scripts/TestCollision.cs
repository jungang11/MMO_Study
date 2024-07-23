using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) 나 혹은 상대한테 Rigidbody 있어야 한다. (isKineamatic : off)
    // 2) 나한테 Collider 있어야 한다. (isTrigger : off)
    // 3) 상대한데 Collider가 있어야 한다. (isTrigger : off)
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"Collision Enter : {other.gameObject.name}");
    }

    // 1) 둘 다 Collider가 있어야 한다.
    // 2) 둘 중 하나는 isTrigger : On
    // 3) 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger Enter : {other.gameObject.name}");
    }
}