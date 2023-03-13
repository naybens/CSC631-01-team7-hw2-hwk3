using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillitem : MonoBehaviour
{
    public GameObject objectPrefab;

    private Rigidbody objectRigidBody;
    private bool isPickedUp = false;

    private void Start()
    {
        objectRigidBody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        if (!isPickedUp)
        {
            objectRigidBody.isKinematic = true;
            transform.parent = Camera.main.transform;
            isPickedUp = true;
        }
        else
        {
            objectRigidBody.isKinematic = false;
            transform.parent = null;
            isPickedUp = false;
        }
    }

    private void OnMouseUpAsButton()
    {
        if (objectPrefab != null)
        {
            Vector3 spawnPosition = transform.position + transform.forward * 2f;
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
