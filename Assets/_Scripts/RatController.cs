using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatController : MonoBehaviour
{
    Animator animator;

    public float hp = 3;

    public static RatController instance;

    

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int strength)
    {
        hp -= strength;
        Debug.Log("Gottem");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Bullet")
        {
            RatController.instance.TakeDamage(1);
            //Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            animator.SetTrigger("dead");
        }
    }
}
