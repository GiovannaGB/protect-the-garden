using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower_health : MonoBehaviour
{
    public float health = 100;
    public float damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("bad_boi"))
       {
            health -=damage * Time.deltaTime;
          if (health <= 0)
          {
            gameObject.SetActive(false);
          }
       }
    }
}
