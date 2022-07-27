using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;
    Vector3 camPosition;
    [SerializeField]
    private float moveSpeed = 10;
    private void Start()
    {
        camPosition = mainCamera.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        float right = Input.GetAxis("Horizontal");

        float forward = Input.GetAxis("Vertical");

        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(right, 0, forward)*moveSpeed);
        mainCamera.transform.position=gameObject.transform.position+camPosition;
    }
}
