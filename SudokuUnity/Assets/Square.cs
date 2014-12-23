using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Square: MonoBehaviour {

	private int _currentNumber; 
	private int noInt = 0, minInt = 1, maxInt = 9;

	private int[] noteNumbers;

	#region properties
	public int currentNumber{
		get{return _currentNumber;}
		set{
			if(value >= minInt && value <= maxInt)
				_currentNumber = value;
			else if(value == noInt) //could be used for handling visibility. Call event in manager
				_currentNumber = value;
			else
				Debug.Log ("AvailableValues: Couldn't set value");
		}
	}
	#endregion

	void Start(){
		currentNumber = 0;
	}

	private int ViableValue(int value){
		if(value >= minInt && value <= maxInt)
			return value;
		else{
			return noInt;
			Debug.Log ("ViableValue: Couldn't set value, sets to noInt-value instead");
		}
	}
}



public class SudokuVector {
	private int _x = 0;
	private int _y = 0;

	public int x{
		get{return _x;}
		set{_x = value;}
	}

	public int y{
		get{return _y;}
		set{_y = value;}
	}

	public SudokuVector(int myX, int myY){

	}
}

public class AvailableValues{ //Old reprecated class
	//1-9 in most games and not shown
	private int _number;
	private Square _LinkedSquare;

	#region properties
	public int number{
		get{return _number;}
		set{
			if(value >= 1 && value <= 9)
				_number = value;
			else if(value == 0) //could be used for handling visibility
				_number = value;
			else
				Debug.Log ("AvailableValues: Couldn't set value");
		}
	}
	#endregion

	public AvailableValues(int myNumber, Square mySquare){
		number = myNumber;
		_LinkedSquare = mySquare;
	}
}
