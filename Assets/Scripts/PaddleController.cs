using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //Mendeklarasikan variabel input dan springPower
	public KeyCode input;
	public float targetPressed;
    public float targetRelease;

    //Mengambil komponen hinge joint dari game object
	private HingeJoint hinge;

    private void Start()
    {

        //Mengambil komponen hinge joint dari game object
        hinge = GetComponent<HingeJoint>();

        //Mengatur batas maksimal dan minimal dari hinge joint
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

	private void Update()
    {
        ReadInput();
    }



    private void ReadInput()
    {
        //Mengambil spring dari komponen hinge joint
        JointSpring jointSpring = hinge.spring;


        //Mengubah value spring saat input ditekan atau tidak
        if (Input.GetKey(input))
        {
            //Mengubah spring ke springPower saat input ditekan
            jointSpring.targetPosition = targetPressed;
        }
        else
        {   
            //Mengembalikan spring ke 0 saat input tidak ditekan
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
    }