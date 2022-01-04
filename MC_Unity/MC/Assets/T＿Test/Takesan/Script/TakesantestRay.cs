using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakesantestRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TakesantestInput.Touchbegan == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(TakesantestInput.Touchposition,Vector2.zero);
            if (hit == true)
            {
                //hit.collider.GetComponent<TargetC#>().Method();
            }
        }
    }
}
