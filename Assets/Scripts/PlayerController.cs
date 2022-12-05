using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private bool isSwimming;
    private bool isHurt;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private float maxHealth = 250;
    [SerializeField] private float winTime;

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI timerText;


    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        updateUI();
        checkInput();
        checkIfDead();
        checkIfWin();
        Debug.Log("health: " + currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.CompareTag("Projectile"))
        {
            doDamage(obj.GetComponent<ProjectileScript>().getProjectile().Damage);
            Destroy(obj);
        }
    }

    private void updateUI()
    {
        healthText.text = "Health: " + currentHealth;
        timerText.text = "Remaining: " + Mathf.Round(winTime - TimerSingleton.Timer.currentTime) + "s";
    }
    private void checkInput()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void checkIfDead()
    {
        if (currentHealth < 0)
        {
            Debug.Log("lose");

        }
    }

    private void checkIfWin()
    {
        if (TimerSingleton.Timer.currentTime > winTime)
        {
            Debug.Log("win");
        }
    }

    private void doDamage(float damage)
    {
        currentHealth -= damage;
    }

    public float getCurrentHealth()
    {
        return currentHealth;
    }

}
