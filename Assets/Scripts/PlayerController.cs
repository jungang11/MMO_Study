using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10.0f;

    void Awake()
    {
        Managers mg = Managers.Instance;
    }

    void Update()
    {
        // Local -> World
        // TransfromDirection

        // World -> Local
        // InverseTransfromDirection

        // 혹은 transform.Translate(Vector3 direction) : transform의 Local 기준으로 이동

        if(Input.GetKey(KeyCode.W))
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.S))
            transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))
            transform.position += transform.TransformDirection(Vector3.left * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.D))
            transform.position += transform.TransformDirection(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
