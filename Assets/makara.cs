using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makara : MonoBehaviour
{

    public LineRenderer ip;
    public Transform kanca;





    void Start()
    {
        
    }

    
    void Update()
    {


        ip.SetPosition(0, transform.position);
        ip.SetPosition(1, kanca.position);




    }
}
