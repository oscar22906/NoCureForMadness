using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnimation : MonoBehaviour
{

    public float amplitude = 0.5f;
    public float frequency = 1f;
    public GameObject lightSpawn;
    Vector3 posOrigin = new Vector3();
    Vector3 spawn = new Vector3();
    Vector3 tempPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(lightSpawn, transform);
        posOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = posOrigin;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}
