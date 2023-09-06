using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kanca : MonoBehaviour
{
    public Rigidbody2D rigi;
    public Animator makara_anim;
    GameObject nesne;

    public yonetici yonet;


    bool nesne_var_mi = false;
    



    float hiz = 400.0f;
    float eski_hiz = 400.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Makara")
        {

            rigi.velocity = Vector2.zero;
            makara_anim.enabled = true;

            if (nesne_var_mi == true)
            {
                if (nesne.gameObject.tag == "altin")
                {
                    
                    Destroy(nesne);
                    nesne_var_mi = false;

                    yonet.para_arttir(100);
                }
                
                if (nesne.gameObject.tag == "elmas")
                {

                    Destroy(nesne);
                    nesne_var_mi = false;

                    yonet.para_arttir(250);
                }
                
                if (nesne.gameObject.tag == "tas")
                {

                    Destroy(nesne);
                    nesne_var_mi = false;

                    yonet.para_arttir(0);
                }
            }
        }

        if (collision.gameObject.tag == "altin" || collision.gameObject.tag == "elmas" || collision.gameObject.tag == "tas")
        {
            nesne = collision.gameObject;

            nesne.GetComponent<BoxCollider2D>().enabled = false;    
            nesne_var_mi = true;
            rigi.velocity = Vector2.zero;
            rigi.AddForce(transform.up * hiz);


            collision.gameObject.transform.parent = transform;
        }
    }


    public void firlat()
    {

        makara_anim.enabled = false;
        rigi.AddForce(-transform.up * hiz);
    }
    //kanca kameradan çýkýnca
    private void OnBecameInvisible()
    {


        rigi.velocity = Vector2.zero;
        rigi.AddForce(transform.up * hiz);

    }
}
