using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabObject : MonoBehaviour
{
    public Transform grabDetect;
    public Transform grabItem;
    public float rayDist;

    private hasItem bool = false;

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Items")
        {
            if (Input.GetKey(KeyCode.E))

                if(hasItem)
                
                {
                    grabCheck.collider.gameObject.transform.parent = grabItem;
                    grabCheck.collider.gameObject.transform.position = grabItem.position;
                    grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                    hasItem = true;

                }
                
                else
                {
                    return null;
                }
            
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }

    }
}
