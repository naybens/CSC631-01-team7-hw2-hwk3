using UnityEngine;

public class AttackEffect : MonoBehaviour
{
    public GameObject visualEffectPrefab;  // The prefab for the visual effect
    public float effectDuration = 2f;      // The duration of the visual effect
    public float effectScale = 1f;         // The scale of the visual effect

    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has a specific tag or layer to determine if it can be attacked
        if (other.CompareTag("Enemy"))
        {
            // Create a new instance of the visual effect at the position of the attack object
            GameObject effectInstance = Instantiate(visualEffectPrefab, transform.position, Quaternion.identity);

            // Set the scale of the effect
            effectInstance.transform.localScale = Vector3.one * effectScale;

            // Destroy the effect after the specified duration
            Destroy(effectInstance, effectDuration);
        }
    }
}

