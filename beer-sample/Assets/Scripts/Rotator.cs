using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int rotV = 80;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0, rotYv, 0) * Time.deltaTime);    // mistery ported from Blender! rotates around x
        // transform.Rotate(new Vector3(rotYv, 0, 0) * Time.deltaTime);    // rotates arround Z !?

        //transform.Rotate(new Vector3(0, 0, rotV) * Time.deltaTime);    // rotates arround Y
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotV);
    }
}
