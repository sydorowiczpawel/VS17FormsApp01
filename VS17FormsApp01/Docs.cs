namespace VS17FormsApp01

    //Pierwsza opcja klasy reprezentującej dokumenty

{
    public class Docs
    {
        static public int _id = 1;
        public string serial, number, mtgOg, mtgObc, km;
        public int id = _id;

        public Docs()
        {
            _id++;
        }
    }
}