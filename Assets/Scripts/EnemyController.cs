using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;

    Animator animator;

    public float dietimer = 1.0f;

    bool dead = false;

    public GameObject itemToDrop;
    // bool created = false;

    AudioSource audioSource;
    public AudioClip death;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        } 


    }

    void FixedUpdate()
    {
        if (!dead)
        {
            Vector2 position = rigidbody2D.position;
            if (vertical)
            {
                position.y = position.y + Time.deltaTime * speed * direction;
                animator.SetFloat("Move X", 0);
                animator.SetFloat("Move Y", direction);
            }
            else
            {
                position.x = position.x + Time.deltaTime * speed * direction;
                animator.SetFloat("Move X", direction);
                animator.SetFloat("Move Y", 0);
            }

            rigidbody2D.MovePosition(position);
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        HeroController player = other.gameObject.GetComponent<HeroController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void Die()
    {
        dead = true;
        animator.SetTrigger("Dead");
        audioSource.Play();
        GameObject tempItemSpawn = Instantiate(itemToDrop, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        Vector2 newPos = rigidbody2D.position;
        tempItemSpawn.transform.position = rigidbody2D.position;
        Destroy(gameObject, dietimer);
    }

}
