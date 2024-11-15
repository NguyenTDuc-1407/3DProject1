using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] Animator animator;
    Vector3 moveInput;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movePlayer();
    }
    void movePlayer()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");
        animator.SetFloat("move", moveInput.sqrMagnitude);
        transform.position += moveInput * moveSpeed * Time.deltaTime;
    }
}
