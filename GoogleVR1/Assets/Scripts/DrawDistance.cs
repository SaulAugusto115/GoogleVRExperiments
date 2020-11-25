using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawDistance : MonoBehaviour
{
    [Header("Settings")]
    [Range(0f, 10f)] public float distance;
    public Color color;
    [Space]
    [TextArea] public string note;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(transform.position, distance);
    }
}
