using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private player_control player;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<player_control>();
        
    }
     void OnCollisionStay2D(Collision2D colli)
    {
        if(colli.gameObject.tag == "Paltform")
        {
            player.grounded = true;
        }
       

    }
    void OnCollisionExit2D(Collision2D colli)
    {
        if (colli.gameObject.tag == "Paltform")
        {
            player.grounded = false;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
