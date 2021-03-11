using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveRightKey = KeyCode.D;
    public KeyCode JumpKey = KeyCode.W;
    public KeyCode Block = KeyCode.E;
    bool canjump = false;
    float direction = 0.0f;
    public float speed = 0.2f;
    public int health = 100;
    public Animator animator;
    bool blocking = false;
    private Renderer rend;
    public Color damage1 = Color.white;
    public bool isTouchingGround = false;
    public bool faceLeft = true;

    public string unitTitle;
    public int unitLevel;
    public int damage;
    public int maxHealth;
    public int currentHealth;

    void FixedUpdate()
    {
        Vector3 Position = transform.localPosition;
        Position.x += speed * direction;
        transform.localPosition = Position;
    }

    void Update()
    {
        bool isLeftPressed = Input.GetKey(moveLeftKey);
        bool isRightPressed = Input.GetKey(moveRightKey);
        Jump();

        if (isLeftPressed)
        {
            direction = -1.0f;
        }
        else if (isRightPressed)
        {
            direction = 1.0f;
        }
        else
        {
            direction = 0.0f;
        }
    }

    void Flip()
    {
        faceLeft = !faceLeft;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isTouchingGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }

    }

    public void TakeDamage(int damage)
    {
        if (blocking == false)
        {
            health -= damage;

            if (health <= 0)
            {
                SceneManager.LoadScene("GameOverBlue");
            }
        }
    }
}