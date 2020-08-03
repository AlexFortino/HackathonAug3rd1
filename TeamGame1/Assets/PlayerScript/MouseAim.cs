using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    public Transform objectToMove;
    Vector3 mouse;
    Ray castPoint;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        castPoint = Camera.main.ScreenPointToRay(mouse);
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
           
            objectToMove.transform.position = new Vector3(hit.point.x, 43 ,hit.point.z);
        }
    }
}
