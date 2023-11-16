using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class TopDownController : MonoBehaviour
    {
        [Header("Movement specifics")]
        public float runSpeed = 5f;

        [Header("Graphics references")]
        public GameObject dustPrt;
        public Animator penguinAnim;

        private Rigidbody2D body;
        private Vector2 input;
        private float moveLimiter = 0.7f;

        private Vector3 facingRight = new Vector3(1, 1, 1);
        private Vector3 facingLeft = new Vector3(-1, 1, 1);


        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }


        #region Move

        void Update()
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            if (input.x > 0) this.transform.localScale = facingRight;
            else if (input.x < 0) this.transform.localScale = facingLeft;

            if (input.x != 0 || input.y != 0)
            {
                penguinAnim.Play("Walk");
                dustPrt.SetActive(true);
            }
            else
            {
                penguinAnim.Play("Idle");
                dustPrt.SetActive(false);
            }
        }


        void FixedUpdate()
        {
            if (input.x != 0 && input.y != 0)
            {
                input.x *= moveLimiter;
                input.y *= moveLimiter;
            }

            body.velocity = new Vector2(input.x * runSpeed, input.y * runSpeed);
        }

        #endregion
    }
}