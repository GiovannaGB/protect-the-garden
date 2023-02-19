using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_control : MonoBehaviour
{
    // Start is called before the first frame update
   GameObject flowerbed;
   private Rigidbody rb; 
   public float speed =15;
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
      if (flowerbed != null && flowerbed.activeSelf)  
      {rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * speed);
      }
    }
}
