using System;
using Autor;
using PozycjaUmowy;
using Drukarnia;

namespace Baza
{
	public class baza
	{
		protected int maxID = 0;
	}
	class bazaKsiazek : baza
	{
		c_ksiazka ksiazki, temp_ksiazki;
		public void dodajKsiazke(string f_tytul, int f_rodzaj, string f_tekst)
		{
			if (maxID > 0)
			{
				temp_ksiazki = new c_ksiazka[maxID];
				for (int i = 0; i < maxID; i++)
				{
					temp_ksiazki[i] = ksiazki[i];
				}
				ksiazki = new c_ksiazka[++maxID];
				for (int i = 0; i < maxID - 1; i++)
				{
					ksiazki[i] = temp_ksiazki[i];
				}
				ksiazki[maxID - 1] = c_ksiazka(f_tytul, f_rodzaj, f_tekst, maxID - 1);
			}
			else
			{
				ksiazki = new c_ksiazka[++maxID];
				ksiazki[0] = c_ksiazka(f_tytul, f_rodzaj, f_tekst, maxID - 1);
			}
		}
		public string dump()
		{

		}
		public void usunKsiazke(c_ksiazka f_ksiazka)                        ///cala ta funckcja ale ze zmianami
		{
			int temp_i, temp;                                       ///nie wiem co zrobic z f_autor
			for (int i = 0; i < maxID; i++)
			{
				if (f_ksiazka == ksiazki[i])
				{
					temp = maxID - i;
					temp_i = i;
					for (int i = temp; i < maxID - 1; i++)
					{
						ksiazki[i] = ksiazki[i + 1];
					}
					for (int i = 0; i < maxID; i++)
					{
						temp_ksiazki[i] = ksiazki[i];
					}
					ksiazki = new c_ksiazka[maxID];
					for (int i = 0; i < maxID; i++)
					{
						ksiazki[i] = temp_ksiazki[i];
					}
					break;
				}
			}
		}
		public void testwypisywania()
		{
			for (int i = 0; i < maxID; i++)
			{
				Console.WriteLine(ksiazki[i].getId() + " " + ksiazki[i].getTytul() + " " + ksiazki[i].getAutor().getImie() + " " + ksiazki[i].getAutor().getNazwisko() + " " + ksiazki[i].getTekst() + "\n");
			}
		}
		public c_ksiazka dejksiazke(int f_id)
		{
			return ksiazki[f_id];
		}
	}
}

