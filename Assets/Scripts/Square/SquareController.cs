using UnityEngine;
using Random = UnityEngine.Random;

namespace Square
{
    public class SquareController : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        [SerializeField] 
        private float _rotationPower;

        [SerializeField]
        private float _speed;

        private Vector2 _direction;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _rotationPower *= GetRandomSign();
        }

        private void FixedUpdate()
        {
            _rigidbody2D.rotation += _rotationPower;
            _rigidbody2D.velocity = _direction * _speed;
        }

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }

        private int GetRandomSign()
        {
            var randomNumber = Random.Range(0, 2);
            return randomNumber == 1 ? 1 : -1;
        }
    }
}