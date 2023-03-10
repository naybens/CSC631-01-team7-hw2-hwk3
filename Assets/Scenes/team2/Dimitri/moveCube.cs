using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed = 0.1f;

    private Rigidbody cube;

    void Start() {
        cube = GetComponent<Rigidbody> ();
    }
    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDir, 0.0f, zDir);

        cube.AddForce(moveDirection * speed);
    }
}
