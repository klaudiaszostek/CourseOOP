# 3

Programmer Marek has received another order to write a program simulating a sea voyage, this time for different types of submarines. He intends to approach the new project in a systematic manner and in accordance with the principles of software design…

You have existing files: the class diagram with comments, and the finished code for several program classes, including the main Program class and the classes responsible for testing. Please create the remaining classes in such a way as to obtain a working program consistent with the assumptions of the diagram. The unspecified cases can be supplemented at your own discretion.

Before starting the actual simulation, the program elements will be automatically tested by the TestSubmarine class. If the result of all tests is positive, you should uncomment the Submarine.Demo(); command in the Program class and the contents of the Submarine class.


# Result

Test 1 passed: class Human identified.
Test 2 passed: class Human inherits from ITransportable.

Test 3 passed: class Scientist identified.
Test 4 passed: class Scientist inherits from Human.
Test 5 passed: method Void Work(Double) of class Scientist identified correctly.
Test 6 passed: constructor of class Scientist identified correctly.
Test 7 passed: weight of Scientist updated correctly with volume.
Test 8 passed: volume of Scientist updated correctly with weight.

Test 9 passed: class Crewman identified.
Test 10 passed: class Crewman inherits from Human.
Test 11 passed: weight of Crewman updated correctly with volume.
Test 12 passed: volume of Crewman updated correctly with weight.

Test 13 passed: class Fuel identified.
Test 14 passed: class Fuel inherits from ITransportable.
Test 15 passed: property Type in class Fuel identified correctly.

Test 16 passed: class FuelNuclear identified.
Test 17 passed: class FuelNuclear inherits from Fuel.
Test 18 passed: weight of FuelNuclear updated correctly with volume.
Test 19 passed: volume of FuelNuclear updated correctly with weight.

Test 20 passed: class FuelDiesel identified.
Test 21 passed: class FuelDiesel inherits from Fuel.
Test 22 passed: weight of FuelDiesel updated correctly with volume.
Test 23 passed: volume of FuelDiesel updated correctly with weight.

Test 24 passed: class FuelTank identified.
Test 25 passed: class FuelTank inherits from IVisitPort.
Test 26 passed: property MaxCapacity in class FuelTank identified correctly.
Test 27 passed: constructor of class FuelTank identified correctly.
Test 28 passed: method String GetFuelType( ) of class FuelTank identified correctly.
Test 29 passed: weight of FuelTank updated correctly with volume.
Test 30 passed: volume of FuelTank updated correctly with weight.
Test 31 passed: volume of FuelTank set to MaxCapacity after visiting port.

Test 32 passed: class Waste identified.
Test 33 passed: class Waste inherits from IVisitPort.
Test 34 passed: weight of Waste updated correctly with volume.
Test 35 passed: volume of Waste updated correctly with weight.
Test 36 passed: volume of Waste set to zero after visiting port.

Test 37 passed: class OxygenBottle identified.
Test 38 passed: class OxygenBottle inherits from IVisitPort.
Test 39 passed: property MaxCapacity in class OxygenBottle identified correctly.
Test 40 passed: constructor of class OxygenBottle identified correctly.
Test 41 passed: MaxCapacity set in constructor of  OxygenBottle.
Test 42 passed: weight of OxygenBottle updated correctly with volume.
Test 43 passed: volume of OxygenBottle updated correctly with weight.
Test 44 passed: volume of OxygenBottle set to MaxCapacity after visiting port.

Test 45 passed: class FoodContainer identified.
Test 46 passed: class FoodContainer inherits from IVisitPort.
Test 47 passed: constructor of class FoodContainer identified correctly.
Test 48 passed: property MaxCapacity in class FoodContainer identified correctly.
Test 49 passed: MaxCapacity set in constructor of  FoodContainer.
Test 50 passed: weight of FoodContainer updated correctly with volume.
Test 51 passed: volume of FoodContainer updated correctly with weight.
Test 52 passed: volume of FoodContainer set to MaxCapacity after visiting port.

Test 53 passed: class Engine identified.
Test 54 passed: constructor of class Engine identified correctly.
Test 55 passed: method Double GetVelocity(Double) of class Engine identified correctly.
Test 56 passed: method Boolean CheckFuelBeforeTravel(Double) of class Engine identified correctly.
Test 57 passed: method Void Travel(Double) of class Engine identified correctly.
Test 58 passed: submarine velocity changed with mass.
Test 59 passed: CheckFuelBeforeTravel returned false for no fuel.
Test 60 passed: Travel method correctly updated fuel and waste values.

Test 61 passed: class LifeSupportSystem identified.
Test 62 passed: constructor of class LifeSupportSystem identified correctly.
Test 63 passed: method Boolean CheckSuppliesBeforeTravel(Double) of class LifeSupportSystem identified correctly.
Test 64 passed: method Void Run(Double) of class LifeSupportSystem identified correctly.
Test 65 passed: CheckSuppliesBeforeTravel returned false for no oxygen.
Test 66 passed: CheckSuppliesBeforeTravel returned false for no food.
Test 67 passed: Travel method correctly updated oxygen, food and waste values.

All tests passed! The submarine is ready to run.


Initial submarine weight: 211990

Current submarine weight: 211990
Travel destination accepted [10 km]
Important data gathered: _FWW08$a
Important data gathered: )1lRi;be/
Current submarine weight: 211990
Total trip cost:

Current submarine weight: 211990
Travel destination accepted [250 km]
Important data gathered: R,`f/|z
Important data gathered: <O{8R+wi

Current submarine weight: 211990
Total trip cost: 6

Current submarine weight: 211990
Travel destination accepted [1000 km]
Important data gathered: NiNd5DK
Important data gathered: H+.Pd\6
Current submarine weight: 211990
Total trip cost: 30

Current submarine weight: 211990
Not enough fuel to travel 1000000 km!
Available fuel: 50
Required travel time: 1,2 hours
