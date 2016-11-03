?using UnityEngine;
using System.Collections;
using System.IO.Ports;


public class InputBehaviour : MonoBehaviour {
    
	private bool portSet; 
	private SerialPort serialP = new SerialPort("COM7" , 9600);
        
	void Awake()
	{
		serialP.Open();
		serialP.ReadTimeout = 1;
		
		if (!serialP.IsOpen) { serialP.Open(); }
        
        if (serialP.IsOpen) {
            try {
                string _Input = serialP.ReadLine().ToString();
                Arduino(_Input);
                print(_Input);
            } catch(System.Exception) {}
        } else {

        }
		
	}
	
	private void Arduino(string _Input) {
        switch (_Input)
        {
            case "forward":
                forward = true;
                break;
            case "rightRo":
                rightRo = true;
                break;
            case "leftRo":
                leftRo = true;
                break;
            case "right":
                right = true;
                break;
            case "left":
                left = true;
                break;
            case "jump":
                jump = true;
                break;
            case "escapeButton":
                escapeButton = true;
                break;
            case "down":
                down = true;
                break;
        }
    }
	
    void Update()
    {
        int Y;
        int X;
        string value = serialP.ReadLine(); //Read the information
        string[] vec3 = value.Split(',');
        X = int.Parse(vec3[0]);
        Y = int.Parse(vec3[1]);

        
    }
}
