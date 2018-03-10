﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickNorInputAScript : MonoBehaviour {

public TextMesh inputA_current, inputA_next;
private bool bInput_current = true, bInput_next = false;
public static int iInput_current, iInput_next;

public AudioSource click_sound;

void Start()
{
	convertToNum();
	inputA_current.text = iInput_current.ToString();
	inputA_next.text = iInput_next.ToString();
}

void OnMouseDown()
{


	bInput_current = !bInput_current;
	bInput_next = !bInput_next;

	convertToNum();
	inputA_current.text = iInput_current.ToString();
	inputA_next.text = iInput_next.ToString();

	click_sound.Play();

}

void convertToNum()
{
	if (bInput_current == true)
	{
		iInput_current = 1;
	}
	else
	{
		iInput_current = 0;
	}

	if (bInput_next == true)
	{
		iInput_next = 1;
	}

	else
	{
		iInput_next = 0;
	}

	}

}