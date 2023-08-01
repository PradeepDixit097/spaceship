using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    // Start is called before the first frame update
public GameObject spaceship;
public float value;
public Vector3 sizeChange;

public void MoveLeft(){
    value=value-0.1f;
    spaceship.transform.position=new Vector3(value,0,0);
}

public void RotateLeft(){
    spaceship.transform.Rotate(0f,0f,5f);
}

public void Grow(){
    spaceship.transform.localScale=spaceship.transform.localScale+ new Vector3(0.1f,0.1f,-0.1f);
}

public void MoveRight(){
    value=value+0.1f;
    spaceship.transform.position=new Vector3(value,0,0);
}

public void RotateRight(){
    spaceship.transform.Rotate(5f,5f,0f);
}

public void Shrink(){
    spaceship.transform.localScale=spaceship.transform.localScale- new Vector3(0.1f,0.1f,-0.1f);
}

public void ResetHuman(){
    value=0;
    spaceship.transform.position=new Vector3(0,0,0);
    spaceship.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
    spaceship.transform.localScale=new Vector3(1,1,1);
}
}
