using UnityEngine;
using System.Collections;

public class HelloTaco : MonoBehaviour {
	
	void Start () {
		Ingredient lettuce = new Ingredient ("lettuce", Color.green, 1.0, 0.10);
        Ingredient ketchup = new Ingredient ("ketchup", new Color (204, 0, 153) , 15.0, 0.20);

		Burrito myBurrito = new Burrito ("John");
        Burrito weirdBurrito = new Burrito("Crazy Vegan");

        for (int i = 0; i < 10; i++){
            myBurrito.AddIngredient(Ingredient.GetRandomIngredient());
        }
        weirdBurrito.AddIngredient(lettuce);
        weirdBurrito.AddIngredient(ketchup);


		print (myBurrito.GetIngredientString ());
        print (weirdBurrito.GetIngredientString ());
        print("Your crazy burrito will cost: " + weirdBurrito.GetCost() + " Doll Hairs");
    }
}
