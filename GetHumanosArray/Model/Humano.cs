namespace GetHumanoArray.Model
{
    public class Humano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }

        public Humano(int Id, string Nombre, string Sexo, int Edad, decimal Altura, decimal Peso)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Edad = Edad;
            this.Altura = Altura;
            this.Peso = Peso;

        }
    }
}
