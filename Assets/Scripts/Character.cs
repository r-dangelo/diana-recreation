﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float _health = 375;
    [SerializeField] float _shieldHealth = 0;

    public void SetHealth(float amount)
    {
        _health = amount;
    }

    public void ChangeHealthByAmount(float amount)
    {
        _health += amount;
    }

    public float GetHealth()
    {
        return _health;
    }

    public void SetShieldHealth(float amount)
    {
        _shieldHealth = amount;
    }

    public void ChangeShieldHealthByAmount(float amount)
    {
        _shieldHealth += amount;
    }

    public float GetShieldHealth()
    {
        return _shieldHealth;
    }

    public void DealDamage(float amount, GameObject thingTakingDamage)
    {
        thingTakingDamage.GetComponent<Character>().ChangeHealthByAmount(-amount);
    }
}