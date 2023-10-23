#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

void Sito(int n)
{
	vector<bool> A(n + 1, true);

	for (int i = 2; i <= sqrt(n); i++)
	{
		if (A[i])
		{
			for (int j = i * i; j <= n; j = j + i)
			{
				A[j] = false;
			}
		}
	}

	cout << "Liczby pierwsze w przedziale od 2 do 100: " << n << endl;
	for (int i = 2; i <= n; i++)
	{
		if (A[i])
		{
			cout << i << " ";
		}
	}

}


int main()
{
	int n = 100;
	Sito(n);
	return 0;
}

/*
*******************************************************
nazwa funkcji : sito
parametry wejściowe : n
wartość zwracana : zwraca liczby pierwsze w przedziale 2
informacje : program szuka liczb w przedziale 2...100
autor : FIlip Gos Czech
****************************************************
*/