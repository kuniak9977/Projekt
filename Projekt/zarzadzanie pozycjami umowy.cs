using System;
using Autor;
namespace PozycjaUmowy
{
	public class c_pozycja
	{
		protected string tytul;
		public c_autor autor = new c_autor();
		protected string tekst;
		protected int id = -1;
		public
			abstract int getRodzajInterwal();
			virtual c_autor getAutor()=0;
			virtual string getTytul()=0;
			virtual string getTekst()=0;
			virtual int getId()=0;
			virtual void przyznajTytul(string f_tytul)=0;
	}
	public class c_ksiazka : c_pozycja
    {
		protected int rodzaj = -1;
		c_ksiazka()
        {
			autor = c_autor();
        }
		c_ksiazka(string f_tytul,int f_rodzaj,string f_tekst,int f_id)
        {
			tytul = f_tytul;
			rodzaj = f_rodzaj;
			tekst = f_tekst;
			id = f_id;
        }
        c_ksiazka(c_ksiazka f_ksiazka)
        {
			autor=f_ksiazka.autor;
			rodzaj = f_ksiazka.rodzaj;
			tekst = f_ksiazka.tekst;
			id = f_ksiazka.id;
        }
		public void przyznajTytul(string f_tytul)
        {
			tytul=f_tytul;
        }
		public void dodajAutora(c_autor f_autor)
        {
			autor = f_autor;
        }
		public int getRodzajInterwal()
        {
			return rodzaj;
        }
		public c_autor getAutor()
        {
			return autor;
        }
		public string getTekst()
        {
			return tekst;
        }
		public int getID()
        {
			return id;
        }
		public bool operator == (c_ksiazka l, c_ksiazka r)
        {
			if (l.id == r.id)
				return true;
			return false;
        }
    }
	public class c_czasopismo : c_pozycja
    {
		protected int interwal = -1;
		public c_czasopismo() { }
		public c_czasopismo(string f_tytul,int f_interwal,string f_tekst,int f_id)
        {
			tytul = f_tytul;
			interwal = f_interwal;
			tekst = f_tekst;
			id = f_id;
        }
		public void przyznajTytul(string f_tytul)
		{
			tytul = f_tytul;
		}
		public void przyznajAutora(c_autor f_autor)
		{
			autor = f_autor;
		}
		public int getRodzajInterwal()
		{
			return interwal;
		}
		public c_autor getAutor()
		{
			return autor;
		}
		public string getTytul()
		{
			return tytul;
		}
		public string getTekst()
		{
			return tekst;
		}
		public int getId()
		{
			return id;
		}
		bool operator ==(c_czasopismo l, c_czasopismo r)
		{
			if (l.id == r.id)
				return true;
			return false;
		}
	}
	interface ZarzadzaniePozycjamiUmowy
    {
		public c_ksiazka dodajKsiazke(string f_tytul, int f_rodzaj, string f_tekst, int f_id)
		{
			return c_ksiazka(f_tytul, f_rodzaj, f_tekst, f_id);
		}
		public c_czasopismo dodajCzasopismo(string f_tytul, int f_interwal, string f_tekst, int f_id)
		{
			return c_czasopismo(f_tytul, f_interwal, f_tekst, f_id);
		}
	}
}
