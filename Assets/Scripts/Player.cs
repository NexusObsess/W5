using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;

    [SerializeField] List<Enemy> enemy = new List<Enemy>();
    [SerializeField] int damageAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // lists, loops, ?
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = enemy.Count - 1; i >= 0; i--)
            {
                enemy[i].TakeDamage(1, i, this);
            }
           
        }
    }

    public void RemoveEnemy()
    {
        enemy.RemoveAt(id);
    }

    public void Addenemy()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 moveDirection = (Vector2.right * horizontal) + (Vector2.up * vertical); // Vector2(1,0)
        moveDirection *= speed * Time.deltaTime;

        rb.linearVelocity = moveDirection;
    }
    // void fixed update: every psyhics frame
}
