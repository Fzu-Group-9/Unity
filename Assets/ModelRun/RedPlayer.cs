using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    public GameObject menu;
    public GameObject BodyCollider;
    public static bool alive;
    public int canJump = 2;
    public float jumpForce = 18f;
    public float jumpDown = 40f;
    public bool isJumpPressed, canDash, isDashing;
    public Animator myAnim;
    public bool testModel;
    private Vector3 originPosition;
    Rigidbody2D myRigi;
    public AudioClip [] myAudioClip;
    AudioSource myAudioSource;

    // Start is called before the first frame update
    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAnim = GetComponent<Animator>();
        myRigi = GetComponent<Rigidbody2D>();
        originPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        alive = true;
    }

            void end_game()
    {
            Time.timeScale=0;
            menu.SetActive(true);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!alive)
        {
            return;
        }
        originPosition = new Vector3(originPosition.x, transform.position.y, transform.position.z);
        if (transform.position.x < originPosition.x)
        {
            if (originPosition.x - transform.position.x > 10f)
            {
                myAnim.SetTrigger("Die");
                alive = false;
            }
            transform.position = Vector3.MoveTowards(transform.position, originPosition, 1 * Time.deltaTime);
        }
        if (Input.GetKeyDown("k") && canJump > 0)
        {
            myAudioSource.PlayOneShot(myAudioClip[0]);
            canDash = false;
            if (canJump == 2)
            {
                isJumpPressed = true;
            }
            else if (canJump == 1)
            {
                myRigi.velocity = Vector2.up * 16;
            }
            canJump--;
        }
        if (Input.GetKeyDown("l") && !canDash)
        {
            myRigi.velocity = Vector2.down * jumpDown;
        }
        if (Input.GetKeyDown("l") && canDash)
        {
            myAnim.SetBool("Slide", true);
            canDash = false;
            isDashing = true;
            SetColliderOff();
        }
        if (Input.GetKeyUp("l"))
        {
            myAnim.SetBool("Slide", false);
            canDash = true;
            isDashing = false;
            SetColliderOn();
        }
    }
        public void level_pause()
    {
        Time.timeScale=0;
        menu.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
        if (isJumpPressed)
        {
            myRigi.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            isJumpPressed = false;
            myAnim.SetBool("Jump", true);
        }
    }
    public void SetColliderOn()
    {
        BodyCollider.SetActive(true);
    }
    public void SetColliderOff()
    {
        BodyCollider.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (testModel)
        {
            return;
        }
        if (collision.tag == "Trap")
        {
            myAnim.SetTrigger("Die");
            alive = false;
        }
    }
}
