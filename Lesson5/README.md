# 5 Factory Methods and Abstract Factories

The interior design program offers three different styles: classic, modern and Scandinavian. Each of them requires (among other things) an appropriate model of a wardrobe and a desk, and when offering a given model to a customer, price restrictions should also be taken into account. Please write a program containing the following elements:
- An abstract class Wardrobe, which stores information about its price as an integer and has at least one other feature (e.g. color). Wardrobes should be divided into at least four different types, which should be classes inheriting from Wardrobe and should differ from each other in some way (e.g. additional features or the operation of the constructor).
- An abstract class Desk and classes inheriting from it - the same.
- An abstract class InteriorDecorator and three classes inheriting from it corresponding to specific styles of home furnishings. InteriorDecorator should contain two abstract methods: ProduceWardrobe(int pricelimit) and ProduceDesk(int pricelimit). These methods should return the appropriate desk or wardrobe model to the client, taking into account the interior style and the proposed price limit. The desk and wardrobe styles produced by a given class should match each other in some way (in what way exactly – you can decide for yourself).
- In the Main function, please create an instance of each of the written factories and demonstrate the production of desks and wardrobes for several price levels of your choice.


# Result

In a scandinavian style we offer: 
- wardrobe
Price: 2500. Color: white
- desk
Price: 2000. Color: white


In a modern style we offer:
- wardrobe
Price: 3500. Color: black
- desk
Price: 3000. Color: black


In a classic style we offer:
- wardrobe
Price: 1500. Color: oak
- desk
Price limit too low for Classic Desk.