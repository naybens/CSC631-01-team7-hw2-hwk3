using UnityEngine;

public class CubeController : MonoBehaviour {
    private bool isHeld = false;
    private Vector3 startPosition;
    private Rigidbody rb;
    private Vector3 offset;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown() {
        isHeld = true;
        rb.isKinematic = true;
        startPosition = transform.position;

        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance;
        plane.Raycast(ray, out distance);
       offset = transform.position - ray.GetPoint(distance);
    }

    void OnMouseUp() {
        isHeld = false;
        rb.isKinematic = false;
        rb.AddForce(transform.position - startPosition, ForceMode.Impulse);
    }

    void Update() {
        if (isHeld) {
            Plane plane = new Plane(Vector3.up, transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if (plane.Raycast(ray, out distance)) {
                Vector3 newPosition = ray.GetPoint(distance);
                transform.position = newPosition;
            }
        }
    }
}
