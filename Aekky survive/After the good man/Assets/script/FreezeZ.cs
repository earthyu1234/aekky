using UnityEngine;
using System.Collections;


public class FreezeZ : MonoBehaviour
{
    public bool FreezeX = false;
    public bool FreezeY = false;
    public bool Freezez = false;
    private Vector3 m_OriginPos;
    void Start()
    {
        m_OriginPos = transform.position;
    }


    void Update()
    {
        Vector3 currentPos = transform.position;
        if (FreezeX)
            currentPos.x = m_OriginPos.x;
        if (FreezeY)
            currentPos.y = m_OriginPos.y;
        if (Freezez)
            currentPos.z = m_OriginPos.z;
        transform.position = currentPos;
    }

}