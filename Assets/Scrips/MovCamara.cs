using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera camara;

    private void OnTriggerEnter2D(Collider2D obj)

    {
        if (obj.gameObject.tag == "portal1")
        {
            Vector3 posicioncamara = new Vector3(20.53f, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(13.45f, 0, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal2")
        {
            Vector3 posicioncamara = new Vector3(0, -14, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(1.51f, -10.56f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal3")
        {
            Vector3 posicioncamara = new Vector3(0, 11.9f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-7.57f, 8.35f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal4")
        {
            Vector3 posicioncamara = new Vector3(-20, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-12.6f, -3.45f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal5")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(7.32f, -0.49f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal6")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(1.47f, -3.42f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal7")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-7.46f, 3.5f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal8")
        {
            Vector3 posicioncamara = new Vector3(0, 0, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-7.38f, -3.52f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal9")
        {
            Vector3 posicioncamara = new Vector3(-20.22f, 11.87f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-15.5f, 13.53f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal10")
        {
            Vector3 posicioncamara = new Vector3(20.22f, 12.1f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(13.79f, 12.36f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal11")
        {
            Vector3 posicioncamara = new Vector3(0, 11.9f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-7.42f, 13.52f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal12")
        {
            Vector3 posicioncamara = new Vector3(0, 11.9f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(7.5f, 12.44f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal13")
        {
            Vector3 posicioncamara = new Vector3(-19.9f, -14, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-11.82f, -12.53f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal14")
        {
            Vector3 posicioncamara = new Vector3(0, -14, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(-7.1f, -13.49f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal15")
        {
            Vector3 posicioncamara = new Vector3(20.5f, -13.73f, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(13.79f, -14.85f, 0);
            this.transform.position = posicionPlayer;
        }

        if (obj.gameObject.tag == "portal16")
        {
            Vector3 posicioncamara = new Vector3(0, -14, -10);
            camara.transform.position = posicioncamara;
            Vector3 posicionPlayer = new Vector3(6.99f, -13.49f, 0);
            this.transform.position = posicionPlayer;
        }
    }

}