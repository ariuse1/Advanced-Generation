using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    private Target _target;
  
    private void Update()
    {
        Move();
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        Transform target = _target.transform;

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);        
    }
}
