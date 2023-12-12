using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Bird _tamplate;
    [SerializeField] private Target _target;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Bird bird = Instantiate(_tamplate, transform.position, Quaternion.identity);
        bird.SetTarget(_target);
    }
}
