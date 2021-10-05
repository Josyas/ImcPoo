using System.Globalization;

namespace ImcPoo {
    class Imc {

        public double Altura;
        public double Peso;
        public string Nome;

        public double Resultado() {
            return Peso / (Altura * Altura);
            
        }

        public override string ToString() {
            return Nome + ","
                + "o seu IMC: "
                + Resultado().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}
