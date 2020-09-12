using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody _rigidbody;
    private TapDetector _tapDetector;
    private Vector3 _direction = Vector3.zero;
    private Vector3 _startedPostion;
    private bool _isMove = false;

    private void Awake()
    {
        _tapDetector = FindObjectOfType<TapDetector>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _tapDetector.TapDetected += OnTapDetected;
    }

    private void OnDisable()
    {
        _tapDetector.TapDetected -= OnTapDetected;
    }

    private void Update()
    {
        if (_isMove)
        {
            Vector3 target = _startedPostion + _direction;
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
            if(transform.position == target)
            {
                _isMove = false;
            }
        }
    }

    private void OnTapDetected(Vector3 direction)
    {
        if(_isMove == false)
        {
            _isMove = true;
            _direction = direction;  
            _startedPostion = transform.position;
            _rigidbody.AddForce(Vector3.up * _speed * 25 * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
