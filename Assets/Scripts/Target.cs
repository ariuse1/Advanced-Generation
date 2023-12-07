using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Path _path;
    [SerializeField] private float _speed = 2;    

    private int _currentPoint;    
    private Point[] _points;    

    private void Start()
    {
        _points = _path.Points;  
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Transform target = _points[_currentPoint].transform;
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _currentPoint++;          

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }            
        }
    }   
}
