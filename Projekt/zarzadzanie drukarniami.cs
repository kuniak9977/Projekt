using System;

namespace Drukarnia
{
	public class c_drukarnia
	{
		private bool Drukowanie = false;
		private string nazwa;
		private int id = -1;
        c_drukarnia() { }
		c_drukarnia(bool f_Drukowanie,string f_nazwa,int f_id)
        {
			this.Drukowanie = f_Drukowanie;
			this.nazwa = f_nazwa;
			this.id = f_id;
        }
		public bool operator == (c_drukarnia l, c_drukarnia r)
        {
			if (l.id == r.id)
				return true;
			return false;
        }
	}
	interface ZarzadzanieDrukarniami
    {
		virtual c_drukarnia DodanieDrukarni(bool f_Drukowanie,string f_nazwa,int f_id)
        {
			return c_drukarnia(f_Drukowanie,f_nazwa,f_id);
        }
    }
}
