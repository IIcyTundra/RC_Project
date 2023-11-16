using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [RequireComponent(typeof(CharacterController))]
    public class PaperCharacterController : MonoBehaviour
    {
        [Header("Movement controller")]
        public float speed = 5.0f;
        public float antiBump = 4.5f;
        public float gravity = 30.0f;

        [Header("Graphics references")]
        public GameObject shadowObj;
        public Animator flipAnim;

        private Vector3 moveDirection;
        private Vector3 input;
        private CharacterController controller;


        /**/


        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }


        #region Move

        private void Update()
        {
            if (controller.isGrounded)
            {
                input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                if (input.x != 0 && input.y != 0) input *= 0.777f;

                moveDirection = new Vector3(input.x * speed, -antiBump, input.y * speed);
                moveDirection = transform.TransformDirection(moveDirection);

                if (Input.GetKey("space")) moveDirection = new Vector3(moveDirection.x, 10f, moveDirection.z);
                shadowObj.SetActive(true);
            }
            else
            {
                moveDirection.y -= gravity * Time.deltaTime;
                shadowObj.SetActive(false);
            }

            if (input.x > 0) flipAnim.Play("FlipRight");
            else if (input.x < 0) flipAnim.Play("FlipLeft");
        }


        private void FixedUpdate()
        {
            controller.Move(moveDirection * Time.deltaTime);
        }

        #endregion
    }
}