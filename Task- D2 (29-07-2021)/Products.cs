using System;
 

class Jarray


{


public static void Main()

{

String [][] Products = new String[3][];

Products[0] = new String[4]{"Milk cream","Hide&Seek","DarkFantasy","GoodDay"};

Products[1] = new String[5]{"KitKat","Munch","Rocher","DiaryMilk","Perk"};

Products[2] = new String[6]{"Milkshake","Cocacola","Maaza","Fruitnik","Pepsi","7UP"};

for(int i =0;i<Products.Length;i++)

{

for(int j=0;j<Products[i].Length;j++)

{

Console.Write(Products[i][j] +"\t");

Console.WriteLine();

}

}

}

}