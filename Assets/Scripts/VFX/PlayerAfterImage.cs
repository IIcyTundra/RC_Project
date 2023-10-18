using Kitbashery.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAfterImage : MonoBehaviour
{
    [SerializeField] private float m_activeTime = 0.1f;
    [SerializeField] private float m_alphaSet = 0.8f;

    private float m_timeActivated;
    private float m_alpha;
    private float m_alphaMultiplier = 0.85f;

    private Transform m_player;
    private SpriteRenderer m_SR;
    private SpriteRenderer m_playerSR;

    private Color m_color;

    private void OnEnable()
    {
        m_SR = GetComponent<SpriteRenderer>();
        m_player = GameObject.FindGameObjectWithTag("Player").transform;
        m_playerSR = m_player.GetComponent<SpriteRenderer>();

        m_alpha = m_alphaSet;
        m_SR.sprite = m_playerSR.sprite;
        transform.position = m_player.transform.position;
        transform.rotation = m_player.transform.rotation;
        m_timeActivated = Time.time;
    }

    private void Update()
    {
        m_alpha *= m_alphaMultiplier;
        m_color = new Color(1f, 1f, 1f, m_alpha);
        m_SR.color = m_color;

        if(Time.time >= (m_timeActivated -+ m_activeTime))
        {
            ObjectPools.Instance.ActivatePooledObject(0);
        }

    }
}
