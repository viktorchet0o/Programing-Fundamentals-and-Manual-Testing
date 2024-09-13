//Input
int trainingFee = int.Parse(Console.ReadLine());

//Calculations
double priceForBasketballSnikers = trainingFee * 0.6; // -40%
double priceForBasketballUniform = priceForBasketballSnikers * 0.8; // - 20%
double priceForBall = priceForBasketballUniform / 4;
double priceForAccessories = priceForBall / 5;

double finalPrice = trainingFee + priceForBasketballSnikers + priceForBasketballUniform + priceForBall + priceForAccessories;
Console.WriteLine(finalPrice);
//Output


