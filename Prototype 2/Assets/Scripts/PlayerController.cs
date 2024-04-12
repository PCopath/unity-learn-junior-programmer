using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizantalInput;
    public float speed = 10.0f;
    public float xrange = 10.0f;
    public GameObject projectileProfab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }


        horizantalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizantalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileProfab, transform.position, projectileProfab.transform.rotation);
        }
    }
}
