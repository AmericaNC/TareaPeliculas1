using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public string pais;
        public Int16 año;
        public string director;
        //private List<Actor> actores = new List<Actor>();

        //Constructores
        public Int16 GetAño(){return año;}

        public void SetAño(Int16 a){año = a;}
        public string GetTitulo(){return Titulo;}

        public void SetTitulo(string t){Titulo = t;}
        public string Titulo { 
            get {return titulo;}
            set {titulo = value;}
            }
         public Int16 Año { 
            get {return año;}
            set {año = value;}
            }  
         public Pelicula(string Titulo, Int16 Año) {
            this.Titulo = Titulo;
            this.Año = Año;
            }
        public Pelicula() {

            }
        public void Imprime() {
          Console.WriteLine($"{Titulo} ({Año})");
            }
        }
         /*
        public Pelicula(string titulo, string pais, Int16 año, string director){
        this.titulo = titulo;
        this.pais = pais;
        this.año = año;
        this.director = director;
        } 
        //Métodos
        

       


   
    /*
    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas
    */
    class Program
    {
        static void Main(string[] args)
        { 
        List<Pelicula> peliculas = new List<Pelicula>();
        
        peliculas.Add(new Pelicula() { Titulo = "La La Land", año = 2016 });
        peliculas.Add(new Pelicula() { Titulo = "Green Book", año = 2019 });
        peliculas.Add(new Pelicula() { Titulo = "Parasite", año = 2019 });
        peliculas.Add(new Pelicula() { Titulo = "Pinocho", año = 2022 });
        peliculas.Add(new Pelicula() { Titulo = "CODA", año = 2021 });

        foreach (Pelicula p in peliculas)
        {
            Console.WriteLine($"{p.Titulo} ({p.año})");
        } 
           /*
           Pelicula p1 = new Pelicula();
           p1.SetTitulo("La La Land");
           p1.SetAño(2016);
           Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
           
           Pelicula p1 = new Pelicula("Parasitos","Corea del Sur",2019,"Bong Joon-ho");
           p1.Imprime();
           Pelicula p2 = new Pelicula("Green Book","EUA",2019,"Peter Farrelly");
           p2.Imprime(); */
        }
    }
}
