using UnityEngine;
using System.Collections;

public class IngredientsPlaceTime : MonoBehaviour {

	//define ingredients to make
	public Transform chef; 
	public Transform meat; 
	public Transform tomato; 
	public Transform mushroom; 
	
	//define some variables to fascilitate process
	int rangeFinder;
	float distFinder; 
	float nextPlantingTime = 0f;


	void Start () {

		
		//define some values
		nextPlantingTime = Time.time + 5f; // after chef lays ingredient, move time later
		distFinder = Random.Range (5f, 10f); // distance to next planting opportunity
	}


	void Update () {

		int i = 0;
		while ( i<1 )  {
			
			//time to place ingredients
			if (Time.time > nextPlantingTime ) {

				rangeFinder = Random.Range (0, 100); // % chance of picking an ingredient
				
				if (rangeFinder > 80 ) { 
					Instantiate ( meat, transform.position, Quaternion.identity );
				} 
				
				else if (rangeFinder > 50 && rangeFinder < 80 ) { 
					Instantiate ( mushroom, transform.position, Quaternion.identity );
				} 
				
				else if (rangeFinder > 10 && rangeFinder < 50 ) { 
					Instantiate ( tomato, transform.position, Quaternion.identity );
				} 
				
				else { //chance of dropping a new chef
					Instantiate ( chef, transform.position - transform.forward, Quaternion.identity );
				}
				
				nextPlantingTime += distFinder; 
				
			}
			
			
			i++;
			
		}
		
	}
}