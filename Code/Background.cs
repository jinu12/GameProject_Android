using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Background : MonoBehaviour
{
    [SerializeField] Transform[] m_t1Backgrounds = null;
    [SerializeField] float m_speed = 0f;

    float m_leftPosX = 0f;
    float m_rightPosX = 0f;
    void Start()
    {
        float t_length=m_t1Backgrounds[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        m_leftPosX = t_length;
        m_rightPosX = t_length * m_t1Backgrounds.Length;
    }
    void Update()
    {
        for(int i=0;i<m_t1Backgrounds.Length;i++)
        {
            m_t1Backgrounds[i].position += new Vector3(m_speed, 0, 0) * Time.deltaTime;
            if (m_t1Backgrounds[i].position.x < m_rightPosX) {
                Vector3 t_selfPos = m_t1Backgrounds[i].position;
                t_selfPos.Set(t_selfPos.x + m_rightPosX, t_selfPos.y, t_selfPos.z);
                m_t1Backgrounds[i].position = t_selfPos;
                    }
        }
    }
}
