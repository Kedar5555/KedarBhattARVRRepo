using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Reference to the score manager to update score
    private ScoreManager scoreManager;

    void Start()
    {
        // Find the ScoreManager in the scene (make sure there's only one)
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the other object has a Rigidbody (assumed to be the car)
        Rigidbody otherRigidbody = collision.rigidbody;
        if (otherRigidbody != null && otherRigidbody != this.GetComponent<Rigidbody>())
        {
            // Show the cube's GameObject by setting it active (or other display logic)
            gameObject.SetActive(true);

            // Update the score
            scoreManager.IncreaseScore(1);
        }
    }
}
