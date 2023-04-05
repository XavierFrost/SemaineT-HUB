using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationNPC : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter(Collider other)
    {
        _animator.Play("Stop");
    }
}
