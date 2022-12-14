using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    private new Rigidbody2D rigidbody;

    public HealthBar healthBar;

    public static HealthManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemies" || other.gameObject.tag == "Boss")
        {
            TakeDamage(1);
            StartCoroutine(Knockback());
            PlayerPrefs.SetInt("beingHit", 1);
        }
        if(other.gameObject.tag == "Healing")
        {
            if(currentHealth < maxHealth)
            {
                currentHealth += 1;
                healthBar.SetHealth(currentHealth);
                other.gameObject.SetActive(false);
                PlayerPrefs.SetInt("healing", 1);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth == 0)
        {
            StartCoroutine(LoadGameOver());
        }
    }

    public IEnumerator LoadGameOver() {
        PlayerPrefs.SetInt("dying", 1);
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("GameOver");
    }

    public IEnumerator Knockback() {
        if (currentHealth > 0) {
            rigidbody.AddForce(-transform.right * 2500);
            yield return new WaitForSeconds(0.1f);
            rigidbody.velocity = Vector2.zero;
        }
    }
}
