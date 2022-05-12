namespace Autor
{
    public class c_autor
    {
        private string imie;
        private string nazwisko;
        private int id = -1;
        public c_autor() { }
        public c_autor(string f_imie, string f_nazwisko, int f_id)
        {
            imie = f_imie;
            nazwisko = f_nazwisko;
            id = f_id;
        }
        public string getImie()
        {
            return imie;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }
        public static bool operator ==(c_autor l,c_autor r)
        {
            if (l.id==r.id)
                return true;
            return false;
        }
    }
    interface ZarzadzanieAutorami
    {
        virtual c_autor DodajAutora(string f_imie, string f_nazwisko, int f_ID)
        {
            return c_autor(f_imie, f_nazwisko, f_ID);
        }
    }
}