# 2

There are two types of residents in a medieval castle: guardians and civilians, with defenders additionally divided into crossbowmen and pikemen. 
Please write a program that will contain the following elements:
- Each resident should provide the int Eat( ) method, which will return the number of food units needed for a given person. This method should work identically for all residents.
- Each guardian should provide the string ReadyToFight( ) method, which will return a string informing about the guardian's readiness to fight. This string should be different for crossbowmen and pikemen, while civilians should not have this method at all.
- Each of the classes created should have its own version of the string ToString( ) method, informing about the resident's belonging to the group of civilians/guardians/crossbowmen/pikemen.
- In the Main function, you should create several objects from each class and place them in the appropriate lists for the castle manager: a list of all crossbowmen, a list of all guardians, a list of all residents.
- For the lists storing all crossbowmen and all guardians, you should then call the ReadyToFight method and display the results, 
for the list storing all residents, you should call the ToString, Eat methods and display the results.
