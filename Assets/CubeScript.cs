using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {


    Vector3 vec;
    GameObject game;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))
        {
            Instantiate(game, transform.position, transform.localRotation);
            Debug.Log("Left licked");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right licked");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            vec = transform.localPosition;
            vec.y += 4;
            transform.localPosition = vec;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vec = transform.localPosition;
            vec.z -= 4;
            transform.localPosition = vec;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vec = transform.localPosition;
            vec.z += 4;
            transform.localPosition = vec;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            vec = transform.localPosition;
            vec.x -= 100 * Time.deltaTime;
            transform.localPosition = vec;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            vec = transform.localPosition;
            vec.x += 100 * Time.deltaTime;
            transform.localPosition = vec;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x, y, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("when is trigger check that time call OnTriggerEnter");
    }
}
