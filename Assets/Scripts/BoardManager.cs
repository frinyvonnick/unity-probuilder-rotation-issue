using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private MeshCollider meshCollider;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0) {
            transform.RotateAround(meshCollider.bounds.center,Vector3.back, horizontalInput * speed * Time.deltaTime);
        }

        if (verticalInput != 0)
        {
            transform.RotateAround(meshCollider.bounds.center, Vector3.right, verticalInput * speed * Time.deltaTime);
        }
    }
}
