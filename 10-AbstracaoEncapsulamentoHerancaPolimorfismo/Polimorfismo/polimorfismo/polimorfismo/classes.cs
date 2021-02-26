using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    // ================================================

    // 1. Class Abstrata.
    abstract class forma_geometrica   
    {
        int _largura;
        int _altura;

        //------------------------------------------

        // 2. Propriedade.
        public int Largura  
        {
            get { return _largura; }
            set { _largura = value; }
        }

        //------------------------------------------

        // 3. Propriedade.
        public int Altura  
        {
            get { return _altura; }
            set { _altura = value; }
        }
        //------------------------------------------
        
        // 4. Metodo normal da classe Base.
        public void Apresentar()  
        {
            System.Diagnostics.Trace.WriteLine("Este método pertence à classe base.");
        }

        //------------------------------------------

        // 5. Método abstrata que terá que ser implementado em todas as classes derivadas.
        public abstract void Desenhar();

        //------------------------------------------

        // 6. Método virtual da classe Base
        public virtual void Desenhar_Outro()
        {
            System.Diagnostics.Trace.WriteLine("Método virtual da classe base.");
        }
    }

    // ================================================

    // 1. class derivada que herda da classe forma-geometrica
    class rectangulo : forma_geometrica
    {
        public override void Desenhar()  // Override do metodo virtual Desenhar()
        {
            System.Diagnostics.Trace.WriteLine("Desenhar rectangulo com as dimensoes: " + Largura + "x" + Altura);
        }

        public override void Desenhar_Outro()  // Override do metodo virtual Desenhar_Outro
        {
            System.Diagnostics.Trace.WriteLine("Este é um método virtual substituido na classe derivada.");
        }
    }

    // ================================================

    // 2. class derivada que herda da classe forma-geometrica
    class triangulo : forma_geometrica
    {
        public override void Desenhar()   // Override do metodo virtual Desenhar()
        {
            System.Diagnostics.Trace.WriteLine("Desenhar triangulo com as dimensoes: " + Largura + "x" + Altura);
        }
    }

    //================================================

    // 3. class derivada que herda da classe forma-geometrica
    class circunferencia : forma_geometrica
    {
        public override void Desenhar()  // Override do metodo virtual Desenhar()
        {
            System.Diagnostics.Trace.WriteLine("Desenhar circunferencia com as dimensoes: " + Largura + "x" + Altura);
        }
    }
}
