using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private int _vertical;
    private int _horizontal;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _vertical = Animator.StringToHash("Vertical");
        _horizontal = Animator.StringToHash("Horizontal");
    }

    private void Update()
    {
        _animator.SetFloat(_vertical, Input.GetAxis("Vertical"));
        _animator.SetFloat(_horizontal, Input.GetAxis("Horizontal"));
    }
}