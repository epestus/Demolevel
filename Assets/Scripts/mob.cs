using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public float speed;
    public float range;
    public CharacterController controller;
    public Transform player;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!inRange())
        {
        chase();
        }
        else
        {
            GetComponent<Animation> ().CrossFade("idle");
        }
    }

    bool inRange()
    {
        if(Vector3.Distance(transform.position, player.position)<range)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void chase()
    {
        transform.LookAt(player.position);
       ////GetComponent<Animation> ().CrossFade("run");
    }

     /// <summary>
    /// Called every frame while the mouse is over the GUIElement or Collider.
    /// </summary>
  
    
}
