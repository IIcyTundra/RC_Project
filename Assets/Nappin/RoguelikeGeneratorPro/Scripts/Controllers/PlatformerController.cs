using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [RequireComponent(typeof(CharacterController))]
    public class PlatformerController : MonoBehaviour
    {
        [Header("Movement controller")]
        public float speed = 5.0f;
        public float antiBump = 4.5f;
        public float gravity = 30.0f;

        [Header("Graphics references")]
        public GameObject characterSprite;

        private CharacterController controller;
        private Vector3 moveDirection;
        private Vector3 input;
        private Vector3 faceRight;
        private Vector3 faceLeft;


        /**/


        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            faceRight = new Vector3(characterSprite.transform.localScale.x, characterSprite.transform.localScale.y, characterSprite.transform.localScale.z);
            faceLeft = new Vector3(-characterSprite.transform.localScale.x, characterSprite.transform.localScale.y, characterSprite.transform.localScale.z);
        }


        #region Move

        private void Update()
        {
            if (controller.isGrounded)
            {
                input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
                if (input.x != 0 && input.y != 0) input *= 0.777f;

                moveDirection = new Vector3(input.x * speed, -antiBump, input.y * speed);
                moveDirection = transform.TransformDirection(moveDirection);

                if (Input.GetKey("space")) moveDirection = new Vector3(moveDirection.x, 10f, moveDirection.z);
            }
            else moveDirection.y -= gravity * Time.deltaTime;

            if (input.x > 0) characterSprite.transform.localScale = faceRight;
            else if (input.x < 0) characterSprite.transform.localScale = faceLeft;
        }


        private void FixedUpdate()
        {
            controller.Move(moveDirection * Time.deltaTime);
        }

        #endregion
    }
}