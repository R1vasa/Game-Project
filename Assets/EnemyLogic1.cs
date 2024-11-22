using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyLogic : MonoBehaviour
{
    public float movespeed;
    public float maxHealth = 100f;
    private float currentHealth;
    public Image healthBarImage;
    private float damage;
    //public GameManagerLogic gameManagerLogic;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!gameManagerLogic.GameOver)
        {
            Vector3 direction = new Vector3(-1, 0, 0);
            transform.position += direction * movespeed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            TakeDamage(20f);
        }
        if (collision.gameObject.CompareTag("Collider"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponentInParent<PlayerHealth>().TakeDamage(1);
            
            //gameManagerLogic.GameOver = true;
            //gameManagerLogic.ui.gameObject.SetActive(true);
        }

    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthBarImage != null)
        {
           healthBarImage.fillAmount = currentHealth/maxHealth;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    private void AddScore()
    {
        ScoreLogic.Instance.AddScore(10);
    }
}
