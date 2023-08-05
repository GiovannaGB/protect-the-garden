using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_nd_wreck : MonoBehaviour
{
    public Transform suckTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("bad_boi"))
       {
            Debug.Log("Encountered Slime! Gonna suck");
          try {
            other.gameObject.GetComponent<slime_control>().SlimesGettingSucked(suckTarget);
          } catch {
            Debug.Log("This object has no slime_control!");
          }
       }
    }

}
