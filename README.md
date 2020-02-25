# CustomList_project

#Operator Overloads

-
*********************************
Syntax: 
Custom List Instance 1 - Custom List Instance 2
Where both lists must carry equal types.

Parameters: 
CustomList1<Type>, CustomList2<Type>

Return Type:
CustomList<Type>

//Examples//
CustomList<int> ages = new CustomList<int>();
CustomList<int> ages2 = new CustomList<int>();
CustomList<string> names = new CustomList<string>();
CustomList<string> names2 = new CustomList<string>();

ages.Add(20);
ages.Add(21);
ages.Add(22);
ages.Add(23);
ages.Add(23);
ages2.Add(20);
ages2.Add(23);

names.Add("James");
names.Add("Nevin");
names.Add("Michael");
names.Add("Michael");
names2.Add("James");
names2.Add("James");

//1: ages = ages - ages2;
//2: names = names2 - names;
//3: ages = names - age2;


//Outputs
//1: {21, 22}
//2: {}
//3: ERROR: Operand - cannot be applied to diffferent types.