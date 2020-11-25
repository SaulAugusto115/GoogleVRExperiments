using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTest : MonoBehaviour
{
    public Material mNormal;
    public Material mGreen;
    public Material mRed;

    public Vector3 sizeBig = new Vector3(1.5f, 1.5f, 1.5f);
    public Vector3 sizeMedium = new Vector3(1f, 1f, 1f);
    public Vector3 sizeSmall = new Vector3(0.4f, 0.4f, 0.4f);

    MeshRenderer mr;


    // Start is called before the first frame update
    void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pointer_Enter()
    {
        mr.material = mNormal;
        transform.localScale = sizeBig;
    }


    public void Pointer_Exit()
    {
        mr.material = mGreen;
        transform.localScale = sizeMedium;
    }

    public void Pointer_Click()
    {
        mr.material = mRed;
        transform.localScale = sizeSmall;
    }
}
