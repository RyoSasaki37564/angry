using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Vector2> m_arrows = null;
    private float m_angle;

    private Vector2 m_dragPoint = Vector2.zero; // ドラッグ開始点
    private Vector2 m_pullPoint = Vector2.zero;



    void Start()
    {
        TouchManager.Began += (info) =>
        {
            m_dragPoint = info.screenPoint;
            m_pullPoint = info.screenPoint;
        };
        TouchManager.Moved += (info) =>
        {
            m_pullPoint = info.screenPoint;
        };
        TouchManager.Ended += (info) =>
        {

        };

    }


    void Update()
    {
        
    }
}
