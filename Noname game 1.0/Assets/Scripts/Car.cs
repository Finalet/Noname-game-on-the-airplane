using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{

    public int speedMasha;
    public int speedGrant;

    public GameObject grantCar;
    public Text scoreText;
    public Transform respawnPos;

    int GrantScore;
    int MashaScore;

    public float force;

    public GameObject toungeMasha;
    public GameObject tounge2;

    void Update()
    {

        scoreText.text = "Grant : Maria\n" + GrantScore + " : " + MashaScore;
        /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            float deltaTouch = Input.GetTouch(0).deltaPosition.x;
            Debug.Log(deltaTouch);

            multiplier = Screen.width / 1000;

            float x = transform.localPosition.x + deltaTouch * multiplier;
            transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
        } */

        //particleSystem.transform.localRotation = transform.rotation;


        if (Input.GetKey(KeyCode.D) && transform.position.y >= -2)
            transform.Rotate(Vector3.up * 7);
        else if (Input.GetKey(KeyCode.A) && transform.position.y >= -2)
            transform.Rotate(-Vector3.up * 7);

        if (Input.GetKey(KeyCode.W) && transform.position.y >= -2)
            transform.Translate(Vector3.forward * speedMasha * Time.deltaTime);
            //GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speedMasha * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S) && transform.position.y >= -2)
            transform.Translate(-Vector3.forward * speedMasha * Time.deltaTime);
            //GetComponent<Rigidbody>().AddRelativeForce(-Vector3.forward * speedMasha * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow) && grantCar.transform.position.y >= -2)
            grantCar.transform.Rotate(Vector3.up * 7);
        else if (Input.GetKey(KeyCode.LeftArrow) && grantCar.transform.position.y >= -2)
            grantCar.transform.Rotate(-Vector3.up * 7);

        if (Input.GetKey(KeyCode.UpArrow) && grantCar.transform.position.y >= -2)
            grantCar.transform.Translate(Vector3.forward * speedGrant * Time.deltaTime);
            //grantCar.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speedGrant * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow) && grantCar.transform.position.y >= -2)
            grantCar.transform.Translate(-Vector3.forward * speedGrant * Time.deltaTime);
            //grantCar.GetComponent<Rigidbody>().AddRelativeForce(-Vector3.forward * speedGrant * Time.deltaTime);


        if (transform.position.y <= -5) {
            transform.position = respawnPos.position;
            transform.rotation = respawnPos.rotation;
            GrantScore++;
        }
        if (grantCar.transform.position.y <= -5)
        {
            grantCar.transform.position = respawnPos.position;
            grantCar.transform.rotation = respawnPos.rotation;
            MashaScore++;
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y >= -2)
            GetComponent<Animation>().Play();

        if (Input.GetKeyDown(KeyCode.RightShift) && grantCar.transform.position.y >= -2)
            grantCar.GetComponent<Animation>().Play();

        //Physics.IgnoreCollision(GetComponent<Collider>(), toungeMasha.GetComponent<Collider>(), true);

    }


}