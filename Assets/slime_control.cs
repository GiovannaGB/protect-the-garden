using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_control : MonoBehaviour
{
    // Start is called before the first frame update
   GameObject flowerbed;
   private Rigidbody rb; 
   public float speed =8;
   public float suckpower = 500;
   bool goToVacuum = false;
   Transform suckTarget;
    void Start()
    {
      flowerbed = GameObject.FindWithTag("flower_bed");
      rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
      if (flowerbed != null && flowerbed.activeSelf)
      {transform.LookAt (flowerbed.transform);
    }
    }

    void FixedUpdate()
    {
      if (!goToVacuum)
      {
        if (flowerbed != null && flowerbed.activeSelf)  
        {rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * speed);
        }
      } else {
        Vector3 suckDir = suckTarget.position - transform.position;
        suckDir = suckDir.normalized;
        rb.AddForce(suckDir * suckpower * Time.fixedDeltaTime);
        if (Vector3.Distance(suckTarget.position, transform.position) < 0.8f)
        {
          Debug.Log("Slime Sucked!");
          Destroy(gameObject);
        }
      }
    }

    // SlimesGettingSucked(transform)
    // Slime is getting sucked
    public void SlimesGettingSucked(Transform suckTarget)
    {
      this.suckTarget = suckTarget;
      goToVacuum = true;
    }




}

