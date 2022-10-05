using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public int potionstrength = 10;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
           PlayerController.instance.ChangeJump(potionstrength);
           Destroy(gameObject);

        }
    }
}
