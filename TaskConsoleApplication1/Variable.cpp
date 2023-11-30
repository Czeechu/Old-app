#include <iostream>

using namespace std;

/*
*
* 
* 
* 
* Napisz program, który poprosi u¿ytkownika o podanie promienia ko³a i obliczy pole tego ko³a, wyœwietlaj¹c wynik.
* Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci podstawy a, podstawy b i wysokoœci h trapezu, a nastêpnie obliczy pole tego trapezu, wyœwietlaj¹c wynik.
* Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci krawêdzi szeœcianu i obliczy jego objêtoœæ, wyœwietlaj¹c wynik.
* Napisz program, który poprosi u¿ytkownika o podanie temperatury w stopniach Celsiusza, a nastêpnie przeliczy j¹ na stopnie Fahrenheita i wyœwietli wynik.
* Napisz program, który konwertuje wprowadzon¹ kwotê w jednej walucie na inn¹, korzystaj¹c z okreœlonego kursu wymiany.
*
* 
* 
* Napisz program, który poprosi u¿ytkownika o podanie dwóch liczb ca³kowitych. Nastêpnie wykona operacje (+, -, *, /) i wyœwietli wyniki.
* Napisz program, który poprosi u¿ytkownika o podanie liczby sekund i przeliczy je na godziny i minuty, wyœwietlaj¹c wynik.
* Napisz program, który poprosi u¿ytkownika o podanie wspó³rzêdnych (x1, y1) i (x2, y2) dwóch punktów w uk³adzie kartezjañskim, a nastêpnie obliczy odleg³oœæ miêdzy nimi, wyœwietlaj¹c wynik.
*/



// Napisz program, który wczyta od u¿ytkownika jego wiek a nastêpnie wyœwietli go na konsoli.

void variableTask1()
{
	int age;
	cout << "Wprowadz liczbe uzytkownika: ";
	cin >> age;
	cout << age;
}

//Stwórz program, który pobiera od u¿ytkownika d³ugoœæ w metrach i przelicza j¹ na centymetry, milimetry i  kilometry.Wyœwietl wynik.

void variableTask2()
{
	float m;
	cout << "Wprowadz dlugosc w metrach: ";
	cin >> m;
	cout << "cm: " << m / 100;
	cout << "cm: " << m * 1000;
	cout << "cm: " << m / 1000;

}

//Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci boku a i b prostok¹ta, a nastêpnie obliczy i wyœwietli pole prostok¹ta.

void variableTask3()
{
	float a, b;
	cout << "Wprowadz dlugosc boku a: ";
	cin >> a;
	cout << "Wprowadz dlugosc boku b: ";
	cin >> a;

	cout << a * b << "Pole prostokata: ";
}

//Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci podstawy i wysokoœci trójk¹ta, a nastêpnie obliczy pole tego trójk¹ta, wyœwietlaj¹c wynik.

void variableTask4() {
	float base, height;
	int amount = 0;
	cout << "Wprowadz podstawe: ";
	cin >> base;
	cout << "Wprwoadz wysokosc: ";
	cin >> height;
	
	amount = (base * height) / 2;
	cout << amount;
}

//Napisz program, który poprosi u¿ytkownika o podanie dwóch liczb(a, b) i obliczy œredni¹ arytmetyczn¹ tych liczb.Nastêpnie wyœwietli wynik.

void variableTask5() 
{
	float a, b;
	int amount = 0;
	cout << "Podaj liczbe pierwsza: ";
	cin >> a;
	cout << "Podaj liczbe druga: ";
	cin >> b;
	
	amount = (a + b) / 2;
	cout << amount;
	
}

//Napisz program, który poprosi u¿ytkownika o podanie trzech liczb (a, b, c) i obliczy œredni¹ arytmetyczn¹ tych liczb. Nastêpnie wyœwietli wynik.

void variableTask6()
{
	float a, b, c;
	int amount = 0;
	cout << "Podaj pierwsza liczbe: ";
	cin >> a;
	cout << "Podaj druga liczbe: ";
	cin >> b;
	cout << "Podaj trzecia liczbe: ";
	cin >> c;

	amount = (a + b + c) / 3;
	cout << amount;

}

//Program obliczaj¹cy œredni¹ wa¿on¹ trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.

void variableTask7()
{
	float a, b, c; 
	int w1 = 1;
	int w2 = 2;
	int w3 = 3;
	int amount = 0;
	
	cout << "Wprowadz liczbe z waga 1: ";
	cin >> a;
	cout << "Wprowadz liczbe z waga 2: ";
	cin >> b;
	cout << "Wprowadz liczbe z waga 3: ";
	cin >> c;

	amount = (a * w1 + b * w2 + c * w3) / w1 + w2 + w3;
	cout << "Srednia wazona: " << amount;


}