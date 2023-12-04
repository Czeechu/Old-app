#include <iostream>
#include <cmath>

using namespace std;

/*
*
* 
* 
* 
* 
* 
* 
* 
* 
*
* 
* 
* 
* 
* 
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
	cin >> b;

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

//Napisz program, który poprosi u¿ytkownika o podanie promienia ko³a i obliczy pole tego ko³a, wyœwietlaj¹c wynik.

void variableTask8()
{
	float r;
	float pi = 3.14;
	int amount = 0;

	cout << "Podaj promieñ: ";
	cin >> r;

	amount = pi * pow(r, 2.0);

	cout << "Wynik: " << amount;
}

//Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci podstawy a, podstawy b i wysokoœci h trapezu, a nastêpnie obliczy pole tego trapezu, wyœwietlaj¹c wynik.

void variableTask9()
{
	float a, b, h;
	int amount = 0;
	
	cout << "Wprowad¿ podstawe a: ";
	cin >> a;
	cout << "Wprowad¿ podstawe b: ";
	cin >> b;
	cout << "Wprowad¿ wysokosc h: ";
	cin >> h;
	
	amount = ((a + b) * h) / 2;

	cout << "Wynik: " << amount;
}

//Napisz program, który poprosi u¿ytkownika o podanie d³ugoœci krawêdzi szeœcianu i obliczy jego objêtoœæ, wyœwietlaj¹c wynik.

void variableTask10()
{
	float a;
	int v = 0;

	cout << "Podaj dlugosc szescianu: ";
	cin >> a;

	v = a * a * a;

	cout << "Wynik: " << v;
}

//Napisz program, który poprosi u¿ytkownika o podanie temperatury w stopniach Celsiusza, a nastêpnie przeliczy j¹ na stopnie Fahrenheita i wyœwietli wynik.

void variableTask11()
{
	float c;
	float f;
	cout << " Podaj temperature w celcjuszach: ";
	cin >> c;
	cout << endl;
	f = (c * (9.0 / 5)) + 32;
	cout << " Temperatura w farenheitach wynosi: " << f << endl;
	cout << endl;
}

//Napisz program, który poprosi u¿ytkownika o podanie dwóch liczb ca³kowitych. Nastêpnie wykona operacje (+, -, *, /) i wyœwietli wyniki.

void variableTask12()
{
	int a, b, amount = 0;

	cout << "Podaj liczbe a: ";
	cin >> a;
	cout << "Podaj liczbe b: ";
	cin >> b;

	amount = a + b;
	amount = a - b;
	amount = a * b;
	amount = a / b;

	cout << "Wynik: " << amount;

}

//Napisz program, który poprosi u¿ytkownika o podanie liczby sekund i przeliczy je na godziny i minuty, wyœwietlaj¹c wynik.

void variableTask13()
{
	cout << "Podaj liczbe sekund: ";
	long long sekundy;
	cin >> sekundy;
	const int minuta = 60;
	const int godzina = (60 * 60);
	const int dzien = (24 * 60 * 60);
	int LiczbaGodzin = (sekundy % dzien) / (60 * 60);
	int LiczbaMinut = (sekundy % godzina) / 60;
	int LiczbaSekund = sekundy % minuta;
	cout << sekundy << " sekund = " << LiczbaGodzin << " godzin"
		<< LiczbaMinut << " minut " << LiczbaSekund << " sekund";

	cin.get();
	cin.get();
}

//Napisz program, który konwertuje wprowadzon¹ kwotê w jednej walucie na inn¹, korzystaj¹c z okreœlonego kursu wymiany.

void variableTask14()
{
	double kurs = 4.50;
	double kwota;

	string inputCurrency, startingCurrency;

	cout << "Podaj kwotê: ";
	cin >> kwota;

	cout << "Podaj walute wejsciowa np. USD: ";
	cin >> inputCurrency;
	cout << "Podaj walute wyjsciowa np. EUR: ";
	cin >> startingCurrency;

	if (inputCurrency == "PLN" && startingCurrency == "USD")
	{
		kwota /= kurs;
	}
	else if (inputCurrency == "USD" && startingCurrency == "PLN")
	{
		kwota *= kurs;
	}

	cout << "Wynik: " << kwota << " " << startingCurrency << endl;
}

//Napisz program, który poprosi u¿ytkownika o podanie wspó³rzêdnych (x1, y1) i (x2, y2) dwóch punktów w uk³adzie kartezjañskim, a nastêpnie obliczy odleg³oœæ miêdzy nimi, wyœwietlaj¹c wynik.

void variableTask15()
{
	double x1, x2, y1, y2;
	double odleglosc = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));

	cout << "Podaj wspolrzedne punktu P1 (x1, y1): ";
	cin >> x1 >> y1;
	cout << "Podaj wspolrzedne punktu P1 (x2, y2): ";
	cin >> x2 >> y2;

	cout << "Odleglosc miedzy punktami P1(" << x1 << ", " << y1 << ") i P2" << x2 << ", " << y2 << ") wynosi: " << odleglosc << endl;

	
}