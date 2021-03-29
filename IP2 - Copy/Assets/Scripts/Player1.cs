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
    public KeyCode Quickend = KeyCode.F;
    float direction = 0.0f;
    public float speed = 0.2f;
    public int health = 100;
    private Renderer rend;
    public bool isTouchingGround = false;
    public bool faceLeft = true;
    bool Turn1 = true;

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
        bool isEndPressed = Input.GetKey(Quickend);
        Jump();
        if (Turn1 == true)
        {
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
            if (isEndPressed)
            {
                SceneManager.LoadScene("GameOverRed");
            }
            StartCoroutine(Timer());
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(30f);
                Turn1 = false;
            }
        }
        if (Turn1 == false)
        {
            StartCoroutine(Timer());
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(30f);
                Turn1 = true;
            }
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
        bool isJumpPressed = Input.GetKey(JumpKey);

        if (isJumpPressed && isTouchingGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 10);
        }

    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOverBlue");
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "AreaZone":
                isTouchingGround = true;
                break;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "AreaZone":
                isTouchingGround = false;
                break;
        }
    }
}