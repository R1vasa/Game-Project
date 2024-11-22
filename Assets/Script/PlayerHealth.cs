using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float Currenthealth { get; private set; }

    private void Awake()
    {
        Currenthealth = startingHealth;
    }

    public void TakeDamage(float damage)
    {
        Currenthealth = Mathf.Clamp(Currenthealth - damage, 0, startingHealth);

        if (Currenthealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            TakeDamage(1);
        }
        {
            
        }
    }
}
