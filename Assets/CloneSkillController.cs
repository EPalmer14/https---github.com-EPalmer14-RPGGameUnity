using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneSkillController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator anim;
    [SerializeField] private float colorLosingSpeed;
    private float cloneTimer;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        cloneTimer -= Time.deltaTime;

        if (cloneTimer < 0)
        {
            sr.color = new Color(1, 1, 1, sr.color.a - (Time.deltaTime * colorLosingSpeed));
        }
    }

    public void SetupClone(Transform _newTransform, float _cloneDuration, bool _canAttack)
    {
        if (_canAttack)
        {
            anim.SetInteger("AttackNumber", Random.Range(1, 3));
        }
        transform.position = _newTransform.position;
        cloneTimer = _cloneDuration;
    }
}
