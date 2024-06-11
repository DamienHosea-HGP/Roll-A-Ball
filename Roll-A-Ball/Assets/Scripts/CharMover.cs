using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMover : MonoBehaviour
{
    public float moveSpeed = 10f;

    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
    }
}
