using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public float speed = 7.0f;
    // Use this for initialization
    void Start () {
        characterController = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0f);
        moveDirection *= speed;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
