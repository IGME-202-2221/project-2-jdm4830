using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PhysicsObject : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;
    private Vector3 acceleration;
    private Vector3 direction = Vector3.zero;

    public float mass = 1f; 

    public bool bounceOffWalls = false;

    public bool useGravity = false;

    public bool useFriction = false;

    public float frictionCoeff = 0.2f;

    //private Vector3 cameraSize;

    //public Vector3 CameraSize => cameraSize;

    //public Vector3 Velocity => velocity;
    //Same thing above as below, just single line. ONLY for Get property
    
    public Vector3 Velocity
    {
        get { return velocity; }
        set { velocity = value; }
    }
    
    public Vector3 Direction
    {
        get { return direction; }
    }

    //public Vector3 position = Vector3.zero;
    public Vector3 Position => transform.position;

    public Vector3 Right => transform.right;

    public float radius = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //cameraSize.y = Camera.main.orthographicSize;
        //cameraSize.x = cameraSize.y * Camera.main.aspect;

        direction = Random.insideUnitCircle.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (useGravity)
        {
            ApplyGravity(Physics.gravity);
        }

        if (useFriction)
        {
            ApplyFriction(frictionCoeff);
        }

        //Calculate a new velocity, base on the current acceleration of this object
        velocity+= acceleration * Time.deltaTime;

        //Calculate the new position based on the velocity for this frame
        transform.position += velocity * Time.deltaTime;

        if(velocity.sqrMagnitude > Mathf.Epsilon)
        {
            //Store the direction that the object is moving in
            direction = velocity.normalized;
        }

        //Zero out the acceleration for the next frame
        acceleration = Vector3.zero;

        transform.rotation = Quaternion.LookRotation(Vector3.back, direction);

        if(bounceOffWalls)
        {
            BounceOffWalls();
        }

    }

    ///
    ///Applies a force to this object following Newton's second law of motion
    ///
    public void ApplyForce(Vector3 force)
    {
        acceleration += force / mass;
    }


    ///
    ///Applies a friction force to this object
    ///
    private void ApplyFriction(float coeff)
    {
        Vector3 friction = velocity * -1;
        friction.Normalize();
        friction = friction * coeff;

        ApplyForce(friction);
    }

    ///
    ///Applies a gravitational force that acts on this object
    ///
    private void ApplyGravity(Vector3 gravityForce)
    {
        acceleration += gravityForce;
    }

    private void BounceOffWalls()
    {
        //If we are off screen, and we're still moving off screen, change the direction we're moving in
        if (transform.position.x > AgentManager.Instance.maxPosition.x && velocity.x > 0)
        {
            velocity.x *= -1f;
        }
        if (transform.position.x < AgentManager.Instance.minPosition.x && velocity.x < 0)
        {
            velocity.x *= -1f;
        }
        if (transform.position.y > AgentManager.Instance.maxPosition.y && velocity.y > 0)
        {
            velocity.y *= -1f;
        }
        if (transform.position.y < AgentManager.Instance.minPosition.y && velocity.y < 0)
        {
            velocity.y *= -1f;
        }
    }
}
