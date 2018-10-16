### Problem 1.
## Exercises

## : Defining Classes

This document defines the **exercise assignments** for the [&quot;CSharp OOP Basics&quot; course @ Software University](https://softuni.bg/trainings/2084/csharp-oop-basics-october-2018#lesson-9805).

You can check your solutions here: [https://judge.softuni.bg/Contests/228/Defining-Classes](https://judge.softuni.bg/Contests/228/Defining-Classes)

1. Problem 1.Define a Class Person

**NOTE** : You need a **StartUp** class with the namespace **DefiningClasses**.

Define a class **Person** with **private** fields for **name** and **age** and **public** properties **Name** and **Age**.

### Bonus\*

Try to create a few objects of type Person:

| **Name** | **Age** |
| --- | --- |
| Pesho | 20 |
| Gosho | 18 |
| Stamat | 43 |

Use both the inline initialization and the default constructor.

1. Problem 2.Creating Constructors

**NOTE** : You need a **StartUp** class with the namespace **DefiningClasses**.

Add 3 constructors to the **Person** class from the last task, use constructor chaining to reuse code:

1. The first should take no arguments and produce a person with name &quot; **No name**&quot; and age = **1**.
2. The second should accept only an integer number for the age and produce a person with name &quot; **No name**&quot; and age equal to the passed parameter.
3. The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.

1. Problem 3.Oldest Family Member

Use your **Person**** class **from the previous tasks. Create a class** Family **. The class should have a** list of people**, a method for adding members (**void AddMember(Person member)**) and a method returning the oldest family member(**Person GetOldestMember()) **. Write a program that reads the names and ages of** N **people and** adds them to the family **. Then** print **the** name **and** age** of the oldest member.





### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 3Pesho 3Gosho 4Annie 5 | Annie 5 |   | 5Steve 10Christopher 15Annie 4Ivan 35Maria 34 | Ivan 35 |

1. Problem 4.Opinion Poll

Using the **Person** class, write a program that reads from the console **N** lines of personal information and then prints all people whose **age** is **more than 30** years, **sorted in alphabetical order**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3Pesho 12Stamat 31Ivan 48 | Ivan - 48Stamat - 31 |
| 5Nikolai 33Yordan 88Tosho 22Lyubo 44Stanislav 11 | Lyubo - 44Nikolai - 33Yordan - 88 |

1. Problem 5.Date Modifier

Create a class **DateModifier** which stores the difference of the days between two dates. It should have a method which takes **two string parameters**** representing a date **as strings and** calculates the** difference in the days between them.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1992 05 312016 06 17 | 8783 |
| 2016 05 312016 04 19 | 42 |

1. Problem 6.Company Roster

Define a class **Employee** that holds the following information: **name, salary, position, department, email** and **age**. The **name, salary** , **position** and **department** are **mandatory** while the rest are **optional**.

Your task is to write a program which takes **N** lines of employees from the console and calculates the department with the highest average salary and prints for each employee in that department his **name, salary, email and age** – **sorted by salary in descending order**. If an employee **doesn&#39;t have** an **email** – in place of that field you should print &quot; **n/a**&quot; instead, if he doesn&#39;t have an **age** – print &quot; **-1**&quot; instead. The **salary** should be printed to **two digits** after the decimal seperator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4Pesho 120.00 Dev Development pesho@abv.bg 28Toncho 333.33 Manager Marketing 33Ivan 840.20 ProjectLeader Development ivan@ivan.comGosho 0.20 Freeloader Nowhere 18 | Highest Average Salary: DevelopmentIvan 840.20 ivan@ivan.com -1Pesho 120.00 pesho@abv.bg 28 |
| 6Stanimir 496.37 Temp Coding stancho@yahoo.comYovcho 610.13 Manager SalesToshko 609.99 Manager Sales toshko@abv.bg 44Venci 0.02 Director BeerDrinking beer@beer.br 23Andrei 700.00 Director CodingPopeye 13.3333 Sailor SpinachGroup popeye@pop.ey | Highest Average Salary: SalesYovcho 610.13 n/a -1Toshko 609.99 toshko@abv.bg 44 |

1. Problem 7.Speed Racing

Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class **Car** that keeps a track of a car&#39;s **model, fuel amount, fuel consumption for 1 kilometer** and   **traveled distance**. A Car&#39;s model is **unique** - there will never be 2 cars with the same model.

 On the first line of the input you will receive a number **N** – the number of cars you need to track, on each of the next **N** lines you will receive information about a car in the following format &quot;\&lt; **Model\&gt; \&lt;FuelAmount\&gt; \&lt;FuelConsumptionFor1km\&gt;**&quot;. All **cars start at 0 kilometers traveled**.

After the **N** lines, until the command &quot; **End**&quot; is received, you will receive commands in the following format &quot; **Drive \&lt;CarModel\&gt;  \&lt;amountOfKm\&gt;**&quot;. Implement a method in the **Car** class to calculate whether or not a car can move that distance. If it can, the car&#39;s **fuel amount** should be **reduced** by the amount of **used**** fuel **and its** traveled ** ** distance **should be increased by the number of the** traveled kilometers**. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console &quot;**Insufficient fuel for the drive **&quot;. After the &quot;** End **&quot; command is received, print** each car **and its** current fuel amount **and the** traveled ****distance** in the format &quot; **\&lt;Model\&gt; \&lt;fuelAmount\&gt;  \&lt;distanceTraveled\&gt;**&quot;. Print the fuel amount rounded to **two digits** after the decimal separator.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2AudiA4 23 0.3BMW-M2 45 0.42Drive BMW-M2 56Drive AudiA4 5Drive AudiA4 13End | AudiA4 17.60 18BMW-M2 21.48 56 |
| 3AudiA4 18 0.34BMW-M2 33 0.41Ferrari-488Spider 50 0.47Drive Ferrari-488Spider 97Drive Ferrari-488Spider 35Drive AudiA4 85Drive AudiA4 50End | Insufficient fuel for the driveInsufficient fuel for the driveAudiA4 1.00 50BMW-M2 33.00 0Ferrari-488Spider 4.41 97 |

1. Problem 8.Raw Data

You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class **Car** that holds an information about **model, engine, cargo** and a **collection of exactly 4 tires**. The **engine** , **cargo** and **tire** shouldbe **separate classes**. Create a constructor that receives all of the information about the **Car** and creates and initializes its inner components (engine, cargo and tires).

On the first line of input you will receive a number **N** - the amount of cars you have. On each of the next **N** lines you will receive an information about a car in the format &quot; **\&lt;Model\&gt; \&lt;EngineSpeed\&gt; \&lt;EnginePower\&gt; \&lt;CargoWeight\&gt; \&lt;CargoType\&gt; \&lt;Tire1Pressure\&gt; \&lt;Tire1Age\&gt; \&lt;Tire2Pressure\&gt; \&lt;Tire2Age\&gt; \&lt;Tire3Pressure\&gt; \&lt;Tire3Age\&gt; \&lt;Tire4Pressure\&gt; \&lt;Tire4Age\&gt;&quot;** where the speed, power, weight and tire age are **integers** , tire preassure is a **double.**

After the **N** lines you will receive a single line with one of 2 commands: &quot; **fragile**&quot; or &quot; **flamable**&quot;. If the command is &quot; **fragile**&quot; print all cars whose **Cargo Type is &quot;fragile&quot;** with **a tire** whose **pressure is**   **\&lt; 1**. If the command is &quot; **flamable**&quot; print all of the cars whose **Cargo Type is &quot;flamable&quot;** and have **Engine Power \&gt; 250**. The cars should be printed in order of appearing in the input.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1fragile | Citroen2CV |
| 4ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2flamable | ChevroletExpressDaciaDokker |

1. Problem 9.Rectangle Intersection

Create a class **Rectangle**. It should consist of an **id, width, height** and the **coordinates of its top left corner** ( **horizontal and vertical** ). Create a **method** which **receives as a parameter**** another Rectangle **, checks if the two rectangles** intersect **and** returns true or false**.

On the first line you will receive the **number of rectangles** – **N** and the number of **intersection checks** – **M**. On the next **N** lines, you will get the rectangles with their **id, width, height and coordinates**. On the last **M** lines, you will get **pairs of ids** which represent rectangles. Print if each of the pairs **intersect.**

You will always receive a valid data. There is no need to check if a rectangle exists.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 1Pesho 2 2 0 0Gosho 2 2 0 0Pesho Gosho | true |

1. Problem 10.Car Salesman

Define two classes **Car** and **Engine.** A **Car** has a **model, engine, weight** and **color**. An Engine has a **model** , **power, displacement** and an **efficiency**. A Car&#39;s **weight** and **color** and its Engine&#39;s **displacements** and **efficiency** are **optional**.

On the first line you will read a number **N** which will specify how many lines of engines you will receive. On each of the next **N** lines you will receive information about an **Engine** in the following format &quot;\&lt; **Model\&gt; \&lt;Power\&gt; \&lt;Displacement\&gt; \&lt;Efficiency\&gt;**&quot;. After the lines with engines, on the next line you will receive a number **M** – specifying the number of Cars that will follow. On each of the next **M** lines, an information about a **Car** will follow in the format &quot;\&lt; **Model\&gt; \&lt;Engine\&gt; \&lt;Weight\&gt; \&lt;Color\&gt;**&quot;, where the engine will be the **model of an existing**** Engine **. When creating the object for a** Car **, you should keep a** reference to the real engine** in it, instead of just the engine&#39;s model.
Note that the optional properties **might be missing** from the formats.

Your task is to print each car (in the order you received them) and its information in the format defined bellow, if any of the optional fields has not been given print &quot; **n/a**&quot; in its place instead:

\&lt;CarModel\&gt;:
  \&lt;EngineModel\&gt;:
    Power: \&lt;EnginePower\&gt;
    Displacement: \&lt;EngineDisplacement\&gt;
    Efficiency: \&lt;EngineEfficiency\&gt;
  Weight: \&lt;CarWeight\&gt;
  Color: \&lt;CarColor\&gt;

### Bonus\*

Override the classes&#39; **ToString** () methods to have a reusable way of displaying the objects.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2V8-101 220 50V4-33 140 28 B3FordFocus V4-33 1300 SilverFordMustang V8-101VolkswagenGolf V4-33 Orange | FordFocus:  V4-33:    Power: 140    Displacement: 28    Efficiency: B  Weight: 1300  Color: SilverFordMustang:  V8-101:
    Power: 220
    Displacement: 50    Efficiency: n/a  Weight: n/a  Color: n/aVolkswagenGolf:  V4-33:    Power: 140    Displacement: 28    Efficiency: B  Weight: n/a  Color: Orange |
| 4DSL-10 280 BV7-55 200 35DSL-13 305 55 A+V7-54 190 30 D4FordMondeo DSL-13 PurpleVolkswagenPolo V7-54 1200 YellowVolkswagenPassat DSL-10 1375 BlueFordFusion DSL-13 | FordMondeo:  DSL-13:    Power: 305    Displacement: 55    Efficiency: A+  Weight: n/a  Color: PurpleVolkswagenPolo:  V7-54:    Power: 190    Displacement: 30    Efficiency: D  Weight: 1200  Color: YellowVolkswagenPassat:  DSL-10:    Power: 280    Displacement: n/a    Efficiency: B  Weight: 1375  Color: BlueFordFusion:  DSL-13:    Power: 305    Displacement: 55    Efficiency: A+  Weight: n/a  Color: n/a |

1. Problem 11.Pokemon Trainer

You want to be the very best pokemon trainer, like no one ever was, so you set out to catch pokemon. Define a class **Trainer** and a class **Pokemon**. Trainers have a **name** , **number of badges** and a **collection of pokemon** , **Pokemon** have a **name** , an **element** and **health** , all values are **mandatory**. Every Trainer **starts with 0 badges**.

From the console you will receive an unknown number of lines until you receive the command &quot; **Tournament**&quot;. Each line will carry information about a pokemon and the trainer who caught it in the format &quot;\&lt; **TrainerName\&gt; \&lt;PokemonName\&gt; \&lt;PokemonElement\&gt; \&lt;PokemonHealth\&gt;&quot;** where **TrainerName** is the name of the Trainer who caught the pokemon. Trainers&#39; names are **unique**.
After receiving the command &quot; **Tournament**&quot;, an unknown number of lines containing one of the three elements &quot; **Fire**&quot;, &quot; **Water**&quot;, &quot; **Electricity**&quot; will follow until the &quot; **End**&quot; command is received. For every command you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise, all of his pokemon **lose 10 health**. If a pokemon falls **to 0 or less health** , **he dies** and must be deleted from the trainer&#39;s collection.
After the &quot; **End**&quot; command is received you should print all of the trainers **sorted by the amount of badges they have in descending order** (if two trainers have the same amount of badges, they should be sorted by order of appearance in the input)in the format &quot;\&lt; **TrainerName\&gt; \&lt;Badges\&gt; \&lt;NumberOfPokemon\&gt;**&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Charizard Fire 100Gosho Squirtle Water 38Pesho Pikachu Electricity 10TournamentFireElectricityEnd | Pesho 2 2Gosho 0 1 |
| Stamat Blastoise Water 18Nasko Pikachu Electricity 22Jicata Kadabra Psychic 90TournamentFireElectricityFireEnd | Nasko 1 1Stamat 0 0Jicata 0 1 |

1. Problem 12.Google

Google is always watching you, so it should come as no surprise that they **know**** everything ****about**** you**(even your pokemon collection). Since you&#39;re really good at writing classes, Google asked you to design a class that can hold**all **of the** information **they need** for ****people**.

From the console you will receive an unkown amount of lines until the command &quot; **End**&quot; is read. On each of those lines there will be an information about a person in one of the following formats:

- &quot; **\&lt;Name\&gt; company \&lt;companyName\&gt; \&lt;department\&gt; \&lt;salary\&gt;**&quot;
- &quot; **\&lt;Name\&gt; pokemon \&lt;pokemonName\&gt; \&lt;pokemonType\&gt;&quot;**
- &quot; **\&lt;Name\&gt; parents \&lt;parentName\&gt; \&lt;parentBirthday\&gt;**&quot;
- &quot; **\&lt;Name\&gt; children \&lt;childName\&gt; \&lt;childBirthday\&gt;**&quot;
- &quot; **\&lt;Name\&gt; car \&lt;carModel\&gt; \&lt;carSpeed\&gt;**&quot;

You should structure all of the information about a person in a class with nested subclasses. People&#39;s names are **unique** - there won&#39;t be 2 people with the same name. A person can also have **only one**** company **and** one ****car** , but can have **multiple**** parents, children **and** pokemons **. After the command &quot;** End **&quot; is received, on the next line you will receive a single name. You should print all of the information about that person. Note that information can change during the input - for instance if we receive multiple lines which specify a person&#39;s company, only the** last one **should be the one remembered. The salary must be formated to** two digits** after the decimal seperator.



### Examples

| **Input** | **Output** |
| --- | --- |
| PeshoPeshev company PeshInc Management 1000.00TonchoTonchev car Trabant 30PeshoPeshev pokemon Pikachu ElectricityPeshoPeshev parents PoshoPeshev 22/02/1920TonchoTonchev pokemon Electrode ElectricityEndTonchoTonchev | TonchoTonchevCompany:Car:Trabant 30Pokemon:Electrode ElectricityParents:Children:  |
| JelioJelev pokemon Onyx RockJelioJelev parents JeleJelev 13/03/1933GoshoGoshev pokemon Moltres FireJelioJelev company JeleInc Jelior 777.77JelioJelev children PudingJelev 01/01/2001StamatStamatov pokemon Blastoise WaterJelioJelev car AudiA4 180JelioJelev pokemon Charizard FireEndJelioJelev | JelioJelevCompany:JeleInc Jelior 777.77Car:AudiA4 180Pokemon:Onyx RockCharizard FireParents:JeleJelev 13/03/1933Children:PudingJelev 01/01/2001  |

### Bonus\*

Override the ToString() method in the classes to standardize the displaying of objects.

1. Problem 13.Family Tree

You want to build your family tree, so you went to ask your grandmother. Sadly, your grandmother keeps remembering information about your predecessors in pieces, so it falls to you to group the information and build the family tree.

On the first line of input you will receive either a name or a birthdate in the format &quot;\&lt; **FirstName\&gt; \&lt;LastName\&gt;&quot;** or **&quot;day/month/year**&quot; – your task is to find the person&#39;s information in the family tree. On the next lines until the command &quot; **End**&quot; is received you will receive an information about your predecessors that you will use to build the family tree.

The information will be in one of the following formats:

- &quot; **FirstName LastName - FirstName LastName**&quot;
- &quot; **FirstName LastName - day/month/year**&quot;
- &quot; **day/month/year - FirstName LastName**&quot;
- &quot; **day/month/year - day/month/year**&quot;
- &quot; **FirstName LastName day/month/year**&quot;

The first four formats reveal a family tie – **the person on the left is parent to the person on the right** (as you can see the format does not need to contain names, for example the 4

# th
 format means the person born on the left date is parent to the person born on the right date). The last format ties different information together – i.e. **the person with that name was born on that date**. **Names** and **birthdates** are **unique** – there won&#39;t be 2 people with the same name or birthdate, there will **always** be enough entries to construct the family tree (all people&#39;s names and birthdates are known and they have at least one connection to another person in the tree).

After the command &quot; **End**&quot; is received, you should print all of the information about the person whose name or birthdate you&#39;ve received on the first line – his **name, birthday, parents and children** (check the examples for the format). The people in the parents&#39; and childrens&#39; lists should be ordered by their first appearance in the input (regardless if they appeared as a birthdate or a name, for example in the first input Stamat is before Penka because he has appeared first on the second line, while she appears on the third one).

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Peshev11/11/1951 - 23/5/1980Penka Pesheva - 23/5/1980Penka Pesheva 9/2/1953Pesho Peshev - Gancho PeshevGancho Peshev 1/1/2005Stamat Peshev 11/11/1951Pesho Peshev 23/5/1980End | Pesho Peshev 23/5/1980Parents:Stamat Peshev 11/11/1951Penka Pesheva 9/2/1953Children:Gancho Peshev 1/1/2005  |
| 13/12/199325/3/1934 - 4/4/1961Poncho Tonchev 25/3/19344/4/1961 - Moncho TonchevToncho Tonchev - Lomcho TonchevMoncho Tonchev 13/12/1993Lomcho Tonchev 7/7/1995Toncho Tonchev 4/4/1961End | Moncho Tonchev 13/12/1993Parents:Toncho Tonchev 4/4/1961Children: |